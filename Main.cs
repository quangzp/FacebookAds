using Model;
using System.Reflection;
using Timer = System.Timers.Timer;

namespace AutoAds
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private Dictionary<string, DateTime> time_updated_dic = new Dictionary<string, DateTime>();

        private readonly Dictionary<string, string> ACCOUNTS = new Dictionary<string, string>
        {

        };

        string _path = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\tokens.txt";

        Timer timer = new Timer();

        private void Form1_Load(object sender, EventArgs e)
        {

            timer.Interval = Constant.MINUTES_1;
            timer.Elapsed += Timer_Elapsed;

            label2.Text = $"Đã update: ";
            label1.Text = "Cập nhật vào lúc :";

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.Columns.Add("camp_id", "ID");
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add("name", "Tên");
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns.Add("spend", "Số tiền đã chi");
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns.Add("result", "Kết quả");
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns.Add("cost_per_mess", "Giá mỗi kết quả");
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns.Add("status", "Trạng thái");
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns.Add("time_stop", "Cập nhật vào lúc");
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns.Add("acc_name", "Tài khoản");
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //btn_auto.Enabled = btn_report.Enabled = btn_create_camp.Enabled = false;
            check();

        }

        private void check()
        {
            ACCOUNTS.Clear();

            if (File.Exists(_path))
            {
                string[] tokens = File.ReadAllLines(_path);

                foreach (var item in tokens)
                {
                    string[] acc_token = item.Split("-");
                    if (!Constant.ACCOUNTS.ContainsKey(acc_token[0]))
                    {
                        continue;
                    }
                    var ad_accounts = Constant.ACCOUNTS[acc_token[0]];

                    bool is_valid_token = FBApi.Instance.check_token(acc_token[1], out string id);

                    if (is_valid_token)
                    {
                        foreach (var acc in ad_accounts)
                        {
                            ACCOUNTS.Add(acc, acc_token[1]);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"{acc_token[0]}: token is invalid", "Lỗi");
                        Form token_form = new TokenForm(this, acc_token[0]);
                        token_form.ShowDialog();
                    }
                }
            }
        }


        private void insert_DGV(AdSet insight)
        {
            DataGridViewRow row = new DataGridViewRow();
            dataGridView1.Invoke(() =>
            {
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = insight.campaign_id;
                row.Cells[1].Value = insight.name;
                row.Cells[2].Value = insight.spend;
                row.Cells[3].Value = insight.mess_result;
                row.Cells[4].Value = insight.cost_per_mess;
                row.Cells[5].Value = insight.is_active ? "Bật" : "Tắt";
                row.Cells[6].Value = insight.time_update.ToString("HH:mm");
                row.Cells[7].Value = insight.acc_name;

                dataGridView1.Rows.Insert(0, row);
            });
        }

        private async void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                var camp_ins = (await Task.WhenAll(ACCOUNTS.Select(p => check_camp(p.Value, p.Key)))).SelectMany(list => list).ToList();


                foreach (var camp in camp_ins)
                {
                    insert_DGV(camp);
                }

                if (!this.IsDisposed)
                {
                    this.Invoke(() =>
                    {
                        label1.Text = $"Cập nhật vào lúc : {DateTime.Now.ToString("HH:mm")}";
                        label2.Text = $"Đã update: {time_updated_dic.Count} camp";
                    });
                }
            }
            catch (Exception)
            {


            }

        }

        bool is_running = false;
        private void button2_Click(object sender, EventArgs e)
        {
            //if (!FBApi.Instance.ping_host()) return;

            if (is_running)
            {
                btn_auto.Invoke(new Action(() =>
                {
                    btn_auto.Text = "Run";
                    btn_auto.BackColor = Color.Chartreuse;
                }));
                timer.Stop();

            }
            else
            {
                btn_auto.Invoke(new Action(() =>
                {
                    btn_auto.Text = "Stop";
                    btn_auto.BackColor = Color.OrangeRed;
                }));
                timer.Start();
            }
            is_running = !is_running;
        }

        private async Task<List<AdSet>> check_camp(string token, string acc_id)
        {
            var results = new List<AdSet>();


            var active_task = FBApi.Instance.get_list(token, acc_id, Constant.STATUS_ACTIVE);
            //var paused_task = FBApi.Instance.get(acc, Constant.STATUS_PAUSED);

            // filter nhung camps duoc thay doi so voi luc dau
            var modified_camps = Task.WhenAll(active_task).Result
                                        .SelectMany(list => list)
                                        .Where(c => c.is_modified);


            foreach (var adset in modified_camps)
            {
                //if (acc_id.Equals("134254563345835")) continue;
                if (acc_id.Equals("255871387") && !adset.name.Trim().StartsWith("quang", StringComparison.CurrentCultureIgnoreCase)) continue;
                if (adset.name.Trim().StartsWith("tương tác", StringComparison.CurrentCultureIgnoreCase)) continue;
                if (adset.name.Contains('*')) continue;

                if (!check_updatable(adset.campaign_id)) continue;

                string status = adset.is_active ? Constant.STATUS_ACTIVE : Constant.STATUS_PAUSED;

                var parameters = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("status", status)
                };

                bool success = await FBApi.Instance.updateStatus(token, adset.campaign_id, parameters);

                if (success)
                {

                    adset.time_update = DateTime.Now;
                    adset.acc_name = Constant.ACC_NAME[acc_id];
                    results.Add(adset);
                }
            }

            return results;
        }

        private bool check_updatable(string id)
        {
            if (time_updated_dic.ContainsKey(id))
            {
                var duration = DateTime.Now - time_updated_dic[id];
                int int_duration = duration.Minutes;

                // nếu quá 5 phút thì sẽ được update lại trạng thái
                if (int_duration > 5)
                {
                    time_updated_dic[id] = DateTime.Now;
                    return true;
                }

                return false;

            }
            // nếu không tìm thấy thì là id mới
            time_updated_dic.Add(id, DateTime.Now);
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(ACCOUNTS);
            form2.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            btn_refresh.Enabled = false;
            check();
            btn_refresh.Enabled = true;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Form export_form = new ExportExcel();
            export_form.ShowDialog();
            export_form.Dispose();
        }
    }
}
