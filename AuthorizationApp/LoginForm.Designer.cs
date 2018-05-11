namespace AuthorizationApp
{
    partial class LoginForm
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
            this.button_Login_OK = new System.Windows.Forms.Button();
            this.Login_LogForm = new System.Windows.Forms.TextBox();
            this.Password_LogForm = new System.Windows.Forms.TextBox();
            this.label_Log = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Login_OK
            // 
            this.button_Login_OK.Location = new System.Drawing.Point(322, 308);
            this.button_Login_OK.Name = "button_Login_OK";
            this.button_Login_OK.Size = new System.Drawing.Size(155, 51);
            this.button_Login_OK.TabIndex = 0;
            this.button_Login_OK.Text = "OK";
            this.button_Login_OK.UseVisualStyleBackColor = true;
            this.button_Login_OK.Click += new System.EventHandler(this.button_Login_OK_Click);
            // 
            // Login_LogForm
            // 
            this.Login_LogForm.Location = new System.Drawing.Point(201, 101);
            this.Login_LogForm.Name = "Login_LogForm";
            this.Login_LogForm.Size = new System.Drawing.Size(100, 22);
            this.Login_LogForm.TabIndex = 1;
            // 
            // Password_LogForm
            // 
            this.Password_LogForm.Location = new System.Drawing.Point(201, 174);
            this.Password_LogForm.Name = "Password_LogForm";
            this.Password_LogForm.Size = new System.Drawing.Size(100, 22);
            this.Password_LogForm.TabIndex = 2;
            // 
            // label_Log
            // 
            this.label_Log.AutoSize = true;
            this.label_Log.Location = new System.Drawing.Point(107, 101);
            this.label_Log.Name = "label_Log";
            this.label_Log.Size = new System.Drawing.Size(43, 17);
            this.label_Log.TabIndex = 3;
            this.label_Log.Text = "Login";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(110, 174);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(69, 17);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_Log);
            this.Controls.Add(this.Password_LogForm);
            this.Controls.Add(this.Login_LogForm);
            this.Controls.Add(this.button_Login_OK);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Login_OK;
        private System.Windows.Forms.TextBox Login_LogForm;
        private System.Windows.Forms.TextBox Password_LogForm;
        private System.Windows.Forms.Label label_Log;
        private System.Windows.Forms.Label label_password;
    }
}