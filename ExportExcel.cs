using Model;
using Models;
using System.Reflection;

namespace AutoAds
{
    public partial class ExportExcel : Form
    {
        public ExportExcel()
        {
            InitializeComponent();
        }

        string _path = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\tokens.txt";

        Dictionary<string, string> acc_token = new Dictionary<string, string>();

        private void ExportExcel_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_path))
            {
                MessageBox.Show("Không tồn tại file tokens");
                this.Dispose();
            }

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].DataPropertyName = dataGridView1.Columns[i].Name;
            }

            Dictionary<string, string> acc = new Dictionary<string, string>();

            var lines = File.ReadAllLines(_path);

            foreach (var line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] data = line.Split('-');
                    acc_token.Add(data[0], data[1]);
                }
            }

            Dictionary<string, string> acc_name = new Dictionary<string, string>()
            {
                {"2079053778967911","Ichic" },
                {"485423563506298", "CÁM" }
            };
            cb_acc_page.DataSource = new BindingSource(acc_name, null);
            cb_acc_page.DisplayMember = "Value";
            cb_acc_page.ValueMember = "Key";
        }

        private void insert_DGV(Campaign campaign)
        {
            DataGridViewRow row = new DataGridViewRow();
            dataGridView1.Invoke(() =>
            {
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = false;
                row.Cells[1].Value = campaign.name;
                row.Cells[2].Value = campaign.result;
                row.Cells[3].Value = campaign.cpm;
                row.Cells[4].Value = campaign.spend;
                row.Cells[5].Value = campaign.acc;
                dataGridView1.Rows.Insert(0, row);
            });
        }

        private async Task search_field_changed()
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tb_tien.Text = "";
                tb_data.Text = "";
            }));

            progressBar1.Value = 0;
            progressBar1.MarqueeAnimationSpeed = 10;
            progressBar1.Visible = true;
            string acc = cb_acc_page.SelectedValue.ToString();
            var start = dtp_start.Value;
            var end = dtp_end.Value;
            var list_ads_acc = check_list_acc.CheckedItems.OfType<string>().Select(s => s.Split('-')[1]);
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            if (string.IsNullOrWhiteSpace(acc))
            {
                progressBar1.Visible = false;

                return;
            }

            if (start.Day > end.Day)
            {
                progressBar1.Visible = false;

                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc");
                return;
            }

            if (acc_token.TryGetValue(acc, out string token))
            {
                var list_camp = (await Task.WhenAll(list_ads_acc.Select(s => FBApi.Instance.get_list_camp(token, s, start, end)))).SelectMany(list => list).ToList();

                //for (int i = 0; i < list_camp.Count - 1; i++)
                //{
                //    for (int j = i + 1; j < list_camp.Count; j++)
                //    {
                //        int score = LevenshteinDistance.Compute(list_camp[i].name.Substring(0, 4), list_camp[j].name.Substring(0, 4));
                //        if (score == 0)
                //        {
                //            list_camp[i].Merge(list_camp[j]);
                //            list_camp.RemoveAt(j);
                //            j--;
                //        }
                //    }
                //}

                list_camp.ForEach(camp => insert_DGV(camp));

                this.Invoke(new MethodInvoker(() =>
                {
                    long tong_tien = list_camp.Select(s => s.spend).Sum();
                    long data = list_camp.Select(s => s.result).Sum();
                    tb_tien.Text = $"{tong_tien}";
                    tb_data.Text = $"{data}";
                }));
            }
            else
            {
                MessageBox.Show("Không tìm thấy token");
            }

            progressBar1.Visible = false;
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == dataGridView1.Columns["select"].Index)
        //    {
        //        var cell = dataGridView1.CurrentCell as DataGridViewCheckBoxCell;

        //        if (cell != null && !cell.ReadOnly)
        //        {
        //            cell.Value = cell.Value == null || !((bool)cell.Value);
        //            int selected_rows = 0;

        //            foreach (DataGridViewRow row in dataGridView1.Rows)
        //            {
        //                bool isSelected = Convert.ToBoolean(row.Cells[0].Value);
        //                if (isSelected)
        //                {
        //                    selected_rows++;
        //                }
        //            }

        //            if (selected_rows >= 1)
        //            {
        //                btn_merge.Enabled = true;

        //            }
        //            else
        //            {
        //                btn_merge.Enabled = false;
        //            }

        //        }
        //    }
        //}

        private void btn_merge_Click(object sender, EventArgs e)
        {
            //List<DataGridViewRow> rows = new List<DataGridViewRow>();

            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    bool is_selected = Convert.ToBoolean(row.Cells[0].Value);
            //    if (is_selected)
            //    {

            //        rows.Add(row);
            //    }
            //}

            //var r = rows[0];
            //r.Cells["name"].Value = textBox1.Text;
            //for (int i = 1; i < rows.Count; i++)
            //{

            //}
        }

        private async void btn_search_Click(object sender, EventArgs e)
        {
            await search_field_changed();
        }
    }
}
