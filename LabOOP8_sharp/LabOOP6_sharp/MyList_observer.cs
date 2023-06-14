using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP8_sharp
{
    public class MyList_observer<T> : MyList<T> where T : CShape, ISaveable<T>
    {
        List<TreeViewHandler> handlers;
        public MyList_observer() : base()
        {
            handlers = new List<TreeViewHandler>();
        }
        public void AddObserver(TreeViewHandler handler)
        {
            handlers.Add(handler);
        }

        public void RemoveObserver(TreeViewHandler handler)
        {
            handlers.Remove(handler);
        }

        public void Notify()
        {
            foreach (TreeViewHandler handler in handlers)
                handler.onObservableChange(this as MyList_observer<CShape>);
        }

        public void onTreeViewChange(TreeViewHandler tree)
        {
            to_begin();
            int i = 0;

            do
            {
                if (tree.tree.Nodes[i].Checked || isAnyChildChecked(tree.tree.Nodes[i]))
                {
                    curNode.data.Selected(true);
                }
                else
                    curNode.data.Selected(false);
                i++;
            } while (next());
            Notify();
        }

        private bool isAnyChildChecked(TreeNode node)
        {
            if (node.Checked)
                return true;

            foreach (TreeNode child in node.Nodes)
                if (isAnyChildChecked(child))
                    return true;

            return false;
        }

        public override void push_back(T data)
        {
            base.push_back(data);
            Notify();
        }

        public override void push_front(T data)
        {
            base.push_front(data);
            Notify();
        }

        public override void insert(T value)
        {
            base.insert(value);
            Notify();
        }

        public override void Delete(T elem)
        {
            base.Delete(elem);
            Notify();
        }
        public override void DeleteCurrent()
        {
            base.DeleteCurrent();
            Notify();
        }
        public override void DeleteAtPos(int pos)
        {
            base.DeleteAtPos(pos);
            Notify();
        }
    }
}
