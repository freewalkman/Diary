using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary.Win
{
    static class Program
    {
        public static string Chr(int asciiCode)
        {
            if (asciiCode >= 0 && asciiCode <= 255)
            {
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                byte[] byteArray = new byte[] { (byte)asciiCode };
                string strCharacter = asciiEncoding.GetString(byteArray);
                return (strCharacter);
            }
            else
            {
                throw new Exception("ASCII Code is not valid.");
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string input = "dmesty&#38634;&#32442;&#34923;&#22799;&#23395;&#38271;&#34966;2021&#24180;&#26032;&#27454;&#34924;&#34923;&#22899;&#22797;&#21476;&#28207;&#21619;&#21360;&#33457;&#34924;&#34915;&#23567;&#20247;&#19978;&#34915;";
            string text = System.Web.HttpUtility.HtmlDecode(input);

            string a = "°¡°¡";
            System.Text.ASCIIEncoding AE1 = new System.Text.ASCIIEncoding(); 
            byte[] ByteArray1 = AE1.GetBytes(a); //´òÓ¡³öASCIIÂë
            for(int  x  =  0;x  <=  ByteArray1.Length  -  1;  x++)
            {
                string s = string.Format("{0}  ",  ByteArray1[x]);
            }
            

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
