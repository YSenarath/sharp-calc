using System;
using System.Windows.Forms;
using SharpCalc;

namespace SharpCalcInterface
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var input = textBox1.Text;
                string answer;
                try
                {
                    answer = Evaluator.Evaluate(input);
                }
                catch (Exception ex)
                {
                    answer = ex.Message;
                }
                textBox1.Text = "";
                listBox1.Items.Add(input + " = " + answer);
            }
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}