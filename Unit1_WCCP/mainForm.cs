using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1_WCCP
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(Object sender, EventArgs e)
        {
            String width = this.Size.Width.ToString();
            String height = this.Size.Height.ToString();
            label2.Text = "" + width + ", " + height;
            label2.Update();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            String width = this.Size.Width.ToString();
            String height = this.Size.Height.ToString();
            label2.Text = "" + width + ", " + height;
            label2.Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;
            targetButton.Location = new Point(x, y + 5);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;
            targetButton.Location = new Point(x, y - 5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;
            targetButton.Location = new Point(x - 5, y);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;
            targetButton.Location = new Point(x + 5, y);
        }
    }
}
