using Model;
using System.Reflection;

namespace AutoAds
{
    public partial class TokenForm : Form
    {

        private string acc;
        private Form main;
        private bool _success = false;

        public TokenForm(Form main, string acc)
        {
            InitializeComponent();
            this.acc = acc;
            this.main = main;
            this.FormClosing += TokenForm_FormClosing;
        }

        private void TokenForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            try
            {
                if (!_success) main.Close();
            }
            catch (Exception)
            {


            }
        }

        readonly string _path = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\tokens.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            _success = false;
            string new_token = textBox1.Text;
            if (string.IsNullOrEmpty(new_token)) { return; }

            try
            {
                bool success = FBApi.Instance.check_token(new_token, out string _);
                if (success)
                {
                    string str = string.Empty;
                    using (var reader = new StreamReader(_path))
                    {
                        while (reader.Peek() >= 0)
                        {
                            var acc_token = reader.ReadLine();
                            if (!string.IsNullOrEmpty(acc_token) && acc_token.StartsWith(acc))
                            {
                                str = File.ReadAllText(_path);
                                str = str.Replace(acc_token, $"{acc}-{new_token}");
                                break;
                            }
                        }
                    }

                    File.WriteAllText(_path, str);
                    _success = true;
                    this.Close();
                }
                else
                {
                    _success = false;
                    MessageBox.Show("Token is invalid!!");
                }
            }
            catch (Exception)
            {
                _success = false;
            }
        }

    }
}
