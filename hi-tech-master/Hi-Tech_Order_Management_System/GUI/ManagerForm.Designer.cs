﻿namespace Hi_Tech_Order_Management_System.GUI
{
    partial class ManagerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hint = new System.Windows.Forms.Label();
            this.HintUser = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserId:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(168, 64);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(132, 20);
            this.userTextBox.TabIndex = 3;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(168, 116);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(132, 20);
            this.passTextBox.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(131, 165);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 41);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.hint);
            this.groupBox1.Controls.Add(this.HintUser);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.passTextBox);
            this.groupBox1.Controls.Add(this.userTextBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(542, 324);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log In";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // hint
            // 
            this.hint.AutoSize = true;
            this.hint.ForeColor = System.Drawing.Color.Red;
            this.hint.Location = new System.Drawing.Point(166, 138);
            this.hint.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(0, 13);
            this.hint.TabIndex = 10;
            // 
            // HintUser
            // 
            this.HintUser.AutoSize = true;
            this.HintUser.ForeColor = System.Drawing.Color.Red;
            this.HintUser.Location = new System.Drawing.Point(168, 84);
            this.HintUser.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.HintUser.Name = "HintUser";
            this.HintUser.Size = new System.Drawing.Size(0, 13);
            this.HintUser.TabIndex = 9;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(194, 228);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(87, 51);
            this.Password.TabIndex = 8;
            this.Password.Text = "Change Password";
            this.Password.UseVisualStyleBackColor = false;
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(256, 165);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 41);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(560, 340);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Password;
        private System.Windows.Forms.Label HintUser;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.Button buttonExit;
    }
}