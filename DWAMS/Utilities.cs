using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace DWAMS
{
    public class Utilities
    {
        public static string CompanyFileReader()
        {
            string companyName = "";
            if (File.Exists("Register.ams"))
            {
                using (StreamReader streamReader = new StreamReader("Register.ams"))
                {
                    companyName = streamReader.ReadLine();
                }
            }
            return companyName;
        }

        public static string BurmeseNumber(char [] num)
        {
            String[] burmese_num = { "၀", "၁", "၂", "၃", "၄", "၅", "၆", "၇", "၈", "၉" };
            string transalate_string = "";
            int j;

            for (int i = 0; i < num.Length; i++)
            {
                j = Convert.ToInt32(char.ToString(num[i]));
                transalate_string += burmese_num[j];
            }
            return transalate_string;
        }

        #region MessageBox
        public enum MessageType
        {
            Information, Warning, Error, Question
        }
        public static DialogResult ShowMessage(MessageType messageType, string message)
        {
            DialogResult result = DialogResult.None;

            switch (messageType)
            {
                case MessageType.Information:
                    MessageBox.Show(message, ConfigurationManager.AppSettings["MessageBoxTitle"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case MessageType.Warning:
                    MessageBox.Show(message, ConfigurationManager.AppSettings["MessageBoxTitle"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case MessageType.Error:
                    MessageBox.Show(message, ConfigurationManager.AppSettings["MessageBoxTitle"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case MessageType.Question:
                    result = MessageBox.Show(message, ConfigurationManager.AppSettings["MessageBoxTitle"].ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    break;

            }
            return result;
        }
        #endregion

        public static string RemoveChar(string text, char character)
        {
            char[] txt = text.ToCharArray();
            text = string.Empty;

            for (int i = 0; i < txt.Length; i++)
            {
                if (!txt[i].Equals(character))
                {
                    text += txt[i];
                }
            }
            return text;
        }

        public static void Tab(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        public static void CenterMyControl(Control ctrl)
        {
            ctrl.Left = (ctrl.Parent.Width - ctrl.Width) / 2;
        }

        public static void ToolTipControl(string text, Control control)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show(text , control, 3000);
        }

    }
}
