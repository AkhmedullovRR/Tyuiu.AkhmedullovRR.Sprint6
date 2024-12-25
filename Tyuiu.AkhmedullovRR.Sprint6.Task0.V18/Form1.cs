using Tyuiu.AkhmedullovRR.Sptint6.Task0.V18.Lib;

namespace Tyuiu.AkhmedullovRR.Sprint6.Task0.V18
{
        public partial class FormMain : Form
        {
            public FormMain()
            {
                InitializeComponent();
            }

            private void buttonDone_Click(object sender, EventArgs e)
            {
                DataService ds = new DataService();
                try
                {
                    textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVariable.Text)));
                }
                catch
                {
                    MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void textBoxVariable_KeyPress(object sender, KeyPressEventArgs e)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
                {
                    e.Handled = true;
                }
            }

            private void buttonQuestion_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Òàñê 0 âûïîëíèë ñòóäåíò ãðóïïû ÏÊÒÁ-24-1 Ðóáàíîâ Åãîð Îëåãîâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void textBoxVariable_TextChanged(object sender, EventArgs e)
            {

            }
        }
    
}
