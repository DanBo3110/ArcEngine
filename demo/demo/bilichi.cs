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
    public partial class bilichi : Form
    {
        private string bilinum;
        public bilichi(string bilinum)
        {
            InitializeComponent();
            this.bilinum = bilinum;
            init();
        }
        public void init() {
            bilitext.Text = this.bilinum;
        }

        private void bilichi_Load(object sender, EventArgs e)
        {

        }
    }
}
