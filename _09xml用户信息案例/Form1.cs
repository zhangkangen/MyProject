using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _09xml用户信息案例
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加用户数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("UserData.xml");
            XElement root = xdoc.Root;
            Person p = new Person();
            p.Id = txtId.Text;
            p.UserName = txtUserName.Text;
            p.Password = txtPassword.Text;
            #region 将数据添加到xml中
            XElement user = new XElement("user");
            user.SetAttributeValue("id", p.Id);
            user.SetElementValue("name", p.UserName);
            user.SetElementValue("password", p.Password);
            root.Add(user);
            #endregion
            xdoc.Save("UserData.xml");
            xmlLoad();//刷新一下

        }



        /// <summary>
        /// 加载窗体时在DataGridView中显示xml中的内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            xmlLoad();
        }

        /// <summary>
        /// 刷新数据的方法
        /// </summary>
        private void xmlLoad()
        {
            List<Person> list = new List<Person>();//声明一个集合存放Person
            XDocument xdoc = XDocument.Load("UserData.xml");
            XElement root = xdoc.Root;
            foreach (XElement item in root.Elements("user"))
            {
                Person p = new Person();
                p.Id = item.Attribute("id").Value;
                p.UserName = item.Element("name").Value;
                p.Password = item.Element("password").Value;
                list.Add(p);
            }
            dataGridView1.DataSource = list;
        }

        private void DeleteTSMItem_Click(object sender, EventArgs e)
        {
            //先判断用户是否选中了内容
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //获取当前选中项的id
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                XDocument xdoc = XDocument.Load("UserData.xml");
                XElement root = xdoc.Root;
                XElement user = root.Elements("user").Where(x => x.Attribute("id").Value.ToString() == id).Single();
                user.Remove();
                xdoc.Save("UserData.xml");
                xmlLoad();
            }
        }
    }
}
