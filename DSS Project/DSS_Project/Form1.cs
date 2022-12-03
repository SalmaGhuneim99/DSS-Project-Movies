using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace DSS_Project
{
    public partial class Form1 : Form
    {
        Program p = new Program();
        XmlNodeList Rules;
        public Form1()
        {
            InitializeComponent();
        }

        public int index;
        //public int ruleindex;

        private void Form1_Load(object sender, EventArgs e)
        {
            index = 0;

            Rules = p.GetRules();

            label1.Text = Rules[0].ChildNodes[0].ChildNodes[index].Name;
        }


        Dictionary<string, string> userQA = new Dictionary<string, string>();
        public Boolean stop = true;
        public Boolean found = true;

        private void button1_Click_1(object sender, EventArgs e)
        {
            string inputanswer = textBox1.Text.Replace(" ", "").ToLower();
            userQA.Add(label1.Text, inputanswer);

            //For loop to delete
            /*for (int i = 0; i < Rules.Count; i++)
            {
                for (int j = 0; j < Rules[i].ChildNodes[0].ChildNodes.Count; j++)
                {
                    if (label1.Text == Rules[i].ChildNodes[0].ChildNodes[j].Name
                        && inputanswer != Rules[i].ChildNodes[0].ChildNodes[j].ChildNodes[0].InnerText.Replace(" ", "").ToLower())
                    {
                        Rules[i].ParentNode.RemoveChild(Rules[i]);
                    }
                }
            }
            */

            for (int i = 0; i < Rules.Count; i++)
            {

                for (int j = 0; j < Rules[i].ChildNodes[0].ChildNodes.Count; j++)
                {
                    if (label1.Text == Rules[i].ChildNodes[0].ChildNodes[j].Name
                        && inputanswer == Rules[i].ChildNodes[0].ChildNodes[j].ChildNodes[0].InnerText.Replace(" ", "").ToLower()
                         )
                    {

                        if (index == ((Rules[i].ChildNodes[0].ChildNodes.Count) - 1))
                        {
                            MessageBox.Show("Conclusion :" + Rules[i].ChildNodes[1].ChildNodes[0].InnerText);
                            stop = false;
                            Close();
                            break;

                        }
                        index++;
                        textBox1.Text = null;
                        inputanswer = null;
                        label1.Text = Rules[i].ChildNodes[0].ChildNodes[index].Name;
                    }
                }

            }

        }
    }
}

        
    

    

