using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSDLNC.Shared
{
    class Utils
    {
        public static void ShowForm(Panel p, Form f)
        {
            f.TopLevel = false;
            p.Controls.Clear();
            p.Controls.Add(f);
            f.Width = p.Width;
            f.Height = p.Height;
            f.Show();
        }

        public static string eraiseComma(string str)
        {
            string result = "";
            for(int i=str.Length-1; i>=0; i--)
            {
                if (str[i] != ',')
                {
                    result = str[i] + result;
                }
            }
            return result;
        }

        public static void tbx_TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            string txt = tbx.Text;
            if (txt != "")
            {
                int txt1 = int.Parse(Utils.eraiseComma(txt));
                tbx.Text = txt1.ToString("#,###");
                tbx.SelectionStart = tbx.Text.Length;
            }
        }

        public static DialogResult showConfirm(string content)
        {
            var msbxConfirm = MessageBox.Show(content, Constants.strConfirmTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return msbxConfirm;
        }

        public static void showError(string content)
        {
            MessageBox.Show(content, Constants.strErr, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void showErrorLoadData(string entity)
        {
            MessageBox.Show(String.Format(Constants.strErrLoadData, entity), Constants.strErr, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
