namespace AuthorizationApp
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Log = new System.Windows.Forms.Button();
            this.button_Reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Log
            // 
            this.button_Log.Location = new System.Drawing.Point(276, 118);
            this.button_Log.Name = "button_Log";
            this.button_Log.Size = new System.Drawing.Size(193, 60);
            this.button_Log.TabIndex = 0;
            this.button_Log.Text = "Логін";
            this.button_Log.UseVisualStyleBackColor = true;
            this.button_Log.Click += new System.EventHandler(this.button_Log_Click);
            // 
            // button_Reg
            // 
            this.button_Reg.Location = new System.Drawing.Point(276, 249);
            this.button_Reg.Name = "button_Reg";
            this.button_Reg.Size = new System.Drawing.Size(193, 60);
            this.button_Reg.TabIndex = 1;
            this.button_Reg.Text = "Реєстрація";
            this.button_Reg.UseVisualStyleBackColor = true;
            this.button_Reg.Click += new System.EventHandler(this.button_Reg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Reg);
            this.Controls.Add(this.button_Log);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Log;
        private System.Windows.Forms.Button button_Reg;
    }
}

