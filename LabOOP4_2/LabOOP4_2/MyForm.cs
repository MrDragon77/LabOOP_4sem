using System.Windows.Forms;

namespace LabOOP4_2
{
    public partial class MyForm : System.Windows.Forms.Form
    {
        private MyBusinessInt logic;

        public MyForm()
        {
            InitializeComponent();
            logic = new MyBusinessInt();
            logic.observers += new System.EventHandler(this.Update);
            logic.refresh();
        }

        private void Update(object sender, EventArgs e)
        {
            textBox_A.Text = logic.getA().ToString();
            numericUpDown_A.Value = Convert.ToDecimal(logic.getA());
            trackBar_A.Value = logic.getA();

            textBox_B.Text = logic.getB().ToString();
            numericUpDown_B.Value = Convert.ToDecimal(logic.getB());
            trackBar_B.Value = logic.getB();

            textBox_C.Text = logic.getC().ToString();
            numericUpDown_C.Value = Convert.ToDecimal(logic.getC());
            trackBar_C.Value = logic.getC();
        }

        private void textBox_A_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int parseResult;
                if(Int32.TryParse(textBox_A.Text, out parseResult))
                {
                    logic.setA(parseResult);
                }
                else
                {
                    logic.refresh();
                }
                
            }
        }

        private void numericUpDown_A_ValueChanged(object sender, EventArgs e)
        {
            logic.setA(Decimal.ToInt32(numericUpDown_A.Value));
        }

        private void trackBar_A_Scroll(object sender, EventArgs e)
        {
            logic.setA(trackBar_A.Value);
        }

        private void textBox_B_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int parseResult;
                if (Int32.TryParse(textBox_B.Text, out parseResult))
                {
                    logic.setB(parseResult);
                }
                else
                {
                    logic.refresh();
                }
            }
        }

        private void numericUpDown_B_ValueChanged(object sender, EventArgs e)
        {
            logic.setB(Decimal.ToInt32(numericUpDown_B.Value));
        }

        private void trackBar_B_Scroll(object sender, EventArgs e)
        {
            logic.setB(trackBar_B.Value);
        }

        private void textBox_C_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int parseResult;
                if (Int32.TryParse(textBox_C.Text, out parseResult))
                {
                    logic.setC(parseResult);
                }
                else
                {
                    logic.refresh();
                }
            }
        }

        private void numericUpDown_C_ValueChanged(object sender, EventArgs e)
        {
            logic.setC(Decimal.ToInt32(numericUpDown_C.Value));
        }

        private void trackBar_C_Scroll(object sender, EventArgs e)
        {
            logic.setC(trackBar_C.Value);
        }

        private void textBox_A_Leave(object sender, EventArgs e)
        {
            int parseResult;
            if (Int32.TryParse(textBox_A.Text, out parseResult))
            {
                logic.setA(parseResult);
            }
            else
            {
                logic.refresh();
            }
        }

        private void textBox_B_Leave(object sender, EventArgs e)
        {
            int parseResult;
            if (Int32.TryParse(textBox_B.Text, out parseResult))
            {
                logic.setB(parseResult);
            }
            else
            {
                logic.refresh();
            }
        }

        private void textBox_C_Leave(object sender, EventArgs e)
        {
            int parseResult;
            if (Int32.TryParse(textBox_C.Text, out parseResult))
            {
                logic.setC(parseResult);
            }
            else
            {
                logic.refresh();
            }
        }

        private void numericUpDown_A_Leave(object sender, EventArgs e)
        {
            logic.refresh();
        }
        private void numericUpDown_B_Leave(object sender, EventArgs e)
        {
            logic.refresh();
        }

        private void numericUpDown_C_Leave(object sender, EventArgs e)
        {
            logic.refresh();
        }
        private void numericUpDown_A_TextChanged(object sender, EventArgs e)
        {
            logic.refresh();
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logic.save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numericUpDown_B.Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown_B.Value = 33;
        }
    }

    public class MyBusinessInt
    {
        private int A;
        private int B;
        private int C;
        public System.EventHandler observers;

        public MyBusinessInt()
        {
            A = Properties.Settings.Default.A;
            B = Properties.Settings.Default.B;
            C = Properties.Settings.Default.C;
        }
        //~MyBusinessInt()
        //{
        //    refresh();
        //}
        public void setA(int newValue)
        {
            if(newValue < 0)
            {
                A = 0;
            }
            else if(newValue > 100)
            {
                A = 100;
                B = 100;
                C = 100;
            }
            else if(newValue > B)
            {
                A = newValue;
                B = newValue;
                if(newValue > C)
                {
                    C = newValue;
                }
            }
            else
            {
                A = newValue;
            }
            observers.Invoke(this, EventArgs.Empty);
        }
        public void setB(int newValue)
        {
            if(newValue >= A && newValue <= C)
            {
                B = newValue;
            }
            observers.Invoke(this, EventArgs.Empty);
        }
        public void setC(int newValue)
        {
            if (newValue > 100)
            {
                C = 100;
            }
            else if (newValue < 0)
            {
                C = 0;
                B = 0;
                A = 0;
            }
            else if (newValue < B)
            {
                C = newValue;
                B = newValue;
                if (newValue < A)
                {
                    A = newValue;
                }
            }
            else
            {
                C = newValue;
            }
            observers.Invoke(this, EventArgs.Empty);
        }
        public void save()
        {
            Properties.Settings.Default.A = A;
            Properties.Settings.Default.B = B;
            Properties.Settings.Default.C = C;
            Properties.Settings.Default.Save();
        }
        public void refresh()
        {
            observers.Invoke(this, EventArgs.Empty);
        }
        public int getA()
        {
            return A;
        }
        public int getB()
        {
            return B;
        }
        public int getC()
        {
            return C;
        }
    }
}