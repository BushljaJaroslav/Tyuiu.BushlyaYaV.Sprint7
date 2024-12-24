namespace Tyuiu.BushlyaYaV.Sprint7.Project.V3
{
    partial class FormAbout_BYV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_BYV));
            pictureBoxAvatar_BYV = new PictureBox();
            textBox1 = new TextBox();
            buttonOk_BYV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_BYV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_BYV
            // 
            pictureBoxAvatar_BYV.Image = (Image)resources.GetObject("pictureBoxAvatar_BYV.Image");
            pictureBoxAvatar_BYV.Location = new Point(12, 24);
            pictureBoxAvatar_BYV.Name = "pictureBoxAvatar_BYV";
            pictureBoxAvatar_BYV.Size = new Size(117, 139);
            pictureBoxAvatar_BYV.TabIndex = 0;
            pictureBoxAvatar_BYV.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(135, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 163);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.Text = "Разработчик: Бушля Я. В.\r\nГруппа: ИСТНб-24-1\r\n\r\nПрограмма разработана в рамках изучения языка C#\r\n\r\nТюменский индустриальный университет (c) 2024\r\nВысшая школа цифровых технологий (c) 2024\r\n";
            // 
            // buttonOk_BYV
            // 
            buttonOk_BYV.Location = new Point(345, 186);
            buttonOk_BYV.MaximumSize = new Size(75, 23);
            buttonOk_BYV.MinimumSize = new Size(75, 23);
            buttonOk_BYV.Name = "buttonOk_BYV";
            buttonOk_BYV.Size = new Size(75, 23);
            buttonOk_BYV.TabIndex = 2;
            buttonOk_BYV.Text = "ОК";
            buttonOk_BYV.UseVisualStyleBackColor = true;
            buttonOk_BYV.Click += buttonOk_BYV_Click;
            // 
            // FormAbout_BYV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 221);
            Controls.Add(buttonOk_BYV);
            Controls.Add(textBox1);
            Controls.Add(pictureBoxAvatar_BYV);
            MaximumSize = new Size(454, 260);
            MinimumSize = new Size(454, 260);
            Name = "FormAbout_BYV";
            Text = "Разработчик ";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_BYV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_BYV;
        private TextBox textBox1;
        private Button buttonOk_BYV;
    }
}