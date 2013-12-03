using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06敏感词案例
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //接收要审核的字符
        StringBuilder sbMod = new StringBuilder();
        //接收禁止的敏感词
        StringBuilder sbBanned = new StringBuilder();

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("网站过滤词.txt",Encoding.Default);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                if (words[1] == "{MOD}")
                {
                    sbMod.Append(words[0] + "|");
                }
                else if (words[1] == "{BANNED}")
                {
                    sbBanned.Append(words[0] + "|");
                }
            }
            //去除最后一个“|”
            sbMod.Remove(sbMod.Length - 1, 1);
            sbBanned.Remove(sbBanned.Length - 1, 1);
        }
        /// <summary>
        /// 判断用户输入的内容是否可以发表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            if (Regex.IsMatch(str,sbMod.ToString()))
            {
                MessageBox.Show("正在审核。。。");
            }
            else if (Regex.IsMatch(str,sbBanned.ToString()))
            {
                MessageBox.Show("禁止发帖");
            }else
            {
                textBox2.Text = str;
            }
        }
    }
}
