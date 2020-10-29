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
            locationTextTitle();
            resizeFormLoad();
            listItemCreate();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
        }
      
        private void label2_Click(object sender, EventArgs e)
        {
            String width = this.Size.Width.ToString();
            String height = this.Size.Height.ToString();
            label2.Text = "" + width + ", " + height;
            label2.Update();
        }

        private void targetUp_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;
            targetButton.Location = new Point(x, y - 5);

        }

        private void targetDown_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;
            targetButton.Location = new Point(x, y + 5);
        }

        private void targetLeft_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;
            targetButton.Location = new Point(x - 5, y);
        }

        private void targetRight_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;
            targetButton.Location = new Point(x + 5, y);
        }

        private void locationTextTitle()
        {
            String x = this.Location.X.ToString();
            String y = this.Location.Y.ToString();
            this.Text = "(" + x + ", " + y + ") Winforms Components - Common Controls";
        }

        private void mainForm_Move(object sender, EventArgs e)
        {
            locationTextTitle();
        }

        private void resizeFormLoad()
        {
            String width = this.Size.Width.ToString();
            String height = this.Size.Height.ToString();
            label2.Text = "Form size: " + width + ", " + height;
            label2.Update();
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            resizeFormLoad();
        }


        private void listItemCreate()
        {
            comboBox1.Items.Add("none");
            comboBox1.Items.Add("Fixed single");
            comboBox1.Items.Add("Fixed 3D");
            comboBox1.Items.Add("Fixed Dialog");
            comboBox1.Items.Add("Sizable");
            comboBox1.Items.Add("Fixed tool window");
            comboBox1.Items.Add("Sizable tool window");
        }

        private void mainForm_Load(Object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "none")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            } 
            else if (comboBox1.SelectedItem == "Fixed single")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            } 
            else if (comboBox1.SelectedItem == "Fixed 3D")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            }
            else if (comboBox1.SelectedItem == "Fixed Dialog")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            }
            else if (comboBox1.SelectedItem == "Sizable")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
            else if (comboBox1.SelectedItem == "Fixed tool window")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            }
            else if (comboBox1.SelectedItem == "Sizable tool window")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            }
        }
    }
}
