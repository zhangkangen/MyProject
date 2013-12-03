using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05资料管理器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载时加上资料管理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Assembly.GetEntryAssembly().Location;
            string dirPath = Path.Combine(Path.GetDirectoryName(path), "demo");
            LoadDir(dirPath, tvRoot.Nodes);
        }

        private void LoadDir(string dirPath, TreeNodeCollection treeNodeCollection)
        {
            //获取当前目录下的所有文件夹
            string[] folderPath = Directory.GetDirectories(dirPath);
            foreach (string item in folderPath)
            {
                string folderName = Path.GetFileName(item);
                TreeNode tn = treeNodeCollection.Add(folderName);
                LoadDir(item, tn.Nodes);
            }
            string[] filePaths = Directory.GetFiles(dirPath);
            foreach (string item in filePaths)
            {
                string fileName = Path.GetFileName(item);
                TreeNode tn = treeNodeCollection.Add(fileName);
                //节点的tag存储文件的路径
                tn.Tag = item;
            }
        }
        /// <summary>
        /// 双击显示文本中的内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvRoot_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string filePath = tvRoot.SelectedNode.Tag.ToString();
            txtWord.Text = File.ReadAllText(filePath, Encoding.Default);
        }

    }
}
