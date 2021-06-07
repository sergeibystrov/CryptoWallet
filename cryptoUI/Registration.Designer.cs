
namespace cryptoUI
{
    partial class Registration
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
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.buttonSingUp = new System.Windows.Forms.Button();
            this.labelReg = new System.Windows.Forms.Label();
            this.buttonEye1 = new System.Windows.Forms.Button();
            this.buttonEye2 = new System.Windows.Forms.Button();
            this.buttonOpenEyes1 = new System.Windows.Forms.Button();
            this.buttonOpenEyes2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.labelPassword.Location = new System.Drawing.Point(12, 72);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(106, 25);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(197, 69);
            this.textBoxPassword.MaxLength = 16;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(276, 24);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            this.textBoxPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyUp);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.labelLogin.Location = new System.Drawing.Point(12, 25);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(65, 25);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(197, 22);
            this.textBoxLogin.MaxLength = 16;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(317, 24);
            this.textBoxLogin.TabIndex = 6;
            this.textBoxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLogin_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Repeat password";
            // 
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBoxRepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(197, 114);
            this.textBoxRepeatPassword.MaxLength = 16;
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(276, 24);
            this.textBoxRepeatPassword.TabIndex = 11;
            this.textBoxRepeatPassword.UseSystemPasswordChar = true;
            this.textBoxRepeatPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxRepeatPassword_KeyUp);
            // 
            // buttonSingUp
            // 
            this.buttonSingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingUp.ForeColor = System.Drawing.Color.Gold;
            this.buttonSingUp.Location = new System.Drawing.Point(17, 183);
            this.buttonSingUp.Name = "buttonSingUp";
            this.buttonSingUp.Size = new System.Drawing.Size(497, 53);
            this.buttonSingUp.TabIndex = 14;
            this.buttonSingUp.Text = "Sing up";
            this.buttonSingUp.UseVisualStyleBackColor = true;
            this.buttonSingUp.Click += new System.EventHandler(this.buttonSingUp_Click);
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReg.ForeColor = System.Drawing.Color.Red;
            this.labelReg.Location = new System.Drawing.Point(201, 155);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(73, 25);
            this.labelReg.TabIndex = 15;
            this.labelReg.Text = "Status";
            // 
            // buttonEye1
            // 
            this.buttonEye1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.buttonEye1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEye1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEye1.Location = new System.Drawing.Point(479, 66);
            this.buttonEye1.Name = "buttonEye1";
            this.buttonEye1.Size = new System.Drawing.Size(35, 31);
            this.buttonEye1.TabIndex = 18;
            this.buttonEye1.Text = "🙈";
            this.buttonEye1.UseVisualStyleBackColor = false;
            this.buttonEye1.Click += new System.EventHandler(this.buttonEye1_Click);
            // 
            // buttonEye2
            // 
            this.buttonEye2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.buttonEye2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEye2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEye2.Location = new System.Drawing.Point(479, 111);
            this.buttonEye2.Name = "buttonEye2";
            this.buttonEye2.Size = new System.Drawing.Size(35, 31);
            this.buttonEye2.TabIndex = 19;
            this.buttonEye2.Text = "🙈";
            this.buttonEye2.UseVisualStyleBackColor = false;
            this.buttonEye2.Click += new System.EventHandler(this.buttonEye2_Click);
            // 
            // buttonOpenEyes1
            // 
            this.buttonOpenEyes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.buttonOpenEyes1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenEyes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenEyes1.Location = new System.Drawing.Point(479, 66);
            this.buttonOpenEyes1.Name = "buttonOpenEyes1";
            this.buttonOpenEyes1.Size = new System.Drawing.Size(35, 31);
            this.buttonOpenEyes1.TabIndex = 20;
            this.buttonOpenEyes1.Text = "🙉";
            this.buttonOpenEyes1.UseVisualStyleBackColor = false;
            this.buttonOpenEyes1.Click += new System.EventHandler(this.buttonOpenEyes1_Click);
            // 
            // buttonOpenEyes2
            // 
            this.buttonOpenEyes2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(4)))));
            this.buttonOpenEyes2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenEyes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenEyes2.Location = new System.Drawing.Point(479, 111);
            this.buttonOpenEyes2.Name = "buttonOpenEyes2";
            this.buttonOpenEyes2.Size = new System.Drawing.Size(35, 31);
            this.buttonOpenEyes2.TabIndex = 21;
            this.buttonOpenEyes2.Text = "🙉";
            this.buttonOpenEyes2.UseVisualStyleBackColor = false;
            this.buttonOpenEyes2.Click += new System.EventHandler(this.buttonOpenEyes2_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(533, 273);
            this.Controls.Add(this.buttonOpenEyes2);
            this.Controls.Add(this.buttonOpenEyes1);
            this.Controls.Add(this.buttonEye2);
            this.Controls.Add(this.buttonEye1);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.buttonSingUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRepeatPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.Button buttonSingUp;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Button buttonEye1;
        private System.Windows.Forms.Button buttonEye2;
        private System.Windows.Forms.Button buttonOpenEyes1;
        private System.Windows.Forms.Button buttonOpenEyes2;
    }
}