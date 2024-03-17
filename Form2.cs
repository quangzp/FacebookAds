using Model;
using Newtonsoft.Json;

namespace AutoAds
{
    public partial class Form2 : Form
    {
        private string token = string.Empty;
        private Dictionary<string, string> ACCOUNTS = new Dictionary<string, string>();

        //public Form2()
        //{
        //    InitializeComponent();

        //}

        public Form2(Dictionary<string, string> acc, string token)
        {
            InitializeComponent();
            this.token = token;
            this.ACCOUNTS = acc;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //cb_accounts.SelectedIndex = 0;
            tb_budget.Text = "50000";
            num_age_min.Value = 25;
            num_age_max.Value = 38;

            set_cb_pages(token);
            set_cb_ads_accounts(token);
        }

        private async void btn_create_Click(object sender, EventArgs e)
        {
            this.Invoke(() =>
            {
                btn_create.Enabled = false;

            });
            try
            {

                string acc_json = JsonConvert.SerializeObject(cb_accounts.SelectedItem);
                string account_id = JsonConvert.DeserializeObject<Models.ComboBoxItem>(acc_json).Key;


                string page_json = JsonConvert.SerializeObject(cb_pages.SelectedItem);
                string page_id = JsonConvert.DeserializeObject<Models.ComboBoxItem>(page_json).Key;


                Dictionary<int, int> age_ranges = new Dictionary<int, int>();

                if (cb_adsets.Checked)
                {
                    foreach (var item in checkedListBox1.CheckedItems)
                    {
                        string[] range = item.ToString().Split("-");
                        age_ranges.Add(int.Parse(range[0]), int.Parse(range[1]));
                    }
                }
                else
                {
                    int age_min = (int)num_age_min.Value;
                    int age_max = (int)num_age_max.Value;
                    age_ranges.Add(age_min, age_max);
                }


                var start_time = (date_picker.Value.Date + time_picker.Value.TimeOfDay);
                string budget = tb_budget.Text;

                var posts = richTextBox1.Lines;
                for (int i = 0; i < posts.Length; i++)
                {
                    string post = posts[i];
                    if (string.IsNullOrWhiteSpace(post))
                    {
                        continue;
                    }


                }

                bool target_city = cb_city.Checked;
                bool is_bid_amount = cb_bidAmount.Checked;
                bool reaction = cb_reaction.Checked;
                bool adset_budget = cb_adset_bubget.Checked;

                //string token = acc_token[account_id];
                var task = posts.Select(post => create(token, account_id, page_id, post, age_ranges, budget, true, start_time, target_city, is_bid_amount, reaction, adset_budget)).ToList();
                await Task.WhenAll(task);

                MessageBox.Show("Hoàn thành");
            }
            catch (Exception)
            {


            }
            finally
            {
                this.Invoke(() => { btn_create.Enabled = true; });

            }


        }

        private async Task create(string token, string account_id, string page_id, string post, Dictionary<int, int> age_ranges, string budget, bool target_checked, DateTime start_time, bool target_city, bool is_bid_amount, bool reaction, bool adset_budget)
        {
            if (string.IsNullOrWhiteSpace(post))
            {
                return;
            }

            string[] info = post.Split('-');
            string name = $"{info[0]} {start_time.Day}/{start_time.Month} ({start_time.Hour})";
            string post_id = info[1].Trim();

            bool success = await FBApi.Instance.create_camp(token, account_id, name, page_id, post_id, age_ranges, budget, target_checked, start_time, target_city, is_bid_amount);
            if (!success)
            {
                this.Invoke(() =>
                {
                    if (!string.IsNullOrWhiteSpace(logRichTextBox.Text))
                    {
                        logRichTextBox.AppendText("\r\n" + $"Lỗi {name}");
                    }
                    else
                    {
                        logRichTextBox.AppendText($"Lỗi {name}");
                    }
                    logRichTextBox.ScrollToCaret();
                });

            }
        }

        private void cb_adsets_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_adsets.Checked)
            {
                checkedListBox1.Enabled = true;
            }
            else
            {
                checkedListBox1.Enabled = false;
            }
        }

        private void set_cb_pages(string token)
        {
            cb_pages.ValueMember = "Key";
            cb_pages.DisplayMember = "Value";
            try
            {

                Dictionary<string, string> pages = Task.Run(() => FBApi.Instance.get_pages(token)).Result;

                if (pages.Any())
                {
                    cb_pages.Items.AddRange(pages.OrderBy(od => od.Value).Select(s => new { s.Key, s.Value }).ToArray());
                    cb_pages.SelectedIndex = 0;
                }
            }
            catch (Exception e)
            {


            }
        }

        private void set_cb_ads_accounts(string token)
        {
            cb_accounts.ValueMember = "Key";
            cb_accounts.DisplayMember = "Value";
            try
            {
                if (!ACCOUNTS.Any())
                {
                    ACCOUNTS = Task.Run(() => FBApi.Instance.get_ad_accounts(token)).Result;

                }


                cb_accounts.Items.AddRange(ACCOUNTS.OrderBy(od => od.Value).Select(s => new { s.Key, s.Value }).ToArray());
                cb_accounts.SelectedIndex = 0;

            }
            catch (Exception e)
            {


            }
        }

    }
}
