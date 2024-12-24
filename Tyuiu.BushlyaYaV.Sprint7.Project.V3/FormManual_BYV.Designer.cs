namespace Tyuiu.BushlyaYaV.Sprint7.Project.V3
{
    partial class FormManual_BYV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual_BYV));
            groupBoxManual_BYV = new GroupBox();
            buttonOkManual_BYV = new Button();
            textBoxManual_BYV = new TextBox();
            groupBoxManual_BYV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxManual_BYV
            // 
            groupBoxManual_BYV.Controls.Add(buttonOkManual_BYV);
            groupBoxManual_BYV.Controls.Add(textBoxManual_BYV);
            groupBoxManual_BYV.Dock = DockStyle.Fill;
            groupBoxManual_BYV.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxManual_BYV.Location = new Point(0, 0);
            groupBoxManual_BYV.Name = "groupBoxManual_BYV";
            groupBoxManual_BYV.Size = new Size(559, 337);
            groupBoxManual_BYV.TabIndex = 0;
            groupBoxManual_BYV.TabStop = false;
            groupBoxManual_BYV.Text = "Руководство пользователя";
            // 
            // buttonOkManual_BYV
            // 
            buttonOkManual_BYV.Location = new Point(438, 289);
            buttonOkManual_BYV.MaximumSize = new Size(103, 36);
            buttonOkManual_BYV.MinimumSize = new Size(103, 36);
            buttonOkManual_BYV.Name = "buttonOkManual_BYV";
            buttonOkManual_BYV.Size = new Size(103, 36);
            buttonOkManual_BYV.TabIndex = 1;
            buttonOkManual_BYV.Text = "ОК";
            buttonOkManual_BYV.UseVisualStyleBackColor = true;
            buttonOkManual_BYV.Click += buttonOkManual_BYV_Click;
            // 
            // textBoxManual_BYV
            // 
            textBoxManual_BYV.BackColor = SystemColors.Menu;
            textBoxManual_BYV.BorderStyle = BorderStyle.None;
            textBoxManual_BYV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxManual_BYV.Location = new Point(0, 32);
            textBoxManual_BYV.Multiline = true;
            textBoxManual_BYV.Name = "textBoxManual_BYV";
            textBoxManual_BYV.Size = new Size(408, 299);
            textBoxManual_BYV.TabIndex = 0;
            textBoxManual_BYV.TabStop = false;
            textBoxManual_BYV.Text = resources.GetString("textBoxManual_BYV.Text");
            // 
            // FormManual_BYV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 337);
            Controls.Add(groupBoxManual_BYV);
            MaximumSize = new Size(575, 376);
            MinimumSize = new Size(575, 376);
            Name = "FormManual_BYV";
            Text = "Руководство";
            groupBoxManual_BYV.ResumeLayout(false);
            groupBoxManual_BYV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxManual_BYV;
        private TextBox textBoxManual_BYV;
        private Button buttonOkManual_BYV;
    }
}