using System;
using System.Windows.Forms;
using System.Xml;

namespace DSS_Project
{
    public class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
        public XmlNodeList GetRules()
        {

            XmlDocument KB = new XmlDocument();
            KB.Load(@"C:\Users\Basoma\OneDrive\Desktop\2nd Term-3rd Year\Decision Support System\MRES.xml");
            XmlNodeList Rules = KB.SelectNodes("/model [@name='movie recommendation']/block/rule");
            return Rules;
        }

    }
}
