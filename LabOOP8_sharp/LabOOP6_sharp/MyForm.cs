
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LabOOP8_sharp
{
    public partial class MyForm : System.Windows.Forms.Form
    {
        MyList_observer<CShape> shapes = new MyList_observer<CShape>();
        private bool isControl = false;
        private bool isArrow = false;
        InterfaceLogic ILogic;
        TreeViewHandler treeViewHandler;
        public MyForm()
        {
            InitializeComponent();
            ILogic = new InterfaceLogic();
            figureRadioButton_circle.Checked = true;
            figureRadioButton_circle.Enabled = true;
            colorDialog = new ColorDialog();
            colorDialog.Color = Color.Red;
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = true;
            colorButton.BackColor = Color.Red;
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            treeViewHandler = new TreeViewHandler(treeView);
            shapes.AddObserver(treeViewHandler);
            treeViewHandler.AddObserver(shapes);
        }

        private void paintBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(isArrow)
            {
                return;
            }
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
                        newShape = new CCircle(e.X, e.Y, 100.0F, colorButton.BackColor);
                        break;
                    case 1:
                        newShape = new CSquare(e.X, e.Y, 100.0F, colorButton.BackColor);
                        break;
                    case 2:
                        newShape = new CTriangle(e.X, e.Y, 100.0F, colorButton.BackColor);
                        break;
                }
                if(newShape != null)
                {
                    shapes.push_back(newShape);
                }
            }
            paintBox.Invalidate();
            shapes.Notify();
        }

        private void paintBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (CShape i in shapes)
            {
                i.Draw(e);
            }
            foreach (CShape i in shapes)
            {
                i.DrawArrows(e);
            }
            paintBox.Invalidate();
        }

        private void MyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                isControl = true;
            }
            else
            {
                isControl = false;
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (shapes.size() > 0)
                {
                    shapes.to_begin();
                    do
                    {
                        bool needNext = true;
                        if (shapes.getData().Return_isSelected())
                        {
                            foreach(CShape i in shapes)
                            {
                                i.observable.observers.Remove(shapes.getData());
                            }
                            shapes.DeleteCurrent();
                            needNext = false;
                        }
                        if (needNext || shapes.size() == 0)   
                        {
                            if (!shapes.next())
                            {
                                break;
                            }
                        }
                    } while (true);
                }
            if (shapes.size() > 0)
                {
                    shapes.Last().Selected(true);
                }
            }
            if(e.KeyCode == Keys.W)
            {
                foreach(CShape it in shapes)
                {
                    if(it.Return_isSelected())
                    {
                        it.Move(0.0f, -5.0f, paintBox.Size.Width, paintBox.Size.Height);
                    }
                }
            }
            if (e.KeyCode == Keys.A)
            {
                foreach (CShape it in shapes)
                {
                    if (it.Return_isSelected())
                    {
                        it.Move(-5.0f, 0.0f, paintBox.Size.Width, paintBox.Size.Height);
                    }
                }
            }
            if (e.KeyCode == Keys.S)
            {
                foreach (CShape it in shapes)
                {
                    if (it.Return_isSelected())
                    {
                        it.Move(0.0f, 5.0f, paintBox.Size.Width, paintBox.Size.Height);
                    }
                }
            }
            if (e.KeyCode == Keys.D)
            {
                foreach (CShape it in shapes)
                {
                    if (it.Return_isSelected())
                    {
                        it.Move(5.0f, 0.0f, paintBox.Size.Width, paintBox.Size.Height);
                    }
                }
            }

            if (e.KeyCode == Keys.Oemplus)
            {
                foreach (CShape it in shapes)
                {
                    if (it.Return_isSelected())
                    {
                        it.ChangeSize(5.0f, paintBox.Size.Width, paintBox.Size.Height);
                    }
                }
            }
            if (e.KeyCode == Keys.OemMinus)
            {
                foreach (CShape it in shapes)
                {
                    if (it.Return_isSelected())
                    {
                        it.ChangeSize(-5.0f, paintBox.Size.Width, paintBox.Size.Height);
                    }
                }
            }
            paintBox.Invalidate();
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
                    if (it.Return_isSelected())
                    {
                        it.ChangeColor(colorDialog.Color);
                    }
                }
                paintBox.Invalidate();
                colorButton.BackColor = colorDialog.Color;
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

        private void toGroupButton_Click(object sender, EventArgs e)
        {
            CGroup group = new CGroup();
            foreach(CShape i in shapes)
            {
                if(i.Return_isSelected())
                {
                    group.AddElem(i);
                    shapes.Delete(i);
                }
            }
            shapes.push_back(group);
        }

        private void toUngroupButton_Click(object sender, EventArgs e)
        {
            foreach (CShape i in shapes)
            {
                if (i.Return_isSelected())
                {
                    if(i is CGroup)
                    {
                        while(((CGroup)i).elems.size()>0)
                        {
                            shapes.push_back(((CGroup)i).PopElem());
                        }
                        shapes.Delete(i);
                    }
                }
            }
        }

        //private void treeView_main()
        //{
        //    treeView.Nodes.Clear();
        //    foreach(CShape i in shapes)
        //    {
        //        if (i is CGroup)
        //        {
        //            TreeNode groupNode = new TreeNode(Text = "Group");
        //            treeView.Nodes.Add(groupNode);
        //            treeView_child(((CGroup)i).elems, groupNode);
        //        }
        //        else
        //        {
        //            TreeNode separateNode = null;
        //            if(i is CCircle)
        //            {
        //                separateNode = new TreeNode(Text = "Circle");
        //            }
        //            if(i is CSquare)
        //            {
        //                separateNode = new TreeNode(Text = "Square");
        //            }
        //            if (i is CTriangle)
        //            {
        //                separateNode = new TreeNode(Text = "Triangle");
        //            }
        //            if (separateNode != null)
        //            {
        //                treeView.Nodes.Add(separateNode);
        //            }
        //        }
        //    }
        //}

        //private void treeView_child(MyList<CShape> list, TreeNode curNode)
        //{
        //    foreach (CShape i in list)
        //    {
        //        if (i is CGroup)
        //        {
        //            TreeNode groupNode = new TreeNode(Text = "Group");
        //            curNode.Nodes.Add(groupNode);
        //            treeView_child(((CGroup)i).elems, groupNode);
        //        }
        //        else
        //        {
        //            TreeNode separateNode = null;
        //            if (i is CCircle)
        //            {
        //                separateNode = new TreeNode(Text = "Circle");
        //            }
        //            if (i is CSquare)
        //            {
        //                separateNode = new TreeNode(Text = "Square");
        //            }
        //            if (i is CTriangle)
        //            {
        //                separateNode = new TreeNode(Text = "Triangle");
        //            }
        //            if (separateNode != null)
        //            {
        //                curNode.Nodes.Add(separateNode);
        //            }
        //        }
        //    }
        //}

        //private void ctrl_main()
        //{
        //    if(isControl)
        //    {
        //        ctrl.Checked = true;
        //    }
        //    else
        //    {
        //        ctrl.Checked = false;
        //    }
        //}

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = saveFileDialog.FileName;
            shapes.SaveElements(filename);
            paintBox.Invalidate();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = openFileDialog.FileName;
            CFactory<CShape> factory = new CShapeFactory();
            
            bool loadedSuccessfully = shapes.LoadElements(filename, factory);
            if(!loadedSuccessfully)
            {
                MessageBox.Show("Файл содержит ошибки. Выберите другой.");
            }
            paintBox.Invalidate();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            e.Node.TreeView.SelectedNode = null;
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!isControl)
            {
                treeViewHandler.Reset();
            }
            e.Node.Checked = !e.Node.Checked;

            treeViewHandler.Notify();
            paintBox.Invalidate();
        }

        private void arrowButton_Click(object sender, EventArgs e)
        {
            if(isArrow)
            {
                isArrow = false;
            }
            else
            {
                isArrow = true;
            }

            if (isArrow == true)
            {
                arrowButton.BackColor = SystemColors.MenuHighlight;
            }
            else
            {
                arrowButton.BackColor = SystemColors.Control;
            }
        }

        CShape arrowShape = null;
        private void paintBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(isArrow)
            {
                foreach(CShape i in shapes)
                {
                    if (i.MouseInside(e))
                    {
                        arrowShape = i;
                        i.Selected(true);
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
        }

        private void paintBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isArrow)
            {
                foreach (CShape i in shapes)
                {
                    if (i.MouseInside(e))
                    {
                        if (arrowShape != i && arrowShape != null)
                        {
                            arrowShape.observable.AddObserver(i);
                        }
                    }
                }
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