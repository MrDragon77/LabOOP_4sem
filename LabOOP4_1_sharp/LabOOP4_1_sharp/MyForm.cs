
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabOOP4_1_sharp
{
    public partial class MyForm : System.Windows.Forms.Form
    {
        List<CCircle> circles = new List<CCircle>();
        bool isControl = false;
        bool isCrossSelectingEnabled = true;
        public MyForm()
        {
            InitializeComponent();
        }

        private void paintBox_MouseClick(object sender, MouseEventArgs e)
        {
            bool createNewCircle = true;
            bool firstMouseInside = true;
            foreach (CCircle i in circles)
            {
                if(i.MouseInside(e))
                {
                    createNewCircle = false;
                    if (isCrossSelectingEnabled)
                    {
                        i.Selected(true);
                    }
                    else
                    {
                        if (firstMouseInside)
                        {
                            i.Selected(true);
                            firstMouseInside = false;
                        }
                        else
                        {
                            if (!isControl)
                            {
                                i.Selected(false);
                            }
                        }
                    }
                }
                else
                {
                    if (!isControl)
                    {
                        i.Selected(false);
                    }
                }
            }
            if (createNewCircle)
            {
                CCircle newCircle = new CCircle(e.X, e.Y, 100.0F);
                circles.Add(newCircle);
            }
            paintBox.Invalidate();
        }

        private void paintBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (CCircle i in circles)
            {
                i.Draw(e);
            }
        }

        private void MyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && checkBox_Control.Checked)
            {
                isControl = true;
            }
            if (e.KeyCode == Keys.Delete)
            {
                circles.RemoveAll(circle => circle.Return_isSelected());
                if(circles.Count > 0)
                {
                    circles.Last().Selected(true);
                }
                paintBox.Invalidate();
            }
        }

        private void MyForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                isControl = false;
            }
        }

        private void checkBox_Control_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkBox_Control.Checked)
            {
                isControl = false;
            }
        }

        private void checkBox_CrossSelecting_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CrossSelecting.Checked)
            {
                isCrossSelectingEnabled = true;
            }
            else
            {
                isCrossSelectingEnabled = false;
            }
        }
    }
}