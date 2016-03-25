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
                var answer = Evaluator.Evaluate(input);
                textBox1.Text = answer;
            }
        }
    }
}