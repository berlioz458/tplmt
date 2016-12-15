using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursovaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public class rule
        {
            public string VN;
            public string vnRule;
        };
        List<rule> rules = new List<rule>();
        List<rule> fixedRules = new List<rule>();
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            rules.Clear();
            fixedRules.Clear();
            string[] tmp;
            int line = 0;
            rule temp_struct = new rule();

            for (int i = 0; i < richTextBox2.Lines.Count();i++)
            {
                tmp = richTextBox2.Lines[i].Substring(3).Split('|');

                for (int j = 0; j < tmp.Count();j++)
                {
                    temp_struct = new rule();
                    temp_struct.VN = richTextBox2.Lines[i].First().ToString();
                    temp_struct.vnRule = tmp[j];
                    rules.Add(temp_struct);
                }
            }

            for (int i = 0; i < rules.Count;i++)
            {
                //if (richTextBox3.Text == "")
                //{
                    richTextBox3.Text += rules[i].VN + "->" + rules[i].vnRule  + "\n";
               // }

                //richTextBox3.Text +=  + rules[i].VN + "->" + rules[i].vnRule;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string W = "";
            for (int i = 0; i < rules.Count; i++)
            {
                if (rules[i].vnRule.ToString() == "@")
                {
                    W += rules[i].VN.ToString();
                }
            }

            //W.ToCharArray();
            
            for (int i = 0; i < rules.Count; i++)
            {
                for (int j = 0; j < W.Count();j++)
                {
                    if (rules[i].vnRule.ToString().Contains(W[j]))
                    {
                        if (rules[i].VN.ToString() == "S")
                            break;
                        //if (rules[i].VN.ToString().Contains(W[j]))
                        if (W.Contains(rules[i].VN.ToString()))
                            break;
                        else
                            W += rules[i].VN.ToString();

                    }
                    break;
                }
            

            }
           
            richTextBox4.Text = W;

            for(int i = 0; i < rules.Count; i++)
            {

            }
        }
    }
}
