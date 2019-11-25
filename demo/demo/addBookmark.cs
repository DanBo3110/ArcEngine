using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class addBookmark : Form
    {
        public index m_frmMain;

        public addBookmark(index frm)
        {
            InitializeComponent();
            if( frm !=null )
            {
                m_frmMain = frm;
            }
        }

        private void addBookmark_Load(object sender, EventArgs e)
        {
            
        }

        private void but_ok_Click(object sender, EventArgs e)
        {

            string name = bm_text.Text.Trim();
            if (name == "")
                MessageBox.Show("请输入书签名");
            else if (!m_frmMain.oneBookmark(name))
            {
                MessageBox.Show("书签名重复");
                bm_text.Clear();
            }
            else
            {
                if (m_frmMain.CreatBookmark(name))
                {
                    MessageBox.Show("书签 "+ name + " 添加成功");
                    bm_text.Clear();
                    this.Close();
                }

            }
            
        }
    }
}
