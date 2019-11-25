using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
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
    public partial class render : Form
    {
        private static string plp_type;
        private C_S_R csr;
        private int r;
        private int g;
        private int b;
        private int rl;
        private int gl;
        private int bl;
        private int width;

        private void init()
        {
            r = g = b = 233;
            rl = gl = bl = 34;
            textBox_r.Text = textBox_g.Text = textBox_b.Text = "233";
            textBox_lr.Text = textBox_lg.Text = textBox_lb.Text = "34";
            textBox_width.Text = "1";

        }

        public render(List<string> map_layer, C_S_R csr)
        {
            InitializeComponent();
            init();
            foreach (string s in map_layer)
            {
                int i = map_layer.IndexOf(s);//i就是下标
                listBox_layer.Items.Add(s);
            }
            this.csr = csr;
        }
        private void radioButton_choose()
        {
            plp_type = "null";
            if (radioButton_point.Checked)
                plp_type = "point";
            else if (radioButton_line.Checked)
                plp_type = "line";
            else if (radioButton_plon.Checked)
                plp_type = "fill";
        }

        private IRgbColor rgb_choose(int R, int G, int B)
        {
            return C_S_R.getRGB(R, G, B);
        }
        private int width_choose()
        {
            return width;
        }
        private void render_choose()
        {
            string index = comboBox_render.SelectedIndex.ToString();
            Console.WriteLine(index);
            if (index == "0")
            {
                MessageBox.Show(index);
                //简单渲染
            }
            if (index == "1")
            {
                MessageBox.Show(index);
                //唯一值渲染
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            r = int.Parse(textBox_r.Text);
            g = int.Parse(textBox_g.Text);
            b = int.Parse(textBox_b.Text);

            rl = int.Parse(textBox_lr.Text);
            gl = int.Parse(textBox_lg.Text);
            bl = int.Parse(textBox_lb.Text);

            width = int.Parse(textBox_width.Text);
            if (listBox_layer.SelectedItem == null)
            {
                MessageBox.Show("请选择要渲染的Layer");
                return;
            }
            //创建实例！！！！

            radioButton_choose();
            switch (plp_type)
            {
                //点
                case "point":
                    {
                        C_S_R.easy_point(listBox_layer.SelectedItem.ToString(), rgb_choose(r,g,b), width_choose());
                        break;
                    }
                case "line":
                    {
                        C_S_R.easy_line(listBox_layer.SelectedItem.ToString(), rgb_choose(r, g, b), width_choose());
                        break;
                    }
                case "fill":
                    {

                        C_S_R.easy_xrender(listBox_layer.SelectedItem.ToString(), rgb_choose(r, g, b), rgb_choose(rl, gl, bl), width_choose());
                        break;
                    }
                default: MessageBox.Show("类型不能为空");
                    break;
            }
            MessageBox.Show("结束");
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_plon_CheckedChanged(object sender, EventArgs e)
        {
            panel_line.Visible = true;
        }

        private void radioButton_line_CheckedChanged(object sender, EventArgs e)
        {
            panel_line.Visible = false;

        }
        private void radioButton_point_CheckedChanged(object sender, EventArgs e)
        {
            panel_line.Visible = false;

        }

        private void render_Load(object sender, EventArgs e)
        {

        }
    }
}
