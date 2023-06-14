
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabOOP6_sharp
{
    public partial class MyForm : System.Windows.Forms.Form
    {
        List<CShape> shapes = new List<CShape>();
        bool isControl = false;
        InterfaceLogic ILogic;
        //bool isCrossSelectingEnabled = true;
        //bool circle = false;
        //bool square = false;//здесь должна быть опция единого выбора, то есть одна фигура может быть выбрана за раз (как в 4_2 можно сделать, через mvc)
        public MyForm()
        {
            InitializeComponent();
            ILogic = new InterfaceLogic();
        }

        private void paintBox_MouseClick(object sender, MouseEventArgs e)
        {
            bool createNewShape = true;
            bool firstMouseInside = true;
            foreach (CShape i in shapes)
            {
                if(i.MouseInside(e))
                {
                    createNewShape = false;
                    if (ILogic.IsCrossSelectingEnabled())
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
            if (createNewShape)
            {
                CShape newShape = null; 
                switch(ILogic.FigureChoice())
                {
                    case 0:
                        newShape = new CCircle(e.X, e.Y, 100.0F);
                        break;
                    case 1:
                        newShape = new CSquare(e.X, e.Y, 100.0F);
                        break;
                    case 2:
                        newShape = new CTriangle(e.X, e.Y, 100.0F);
                        break;

                }
                if(newShape != null)
                {
                    shapes.Add(newShape);
                }
            }
            paintBox.Invalidate();
        }

        private void paintBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (CShape i in shapes)
            {
                i.Draw(e);
            }
        }

        private void MyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                isControl = true;
            }
            if (e.KeyCode == Keys.Delete)
            {
                shapes.RemoveAll(circle => circle.Return_isSelected());
                if(shapes.Count > 0)
                {
                    shapes.Last().Selected(true);
                }
                paintBox.Invalidate();
            }
            if(e.KeyCode == Keys.W)
            {
                foreach(CShape it in shapes)
                {
                    it.Move(0.0f, -5.0f, paintBox.Size.Width, paintBox.Size.Height);
                }
                paintBox.Invalidate();
            }
            if (e.KeyCode == Keys.A)
            {
                foreach (CShape it in shapes)
                {
                    it.Move(-5.0f, 0.0f, paintBox.Size.Width, paintBox.Size.Height);
                }
                paintBox.Invalidate();
            }
            if (e.KeyCode == Keys.S)
            {
                foreach (CShape it in shapes)
                {
                    it.Move(0.0f, 5.0f, paintBox.Size.Width, paintBox.Size.Height);
                }
                paintBox.Invalidate();
            }
            if (e.KeyCode == Keys.D)
            {
                foreach (CShape it in shapes)
                {
                    it.Move(5.0f, 0.0f, paintBox.Size.Width, paintBox.Size.Height);
                }
                paintBox.Invalidate();
            }

            if (e.KeyCode == Keys.Oemplus)
            {
                foreach (CShape it in shapes)
                {
                    it.ChangeSize(true, paintBox.Size.Width, paintBox.Size.Height);
                }
                paintBox.Invalidate();
            }
            if (e.KeyCode == Keys.OemMinus)
            {
                foreach (CShape it in shapes)
                {
                    it.ChangeSize(false, paintBox.Size.Width, paintBox.Size.Height);
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

        private void checkBox_CrossSelecting_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CrossSelecting.Checked)
            {
                ILogic.Set_IsCrossSelectingEnabled(true);
            }
            else
            {
                ILogic.Set_IsCrossSelectingEnabled(false);
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (CShape it in shapes)
                {
                    it.ChangeColor(colorDialog.Color);
                }
                paintBox.Invalidate();
            }
        }

        private void figureButton_circle_Click(object sender, EventArgs e)
        {
            ILogic.Set_FigureChoice(0);
        }

        private void figureButton_square_Click(object sender, EventArgs e)
        {
            ILogic.Set_FigureChoice(1);
        }

        private void figureButton_triangle_Click(object sender, EventArgs e)
        {
            ILogic.Set_FigureChoice(2);
        }

        private void figureRadioButton_circle_CheckedChanged(object sender, EventArgs e)
        {
            if(figureRadioButton_circle.Checked)
            {
                ILogic.Set_FigureChoice(0);
            }
         }

        private void figureRadioButton_square_CheckedChanged(object sender, EventArgs e)
        {
            if (figureRadioButton_square.Checked)
            {
                ILogic.Set_FigureChoice(1);
            }
        }

        private void figureRadioButton_triangle_CheckedChanged(object sender, EventArgs e)
        {
            if (figureRadioButton_triangle.Checked)
            {
                ILogic.Set_FigureChoice(2);
            }
        }
    }

    public class InterfaceLogic
    {
        private bool isCrossSelectingEnabled;
        private int figureChoice;

        public InterfaceLogic()
        {
            isCrossSelectingEnabled = true;
            figureChoice = 0;
        }
        public int FigureChoice()
        {
            //0 - Circle
            //1 - Square
            //2 - Triangle
            return figureChoice;
        }
        public bool IsCrossSelectingEnabled()
        {
            return isCrossSelectingEnabled;
        }
        public void Set_IsCrossSelectingEnabled(bool option)
        {
            isCrossSelectingEnabled = option;
        }
        public void Set_FigureChoice(int choice)
        {
            if (figureChoice >= 0 && figureChoice <= 2)
            {
                figureChoice = choice;
            }
            else
            {
                figureChoice = 0;
            }
        }
    }
}