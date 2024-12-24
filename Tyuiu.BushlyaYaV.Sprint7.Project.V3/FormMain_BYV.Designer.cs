namespace Tyuiu.BushlyaYaV.Sprint7.Project.V3
{
    partial class FormMain_BYV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_BYV));
            panelTop_BYV = new Panel();
            groupBoxTask_BYV = new GroupBox();
            textBoxTask_BYV = new TextBox();
            groupBoxButtons_BYV = new GroupBox();
            buttonSearch_BYV = new Button();
            textBoxSearch_BYV = new TextBox();
            buttonHelp_BYV = new Button();
            buttonManual_BYV = new Button();
            buttonSave_BYV = new Button();
            buttonOpenFile_BYV = new Button();
            panelLeft_BYV = new Panel();
            groupBoxAdd_BYV = new GroupBox();
            textBoxControlType_BYV = new TextBox();
            textBoxClass_BYV = new TextBox();
            textBoxDiscipline_BYV = new TextBox();
            textBoxPost_BYV = new TextBox();
            textBoxFIO_BYV = new TextBox();
            labelControlType_BYV = new Label();
            labelClass_BYV = new Label();
            labelDiscipline_BYV = new Label();
            labelPost_BYV = new Label();
            labelFIO_BYV = new Label();
            buttonAdd_BYV = new Button();
            panelRight_BYV = new Panel();
            dataGridViewFile_BYV = new DataGridView();
            toolTipHelp_BYV = new ToolTip(components);
            openFileDialogTask_BYV = new OpenFileDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            saveFileDialogTask_BYV = new SaveFileDialog();
            panelTop_BYV.SuspendLayout();
            groupBoxTask_BYV.SuspendLayout();
            groupBoxButtons_BYV.SuspendLayout();
            panelLeft_BYV.SuspendLayout();
            groupBoxAdd_BYV.SuspendLayout();
            panelRight_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFile_BYV).BeginInit();
            SuspendLayout();
            // 
            // panelTop_BYV
            // 
            panelTop_BYV.BackColor = Color.IndianRed;
            panelTop_BYV.Controls.Add(groupBoxTask_BYV);
            panelTop_BYV.Controls.Add(groupBoxButtons_BYV);
            panelTop_BYV.Dock = DockStyle.Top;
            panelTop_BYV.Location = new Point(0, 0);
            panelTop_BYV.Name = "panelTop_BYV";
            panelTop_BYV.Size = new Size(1290, 194);
            panelTop_BYV.TabIndex = 0;
            // 
            // groupBoxTask_BYV
            // 
            groupBoxTask_BYV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_BYV.Controls.Add(textBoxTask_BYV);
            groupBoxTask_BYV.Location = new Point(0, 102);
            groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            groupBoxTask_BYV.Size = new Size(1298, 92);
            groupBoxTask_BYV.TabIndex = 1;
            groupBoxTask_BYV.TabStop = false;
            groupBoxTask_BYV.Text = "Условие:";
            // 
            // textBoxTask_BYV
            // 
            textBoxTask_BYV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTask_BYV.BackColor = Color.IndianRed;
            textBoxTask_BYV.BorderStyle = BorderStyle.None;
            textBoxTask_BYV.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_BYV.Location = new Point(218, 24);
            textBoxTask_BYV.Multiline = true;
            textBoxTask_BYV.Name = "textBoxTask_BYV";
            textBoxTask_BYV.Size = new Size(842, 57);
            textBoxTask_BYV.TabIndex = 0;
            textBoxTask_BYV.TabStop = false;
            textBoxTask_BYV.Text = "Разработать Desktop приложение на основе Windows Forms по предметной области. Все данные должны храниться в формате файла CSV.";
            // 
            // groupBoxButtons_BYV
            // 
            groupBoxButtons_BYV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxButtons_BYV.Controls.Add(buttonSearch_BYV);
            groupBoxButtons_BYV.Controls.Add(textBoxSearch_BYV);
            groupBoxButtons_BYV.Controls.Add(buttonHelp_BYV);
            groupBoxButtons_BYV.Controls.Add(buttonManual_BYV);
            groupBoxButtons_BYV.Controls.Add(buttonSave_BYV);
            groupBoxButtons_BYV.Controls.Add(buttonOpenFile_BYV);
            groupBoxButtons_BYV.Location = new Point(0, 0);
            groupBoxButtons_BYV.Name = "groupBoxButtons_BYV";
            groupBoxButtons_BYV.Size = new Size(1298, 112);
            groupBoxButtons_BYV.TabIndex = 0;
            groupBoxButtons_BYV.TabStop = false;
            groupBoxButtons_BYV.Text = "Панель управления";
            // 
            // buttonSearch_BYV
            // 
            buttonSearch_BYV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch_BYV.BackColor = Color.Brown;
            buttonSearch_BYV.Location = new Point(700, 43);
            buttonSearch_BYV.Name = "buttonSearch_BYV";
            buttonSearch_BYV.Size = new Size(86, 39);
            buttonSearch_BYV.TabIndex = 6;
            buttonSearch_BYV.Text = "Поиск";
            buttonSearch_BYV.UseVisualStyleBackColor = false;
            buttonSearch_BYV.Click += buttonSearch_BYV_Click;
            // 
            // textBoxSearch_BYV
            // 
            textBoxSearch_BYV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearch_BYV.Location = new Point(501, 52);
            textBoxSearch_BYV.Name = "textBoxSearch_BYV";
            textBoxSearch_BYV.Size = new Size(187, 23);
            textBoxSearch_BYV.TabIndex = 5;
            // 
            // buttonHelp_BYV
            // 
            buttonHelp_BYV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BYV.BackColor = Color.Brown;
            buttonHelp_BYV.Image = Properties.Resources.user_gray;
            buttonHelp_BYV.Location = new Point(1159, 32);
            buttonHelp_BYV.Name = "buttonHelp_BYV";
            buttonHelp_BYV.Size = new Size(118, 61);
            buttonHelp_BYV.TabIndex = 4;
            buttonHelp_BYV.UseVisualStyleBackColor = false;
            buttonHelp_BYV.Click += buttonHelp_BYV_Click;
            // 
            // buttonManual_BYV
            // 
            buttonManual_BYV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonManual_BYV.BackColor = Color.Brown;
            buttonManual_BYV.Image = Properties.Resources.help;
            buttonManual_BYV.Location = new Point(954, 32);
            buttonManual_BYV.Name = "buttonManual_BYV";
            buttonManual_BYV.Size = new Size(118, 61);
            buttonManual_BYV.TabIndex = 3;
            buttonManual_BYV.UseVisualStyleBackColor = false;
            buttonManual_BYV.Click += buttonManual_BYV_Click;
            // 
            // buttonSave_BYV
            // 
            buttonSave_BYV.BackColor = Color.Brown;
            buttonSave_BYV.Image = (Image)resources.GetObject("buttonSave_BYV.Image");
            buttonSave_BYV.Location = new Point(238, 30);
            buttonSave_BYV.Name = "buttonSave_BYV";
            buttonSave_BYV.Size = new Size(118, 61);
            buttonSave_BYV.TabIndex = 1;
            buttonSave_BYV.UseVisualStyleBackColor = false;
            // 
            // buttonOpenFile_BYV
            // 
            buttonOpenFile_BYV.BackColor = Color.Brown;
            buttonOpenFile_BYV.Image = Properties.Resources.folder;
            buttonOpenFile_BYV.Location = new Point(6, 30);
            buttonOpenFile_BYV.Name = "buttonOpenFile_BYV";
            buttonOpenFile_BYV.Size = new Size(118, 61);
            buttonOpenFile_BYV.TabIndex = 0;
            buttonOpenFile_BYV.UseVisualStyleBackColor = false;
            buttonOpenFile_BYV.Click += buttonOpenFile_BYV_Click;
            // 
            // panelLeft_BYV
            // 
            panelLeft_BYV.BackColor = Color.Tomato;
            panelLeft_BYV.Controls.Add(groupBoxAdd_BYV);
            panelLeft_BYV.Dock = DockStyle.Left;
            panelLeft_BYV.Location = new Point(0, 194);
            panelLeft_BYV.Name = "panelLeft_BYV";
            panelLeft_BYV.Size = new Size(406, 519);
            panelLeft_BYV.TabIndex = 1;
            // 
            // groupBoxAdd_BYV
            // 
            groupBoxAdd_BYV.Controls.Add(textBoxControlType_BYV);
            groupBoxAdd_BYV.Controls.Add(textBoxClass_BYV);
            groupBoxAdd_BYV.Controls.Add(textBoxDiscipline_BYV);
            groupBoxAdd_BYV.Controls.Add(textBoxPost_BYV);
            groupBoxAdd_BYV.Controls.Add(textBoxFIO_BYV);
            groupBoxAdd_BYV.Controls.Add(labelControlType_BYV);
            groupBoxAdd_BYV.Controls.Add(labelClass_BYV);
            groupBoxAdd_BYV.Controls.Add(labelDiscipline_BYV);
            groupBoxAdd_BYV.Controls.Add(labelPost_BYV);
            groupBoxAdd_BYV.Controls.Add(labelFIO_BYV);
            groupBoxAdd_BYV.Controls.Add(buttonAdd_BYV);
            groupBoxAdd_BYV.Dock = DockStyle.Fill;
            groupBoxAdd_BYV.Location = new Point(0, 0);
            groupBoxAdd_BYV.Name = "groupBoxAdd_BYV";
            groupBoxAdd_BYV.Size = new Size(406, 519);
            groupBoxAdd_BYV.TabIndex = 0;
            groupBoxAdd_BYV.TabStop = false;
            groupBoxAdd_BYV.Text = "Добавление строк";
            // 
            // textBoxControlType_BYV
            // 
            textBoxControlType_BYV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxControlType_BYV.Location = new Point(4, 423);
            textBoxControlType_BYV.Name = "textBoxControlType_BYV";
            textBoxControlType_BYV.Size = new Size(102, 23);
            textBoxControlType_BYV.TabIndex = 10;
            // 
            // textBoxClass_BYV
            // 
            textBoxClass_BYV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxClass_BYV.Location = new Point(4, 327);
            textBoxClass_BYV.Name = "textBoxClass_BYV";
            textBoxClass_BYV.Size = new Size(103, 23);
            textBoxClass_BYV.TabIndex = 9;
            // 
            // textBoxDiscipline_BYV
            // 
            textBoxDiscipline_BYV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxDiscipline_BYV.Location = new Point(4, 230);
            textBoxDiscipline_BYV.Name = "textBoxDiscipline_BYV";
            textBoxDiscipline_BYV.Size = new Size(103, 23);
            textBoxDiscipline_BYV.TabIndex = 8;
            // 
            // textBoxPost_BYV
            // 
            textBoxPost_BYV.Location = new Point(3, 134);
            textBoxPost_BYV.Name = "textBoxPost_BYV";
            textBoxPost_BYV.Size = new Size(103, 23);
            textBoxPost_BYV.TabIndex = 7;
            // 
            // textBoxFIO_BYV
            // 
            textBoxFIO_BYV.Location = new Point(3, 53);
            textBoxFIO_BYV.Name = "textBoxFIO_BYV";
            textBoxFIO_BYV.Size = new Size(103, 23);
            textBoxFIO_BYV.TabIndex = 6;
            // 
            // labelControlType_BYV
            // 
            labelControlType_BYV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelControlType_BYV.AutoSize = true;
            labelControlType_BYV.Location = new Point(7, 405);
            labelControlType_BYV.Name = "labelControlType_BYV";
            labelControlType_BYV.Size = new Size(85, 15);
            labelControlType_BYV.TabIndex = 5;
            labelControlType_BYV.Text = "Тип контроля ";
            // 
            // labelClass_BYV
            // 
            labelClass_BYV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelClass_BYV.AutoSize = true;
            labelClass_BYV.Location = new Point(7, 310);
            labelClass_BYV.Name = "labelClass_BYV";
            labelClass_BYV.Size = new Size(66, 15);
            labelClass_BYV.TabIndex = 4;
            labelClass_BYV.Text = "Аудитория";
            // 
            // labelDiscipline_BYV
            // 
            labelDiscipline_BYV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelDiscipline_BYV.AutoSize = true;
            labelDiscipline_BYV.Location = new Point(7, 213);
            labelDiscipline_BYV.Name = "labelDiscipline_BYV";
            labelDiscipline_BYV.Size = new Size(76, 15);
            labelDiscipline_BYV.TabIndex = 3;
            labelDiscipline_BYV.Text = "Дисциплина";
            // 
            // labelPost_BYV
            // 
            labelPost_BYV.AutoSize = true;
            labelPost_BYV.Location = new Point(6, 117);
            labelPost_BYV.Name = "labelPost_BYV";
            labelPost_BYV.Size = new Size(69, 15);
            labelPost_BYV.TabIndex = 2;
            labelPost_BYV.Text = "Должность";
            // 
            // labelFIO_BYV
            // 
            labelFIO_BYV.AutoSize = true;
            labelFIO_BYV.Location = new Point(6, 36);
            labelFIO_BYV.Name = "labelFIO_BYV";
            labelFIO_BYV.Size = new Size(34, 15);
            labelFIO_BYV.TabIndex = 1;
            labelFIO_BYV.Text = "ФИО";
            // 
            // buttonAdd_BYV
            // 
            buttonAdd_BYV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdd_BYV.BackColor = Color.Brown;
            buttonAdd_BYV.Image = Properties.Resources.accept;
            buttonAdd_BYV.Location = new Point(282, 212);
            buttonAdd_BYV.Name = "buttonAdd_BYV";
            buttonAdd_BYV.Size = new Size(75, 67);
            buttonAdd_BYV.TabIndex = 0;
            buttonAdd_BYV.UseVisualStyleBackColor = false;
            buttonAdd_BYV.Click += buttonAdd_BYV_Click;
            // 
            // panelRight_BYV
            // 
            panelRight_BYV.Controls.Add(dataGridViewFile_BYV);
            panelRight_BYV.Dock = DockStyle.Fill;
            panelRight_BYV.Location = new Point(406, 194);
            panelRight_BYV.Name = "panelRight_BYV";
            panelRight_BYV.Size = new Size(884, 519);
            panelRight_BYV.TabIndex = 2;
            // 
            // dataGridViewFile_BYV
            // 
            dataGridViewFile_BYV.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewFile_BYV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFile_BYV.Dock = DockStyle.Fill;
            dataGridViewFile_BYV.Location = new Point(0, 0);
            dataGridViewFile_BYV.Name = "dataGridViewFile_BYV";
            dataGridViewFile_BYV.RowHeadersVisible = false;
            dataGridViewFile_BYV.Size = new Size(884, 519);
            dataGridViewFile_BYV.TabIndex = 0;
            dataGridViewFile_BYV.TabStop = false;
            // 
            // toolTipHelp_BYV
            // 
            toolTipHelp_BYV.Popup += toolTip1_Popup;
            // 
            // openFileDialogTask_BYV
            // 
            openFileDialogTask_BYV.FileName = "openFileDialog1";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // FormMain_BYV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 713);
            Controls.Add(panelRight_BYV);
            Controls.Add(panelLeft_BYV);
            Controls.Add(panelTop_BYV);
            MinimumSize = new Size(1306, 752);
            Name = "FormMain_BYV";
            Text = "Университет";
            panelTop_BYV.ResumeLayout(false);
            groupBoxTask_BYV.ResumeLayout(false);
            groupBoxTask_BYV.PerformLayout();
            groupBoxButtons_BYV.ResumeLayout(false);
            groupBoxButtons_BYV.PerformLayout();
            panelLeft_BYV.ResumeLayout(false);
            groupBoxAdd_BYV.ResumeLayout(false);
            groupBoxAdd_BYV.PerformLayout();
            panelRight_BYV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFile_BYV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BYV;
        private Panel panelLeft_BYV;
        private Panel panelRight_BYV;
        private GroupBox groupBoxButtons_BYV;
        private GroupBox groupBoxTask_BYV;
        private TextBox textBoxTask_BYV;
        private Button buttonOpenFile_BYV;
        private Button buttonSave_BYV;
        private Button buttonHelp_BYV;
        private Button buttonManual_BYV;
        private GroupBox groupBoxAdd_BYV;
        private DataGridView dataGridViewFile_BYV;
        private Button buttonSearch_BYV;
        private TextBox textBoxSearch_BYV;
        private ToolTip toolTipHelp_BYV;
        private Button buttonAdd_BYV;
        private Label labelControlType_BYV;
        private Label labelClass_BYV;
        private Label labelDiscipline_BYV;
        private Label labelPost_BYV;
        private Label labelFIO_BYV;
        private TextBox textBoxControlType_BYV;
        private TextBox textBoxClass_BYV;
        private TextBox textBoxDiscipline_BYV;
        private TextBox textBoxPost_BYV;
        private TextBox textBoxFIO_BYV;
        private OpenFileDialog openFileDialogTask_BYV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SaveFileDialog saveFileDialogTask_BYV;
    }
}
