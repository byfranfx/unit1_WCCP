﻿namespace Unit1_WCCP
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
            this.bCenterTarget = new System.Windows.Forms.Button();
            this.vEnabled = new System.Windows.Forms.Button();
            this.bVisible = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetButton
            // 
            this.targetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.targetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.targetButton.ForeColor = System.Drawing.Color.Snow;
            this.targetButton.Location = new System.Drawing.Point(0, 0);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(100, 100);
            this.targetButton.TabIndex = 0;
            this.targetButton.TabStop = false;
            this.targetButton.Text = "Target\r\nX = 0\r\nY = 0";
            this.targetButton.UseVisualStyleBackColor = false;
            this.targetButton.Move += new System.EventHandler(this.targetButton_Move);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.targetRight);
            this.groupBox1.Controls.Add(this.targetDown);
            this.groupBox1.Controls.Add(this.targetUp);
            this.groupBox1.Controls.Add(this.TargetLeft);
            this.groupBox1.Controls.Add(this.bCenterTarget);
            this.groupBox1.Controls.Add(this.vEnabled);
            this.groupBox1.Controls.Add(this.bVisible);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
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
            this.targetRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.targetRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.targetRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.targetRight.Location = new System.Drawing.Point(125, 309);
            this.targetRight.Name = "targetRight";
            this.targetRight.Size = new System.Drawing.Size(37, 37);
            this.targetRight.TabIndex = 6;
            this.targetRight.Text = "🡆";
            this.targetRight.UseVisualStyleBackColor = false;
            this.targetRight.Click += new System.EventHandler(this.targetRight_Click);
            // 
            // targetDown
            // 
            this.targetDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.targetDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.targetDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.targetDown.Location = new System.Drawing.Point(82, 309);
            this.targetDown.Name = "targetDown";
            this.targetDown.Size = new System.Drawing.Size(37, 37);
            this.targetDown.TabIndex = 7;
            this.targetDown.Text = "🡇";
            this.targetDown.UseVisualStyleBackColor = false;
            this.targetDown.Click += new System.EventHandler(this.targetDown_Click);
            // 
            // TargetLeft
            // 
            this.TargetLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.TargetLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TargetLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.TargetLeft.Location = new System.Drawing.Point(39, 309);
            this.TargetLeft.Name = "TargetLeft";
            this.TargetLeft.Size = new System.Drawing.Size(37, 37);
            this.TargetLeft.TabIndex = 5;
            this.TargetLeft.Text = "🡄";
            this.TargetLeft.UseVisualStyleBackColor = false;
            this.TargetLeft.Click += new System.EventHandler(this.targetLeft_Click);
            // 
            // targetUp
            // 
            this.targetUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.targetUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.targetUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.targetUp.Location = new System.Drawing.Point(82, 266);
            this.targetUp.Name = "targetUp";
            this.targetUp.Size = new System.Drawing.Size(37, 37);
            this.targetUp.TabIndex = 4;
            this.targetUp.Text = "🡅";
            this.targetUp.UseVisualStyleBackColor = false;
            this.targetUp.Click += new System.EventHandler(this.targetUp_Click);
            // 
            // bCenterTarget
            // 
            this.bCenterTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.bCenterTarget.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCenterTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.bCenterTarget.Location = new System.Drawing.Point(16, 175);
            this.bCenterTarget.Name = "bCenterTarget";
            this.bCenterTarget.Size = new System.Drawing.Size(167, 23);
            this.bCenterTarget.TabIndex = 3;
            this.bCenterTarget.Text = "Center Target";
            this.bCenterTarget.UseVisualStyleBackColor = false;
            this.bCenterTarget.Click += new System.EventHandler(this.bCenterTarget_Click);
            // 
            // vEnabled
            // 
            this.vEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.vEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.vEnabled.Location = new System.Drawing.Point(16, 146);
            this.vEnabled.Name = "vEnabled";
            this.vEnabled.Size = new System.Drawing.Size(167, 23);
            this.vEnabled.TabIndex = 2;
            this.vEnabled.Text = "Enabled = True";
            this.vEnabled.UseVisualStyleBackColor = false;
            this.vEnabled.Click += new System.EventHandler(this.bEnabled_Click);
            // 
            // bVisible
            // 
            this.bVisible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.bVisible.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bVisible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.bVisible.Location = new System.Drawing.Point(16, 117);
            this.bVisible.Name = "bVisible";
            this.bVisible.Size = new System.Drawing.Size(167, 23);
            this.bVisible.TabIndex = 1;
            this.bVisible.Text = "Visible = True";
            this.bVisible.UseVisualStyleBackColor = false;
            this.bVisible.Click += new System.EventHandler(this.bVisible_Click);
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
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(12, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 15);
            this.label2.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
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
        private System.Windows.Forms.Button bCenterTarget;
        private System.Windows.Forms.Button vEnabled;
        private System.Windows.Forms.Button bVisible;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

