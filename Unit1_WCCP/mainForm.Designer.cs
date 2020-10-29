namespace Unit1_WCCP
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.targetButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.targetRight = new System.Windows.Forms.Button();
            this.targetDown = new System.Windows.Forms.Button();
            this.TargetLeft = new System.Windows.Forms.Button();
            this.targetUp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetButton
            // 
            this.targetButton.Location = new System.Drawing.Point(0, 0);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(100, 100);
            this.targetButton.TabIndex = 0;
            this.targetButton.TabStop = false;
            this.targetButton.Text = "Target\r\nX = 0\r\nY = 0";
            this.targetButton.UseVisualStyleBackColor = true;
            this.targetButton.Move += new System.EventHandler(this.targetButton_Move);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.targetRight);
            this.groupBox1.Controls.Add(this.targetDown);
            this.groupBox1.Controls.Add(this.TargetLeft);
            this.groupBox1.Controls.Add(this.targetUp);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(554, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FormBorderStyle";
            // 
            // targetRight
            // 
            this.targetRight.Location = new System.Drawing.Point(131, 274);
            this.targetRight.Name = "targetRight";
            this.targetRight.Size = new System.Drawing.Size(37, 37);
            this.targetRight.TabIndex = 6;
            this.targetRight.Text = "🡆";
            this.targetRight.UseVisualStyleBackColor = true;
            this.targetRight.Click += new System.EventHandler(this.targetRight_Click);
            // 
            // targetDown
            // 
            this.targetDown.Location = new System.Drawing.Point(88, 274);
            this.targetDown.Name = "targetDown";
            this.targetDown.Size = new System.Drawing.Size(37, 37);
            this.targetDown.TabIndex = 7;
            this.targetDown.Text = "🡇";
            this.targetDown.UseVisualStyleBackColor = true;
            this.targetDown.Click += new System.EventHandler(this.targetDown_Click);
            // 
            // TargetLeft
            // 
            this.TargetLeft.Location = new System.Drawing.Point(45, 274);
            this.TargetLeft.Name = "TargetLeft";
            this.TargetLeft.Size = new System.Drawing.Size(37, 37);
            this.TargetLeft.TabIndex = 5;
            this.TargetLeft.Text = "🡄";
            this.TargetLeft.UseVisualStyleBackColor = true;
            this.TargetLeft.Click += new System.EventHandler(this.targetLeft_Click);
            // 
            // targetUp
            // 
            this.targetUp.Location = new System.Drawing.Point(88, 231);
            this.targetUp.Name = "targetUp";
            this.targetUp.Size = new System.Drawing.Size(37, 37);
            this.targetUp.TabIndex = 4;
            this.targetUp.Text = "🡅";
            this.targetUp.UseVisualStyleBackColor = true;
            this.targetUp.Click += new System.EventHandler(this.targetUp_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Center Target";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enabled = True";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Visible = True";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.targetButton);
            this.Name = "mainForm";
            this.Text = "(0, 0) Winforms Components - Common Controls";
            this.Move += new System.EventHandler(this.mainForm_Move);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button targetRight;
        private System.Windows.Forms.Button targetDown;
        private System.Windows.Forms.Button TargetLeft;
        private System.Windows.Forms.Button targetUp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

