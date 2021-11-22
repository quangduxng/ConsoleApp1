using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BasicWinForm
{
    public partial class frm2510 : Form
    {

        public frm2510()
        {
            //pictureBox1.Visible = false;
            InitializeComponent();
            var drives = Environment.GetLogicalDrives();
            foreach (var drive in drives)
            {
                TreeNode nodeDrive = new TreeNode(drive);
                treeView1.Nodes.Add(nodeDrive);
                addNode(nodeDrive, drive, 1);

            }
            //pictureBox1.Visible = false;
        } 
            void addNode(TreeNode parentNode, string parentDirectory, int level)
            {
                try
                {
                    if (level < 5)
                    {
                        var directoryInfo = new DirectoryInfo(parentDirectory);
                        var directories = directoryInfo.GetDirectories();
                        if (directories.Length > 0)
                            foreach (var directory in directories)
                            {
                                TreeNode node = new TreeNode(directory.Name);
                                parentNode.Nodes.Add(node);
                                addNode(node, directory.FullName, level + 1);
                            }
                    }
                }
                catch
                {

                }
            }
          

        private void btnTaocay_Click(object sender, EventArgs e)
        {
                //pictureBox1.Visible = true;

                BackgroundWorker worker = new BackgroundWorker();
                List<TreeNode> ls = new List<TreeNode>();
                worker.DoWork += (t, w) =>
                {
                    var drives = Environment.GetLogicalDrives();
                    foreach (var drive in drives)
                    {
                        TreeNode nodeDriver = new TreeNode(drive);
                        ls.Add(nodeDriver);

                        addNode(nodeDriver, drive, 1);
                    }
                };
                worker.RunWorkerCompleted += (t, w) =>
                {
                    treeView1.Nodes.AddRange(ls.ToArray());
                     //pictureBox1.Visible = false;
                      List<TreeNode> list = new List<TreeNode>();
                     treeView1.Nodes.AddRange(list.ToArray());



                  

                    
                };
                worker.RunWorkerAsync();
                   


          





        }

       
    }
    }










