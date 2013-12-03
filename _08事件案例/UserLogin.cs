using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08事件案例
{
    public delegate void LoginDelegate(object sedder, MyEventArgs e);
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        //给当前的自定义控件定义一个事件
        public event LoginDelegate _ldl;

        private void button1_Click(object sender, EventArgs e)
        {
            MyEventArgs mea = new MyEventArgs();
            mea.UserName = textBox1.Text;
            mea.Pwd = textBox2.Text;
            if (_ldl != null)
            {
                _ldl(this, mea);
                if (mea.Flag==true)//如果登陆成功
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }
        }
    }
}
