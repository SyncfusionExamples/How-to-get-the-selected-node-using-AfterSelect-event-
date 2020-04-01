using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewAdv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeViewAdv1_AfterSelect(object sender, EventArgs e)
        {
            foreach (TreeNodeAdv node in this.treeViewAdv1.Nodes)
            {
                if (node.IsSelected)
                {
                    Console.WriteLine(node.Text + "is selected");
                }
                CheckForChildren(node);
            }
        }
        private void CheckForChildren(TreeNodeAdv node)
        {

            // check whether each parent node has child nodes 
            if (node.HasChildren && node.Nodes.Count > 0)
            {

                // iterate through child nodes in the collection
                foreach (TreeNodeAdv childNode in node.Nodes)
                {
                    if (childNode.IsSelected)
                    {
                        MessageBox.Show(childNode.Text + " is selected");
                    }

                    // Do recursive call
                    CheckForChildren(childNode);
                }
            }
        }

    }
}
