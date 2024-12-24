using System.Linq;
using Tyuiu.BushlyaYaV.Sprint7.Project.V3.Lib;
namespace Tyuiu.BushlyaYaV.Sprint7.Project.V3
{
    public partial class FormMain_BYV : Form
    {
        public FormMain_BYV()
        {
            InitializeComponent();
        }

        static string openPathFile;
        DataService ds = new DataService();


        private void buttonOpenFile_BYV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BYV.ShowDialog();
            openPathFile = openFileDialogTask_BYV.FileName;

            string[,] Matrix = ds.GetMatrix(openPathFile);

            int rows = Matrix.GetLength(0);
            int columns = Matrix.GetLength(1);

            dataGridViewFile_BYV.RowCount = rows;
            dataGridViewFile_BYV.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewFile_BYV.Columns[i].Width = 160;
                    dataGridViewFile_BYV.Rows[j].Height = 20;
                }
            }
            dataGridViewFile_BYV.Columns[0].HeaderText = "ФИО";
            dataGridViewFile_BYV.Columns[1].HeaderText = "Должность";
            dataGridViewFile_BYV.Columns[2].HeaderText = "Дисциплина";
            dataGridViewFile_BYV.Columns[3].HeaderText = "Аудитория";
            dataGridViewFile_BYV.Columns[4].HeaderText = "Тип контроля";

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewFile_BYV.Rows[r].Cells[c].Value = Matrix[r, c];
                }
            }
            buttonAdd_BYV.Enabled = true;
            buttonSave_BYV.Enabled = true;
            buttonSearch_BYV.Enabled = true;

            textBoxClass_BYV.Enabled = true;
            textBoxControlType_BYV.Enabled = true;
            textBoxDiscipline_BYV.Enabled = true;
            textBoxFIO_BYV.Enabled = true;
            textBoxPost_BYV.Enabled = true;
            textBoxSearch_BYV.Enabled = true;
        }

        private void buttonSave_BYV_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_BYV.ShowDialog();
            saveFileDialogTask_BYV.FileName = "University.cvs";
            saveFileDialogTask_BYV.InitialDirectory = Directory.GetCurrentDirectory();
            


            string path = saveFileDialogTask_BYV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists == true)
            {
                File.Delete(path);
            }

            int rows = dataGridViewFile_BYV.RowCount;
            int columns = dataGridViewFile_BYV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewFile_BYV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewFile_BYV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }



        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonHelp_BYV_Click(object sender, EventArgs e)
        {
            FormAbout_BYV formAbout_BYV = new FormAbout_BYV();
            formAbout_BYV.ShowDialog();
        }

        private void buttonManual_BYV_Click(object sender, EventArgs e)
        {
            FormManual_BYV formManual_BYV = new FormManual_BYV();
            formManual_BYV.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void buttonAdd_BYV_Click(object sender, EventArgs e)
        {
            string FIO  = textBoxFIO_BYV.Text;
            string Post = textBoxPost_BYV.Text;
            string Discipline = textBoxDiscipline_BYV.Text;
            string Class = textBoxClass_BYV.Text;
            string ControlType = textBoxControlType_BYV.Text;

            string[] rowArray = { FIO, Post, Discipline, Class, ControlType };
            bool added = ds.AddRow(openPathFile, rowArray);
            if (added == true)
            {
                MessageBox.Show("Данные успешно добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string[,] Matrix = ds.GetMatrix(openPathFile);
            int rows = Matrix.GetLength(0);
            int columns = Matrix.GetLength(1);

            dataGridViewFile_BYV.RowCount= rows;
            dataGridViewFile_BYV.ColumnCount= columns;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewFile_BYV.Columns[i].Width = 160;
                    dataGridViewFile_BYV.Rows[j].Height = 20;
                }
            }
            dataGridViewFile_BYV.Columns[0].HeaderText = "ФИО";
            dataGridViewFile_BYV.Columns[1].HeaderText = "Должность";
            dataGridViewFile_BYV.Columns[2].HeaderText = "Дисциплина";
            dataGridViewFile_BYV.Columns[3].HeaderText = "Аудитория";
            dataGridViewFile_BYV.Columns[4].HeaderText = "Тип контроля";

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewFile_BYV.Rows[r].Cells[c].Value = Matrix[r, c];
                }
            }
        }

        private void buttonSearch_BYV_Click(object sender, EventArgs e)
        {

            var data = ds.GetMatrix(openPathFile);
            var searchText = textBoxSearch_BYV.Text.ToLower();
            if (string.IsNullOrEmpty(searchText)) return;
            var filteredData = new List<string[]>();


            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0].ToLower().Contains(searchText) || data[i, 1].ToLower().Contains(searchText) ||
                    data[i, 2].ToLower().Contains(searchText) || data[i, 3].ToLower().Contains(searchText) ||
                    data[i, 4].ToLower().Contains(searchText))
                {
                    var row = new string[data.GetLength(1)];
                    for (int j = 0; j < row.Length; j++)
                    {
                        row[j] = data[i, j];
                    }
                    filteredData.Add(row);
                }
            }


            var filteredDataArray = filteredData.ToArray();
            dataGridViewFile_BYV.RowCount = filteredDataArray.Length;
            dataGridViewFile_BYV.ColumnCount = filteredDataArray.Length == 0 ? 0 : filteredDataArray[0].Length;


            for (int r = 0; r < filteredDataArray.Length; r++)
            {
                for (int c = 0; c < filteredDataArray[0].Length; c++)
                {
                    dataGridViewFile_BYV.Rows[r].Cells[c].Value = filteredDataArray[r][c];
                }
            }
        }



    }
}

