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
         
        }
      
        private void targetUp_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;
            targetButton.Location = new Point(x, y - 5);
            Console.WriteLine("button up");

        }

        private void targetDown_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;
            targetButton.Location = new Point(x, y + 5);
            Console.WriteLine("button down");
        }

        private void targetLeft_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;
            targetButton.Location = new Point(x - 5, y);
            Console.WriteLine("button left");
        }

        private void targetRight_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;
            targetButton.Location = new Point(x + 5, y);
            Console.WriteLine("button right");
        }

        private void locationTextTitle()
        {
            String x = this.Location.X.ToString();
            String y = this.Location.Y.ToString();
            this.Text = "(" + x + ", " + y + ") Winforms Components - Common Controls";
            Console.WriteLine("(" + x + ", " + y + ") Winforms Components - Common Controls");
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
            Console.WriteLine("Form size: " + width + ", " + height);

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
            Console.WriteLine("inserted item: [none, Fixed single, Fixed 3D, Fixed Dialog, Sizable, Fixed tool window, Sizable tool window]");
        }

        private void mainForm_Load(Object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "none")
            {
                Console.WriteLine("FromBorderStyle: None. selected!");
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            } 
            else if (comboBox1.SelectedItem == "Fixed single")
            {
                Console.WriteLine("FromBorderStyle: FixedSingle. selected!");
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            } 
            else if (comboBox1.SelectedItem == "Fixed 3D")
            {
                Console.WriteLine("FromBorderStyle: Fixed3D. selected!");
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            }
            else if (comboBox1.SelectedItem == "Fixed Dialog")
            {
                Console.WriteLine("FromBorderStyle: FixedDialog. selected!");
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            }
            else if (comboBox1.SelectedItem == "Sizable")
            {
                Console.WriteLine("FromBorderStyle: Sizable. selected!");
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
            else if (comboBox1.SelectedItem == "Fixed tool window")
            {
                Console.WriteLine("FromBorderStyle: FixedToolWindow. selected!");
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            }
            else if (comboBox1.SelectedItem == "Sizable tool window")
            {
                Console.WriteLine("FromBorderStyle: SizableToolWindow. selected!");
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            }
        }

        private void targetButtonVisible() 
        {
            if (targetButton.Visible == false)
            {
                Console.WriteLine("targetButton visible: true");
                bVisible.Text = "Visible = True";
                targetButton.Visible = true;
            } else if (targetButton.Visible == true)
            {
                Console.WriteLine("targetButton visible: false");
                bVisible.Text = "Visible = False";
                targetButton.Visible = false;
            }
        }


        private void bVisible_Click(object sender, EventArgs e)
        {
            targetButtonVisible();
        }

        private void bCenterTarget_Click(object sender, EventArgs e)
        {
            int width = this.Size.Width / 2 - 50;
            int height = this.Size.Height / 2 - 50;
                 
            targetButton.Location = new Point(width, height);
            Console.WriteLine("targetButton: center(" + width + ", " + height + ")");
        }

        private void targetbuttonEnabled()
        {
            if (targetButton.Enabled == false)
            {
                targetButton.Enabled = true;
                vEnabled.Text = "Enabled = True";
                Console.WriteLine("targetButton enable: true");
            }
            else if (targetButton.Enabled == true)
            {
                targetButton.Enabled = false;
                vEnabled.Text = "Enabled = False";
                Console.WriteLine("targetButton enable: false");
            }
        }

        private void bEnabled_Click(object sender, EventArgs e)
        {
            targetbuttonEnabled();
        }

        private void targetButton_Move(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;

            targetButton.Text = "Target\nX = " + x + "\nY = " + y;
            Console.Write("targetButton: (" + x + ",  " + y + ") : ");
        }
    }
}
