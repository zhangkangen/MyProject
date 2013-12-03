using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08事件案例
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userLogin1._ldl += userLogin1__ldl;
        }

        /// <summary>
        /// 追加的事件
        /// </summary>
        /// <param name="sedder"></param>
        /// <param name="e"></param>
        void userLogin1__ldl(object sedder, MyEventArgs e)
        {
            if (e.UserName=="admin"&&e.Pwd=="88888")
            {
                e.Flag = true;
            }
            else
            {
                e.Flag = false;
            }
        }
    }
}
