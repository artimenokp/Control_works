namespace Control_work_1._1
{
    partial class MainForm
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
            this.Startx = new System.Windows.Forms.Label();
            this.Endx = new System.Windows.Forms.Label();
            this.Stepx = new System.Windows.Forms.Label();
            this.textBoxStartx = new System.Windows.Forms.TextBox();
            this.textBoxEndx = new System.Windows.Forms.TextBox();
            this.textBoxStepx = new System.Windows.Forms.TextBox();
            this.Inputn = new System.Windows.Forms.Label();
            this.textBoxInputn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Startx
            // 
            this.Startx.AutoSize = true;
            this.Startx.Location = new System.Drawing.Point(22, 27);
            this.Startx.Name = "Startx";
            this.Startx.Size = new System.Drawing.Size(166, 13);
            this.Startx.TabIndex = 0;
            this.Startx.Text = "Введите начальное значение x:";
            // 
            // Endx
            // 
            this.Endx.AutoSize = true;
            this.Endx.Location = new System.Drawing.Point(28, 64);
            this.Endx.Name = "Endx";
            this.Endx.Size = new System.Drawing.Size(160, 13);
            this.Endx.TabIndex = 1;
            this.Endx.Text = "Введите конечное значение x:";
            // 
            // Stepx
            // 
            this.Stepx.AutoSize = true;
            this.Stepx.Location = new System.Drawing.Point(47, 99);
            this.Stepx.Name = "Stepx";
            this.Stepx.Size = new System.Drawing.Size(141, 13);
            this.Stepx.TabIndex = 2;
            this.Stepx.Text = "Введите шаг изменения x:";
            // 
            // textBoxStartx
            // 
            this.textBoxStartx.Location = new System.Drawing.Point(197, 27);
            this.textBoxStartx.Name = "textBoxStartx";
            this.textBoxStartx.Size = new System.Drawing.Size(106, 20);
            this.textBoxStartx.TabIndex = 3;
            // 
            // textBoxEndx
            // 
            this.textBoxEndx.Location = new System.Drawing.Point(197, 64);
            this.textBoxEndx.Name = "textBoxEndx";
            this.textBoxEndx.Size = new System.Drawing.Size(106, 20);
            this.textBoxEndx.TabIndex = 4;
            // 
            // textBoxStepx
            // 
            this.textBoxStepx.Location = new System.Drawing.Point(197, 99);
            this.textBoxStepx.Name = "textBoxStepx";
            this.textBoxStepx.Size = new System.Drawing.Size(106, 20);
            this.textBoxStepx.TabIndex = 5;
            // 
            // Inputn
            // 
            this.Inputn.AutoSize = true;
            this.Inputn.Location = new System.Drawing.Point(77, 134);
            this.Inputn.Name = "Inputn";
            this.Inputn.Size = new System.Drawing.Size(111, 13);
            this.Inputn.TabIndex = 6;
            this.Inputn.Text = "Введите значение n:";
            // 
            // textBoxInputn
            // 
            this.textBoxInputn.Location = new System.Drawing.Point(197, 134);
            this.textBoxInputn.Name = "textBoxInputn";
            this.textBoxInputn.Size = new System.Drawing.Size(106, 20);
            this.textBoxInputn.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 261);
            this.Controls.Add(this.textBoxInputn);
            this.Controls.Add(this.Inputn);
            this.Controls.Add(this.textBoxStepx);
            this.Controls.Add(this.textBoxEndx);
            this.Controls.Add(this.textBoxStartx);
            this.Controls.Add(this.Stepx);
            this.Controls.Add(this.Endx);
            this.Controls.Add(this.Startx);
            this.Name = "MainForm";
            this.Text = "Контрольная работа 1. Задание 1.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Startx;
        private System.Windows.Forms.Label Endx;
        private System.Windows.Forms.Label Stepx;
        private System.Windows.Forms.TextBox textBoxStartx;
        private System.Windows.Forms.TextBox textBoxEndx;
        private System.Windows.Forms.TextBox textBoxStepx;
        private System.Windows.Forms.Label Inputn;
        private System.Windows.Forms.TextBox textBoxInputn;
    }
}

