    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP8_sharp
{
    public class TreeViewHandler
    {
        internal TreeView tree;
        internal List<MyList_observer<CShape>> observers;

        public TreeViewHandler(TreeView tree)
        {
            this.tree = tree;
            observers = new List<MyList_observer<CShape>>();
        }

        public void AddObserver(MyList_observer<CShape> observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(MyList_observer<CShape> observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (MyList_observer<CShape> handler in observers)
                handler.onTreeViewChange(this);
        }

        public void onObservableChange(MyList_observer<CShape> container)
        {
            tree.Nodes.Clear();

            foreach (CShape it in container)
            {
                TreeNode newNode = CreateNewNode(it);
                tree.Nodes.Add(newNode);
            }

            tree.ExpandAll();
        }

        private void ProcessNode(TreeNode tr, CShape figure)
        {
            if (figure as CGroup == null)
                return;

            MyList<CShape> tmp = (figure as CGroup).elems;
            foreach (CShape it in tmp)
            {
                TreeNode newNode = CreateNewNode(it);
                tr.Nodes.Add(newNode);
            }
        }

        public TreeNode CreateNewNode(CShape shape)
        {
            TreeNode newNode = new TreeNode();
            switch (shape.GetType().Name)
            {
                case "CCircle":
                    newNode.Text = "Круг";
                    newNode.ImageIndex = 0;
                    newNode.SelectedImageIndex = 0; break;
                case "CSquare":
                    newNode.Text = "Квадрат";
                    newNode.ImageIndex = 1;
                    newNode.SelectedImageIndex = 1; break;
                case "CTriangle":
                    newNode.Text = "Треугольник";
                    newNode.ImageIndex = 2;
                    newNode.SelectedImageIndex = 2; break;
                case "CGroup":
                    newNode.Text = "Группа";
                    newNode.ImageIndex = 3;
                    newNode.SelectedImageIndex = 3; break;
                default: break;
            }
            ProcessNode(newNode, shape);

            if (shape.isSelected)
            {
                newNode.Checked = true;
                newNode.BackColor = Color.SkyBlue;
            }
            return newNode;
        }

        public void Reset()
        {
            foreach (TreeNode node in tree.Nodes)
                ResetNodes(node);
        }

        private void ResetNodes(TreeNode node)
        {
            foreach (TreeNode child in node.Nodes)
                ResetNodes(child);

            node.Checked = false;
        }
    }
}
