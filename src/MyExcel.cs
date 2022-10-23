using System;
using System.IO;
using System.Windows.Forms;
using Excel.domain;
using Excel.service;

namespace Excel
{
    public partial class MyExcel
    {
        private Table _table = new();
        private readonly ITableService _tableService;
        
        public MyExcel(ITableService tableService)
        {
            _tableService = tableService;
            InitializeComponent();

            InitializeDataGridView(35, 35);
        }

        private void InitializeDataGridView(int rows, int columns)
        {
            dataGridView.ColumnHeadersVisible = true;
            dataGridView.RowHeadersVisible = true;
            dataGridView.ColumnCount = columns;
            for (var i = 0; i < columns; i++)
            {
                var columnName = ColumnNameConverter.To26System(i);
                dataGridView.Columns[i].Name = columnName;
                dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (var i = 0; i < rows; i++)
            {
                dataGridView.Rows.Add("");
                dataGridView.Rows[i].HeaderCell.Value = i.ToString();
            }

            dataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            _table = _tableService.CreateTable(columns, rows);
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            var col = dataGridView.SelectedCells[0].ColumnIndex;
            var row = dataGridView.SelectedCells[0].RowIndex;
            var expression = textBox.Text;
            if (expression == "") return;
            _tableService.ChangeCellWithAllPointers(_table, row, col, expression, dataGridView);
            dataGridView[col, row].Value = _table.Sheet[row][col].Value;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var col = dataGridView.SelectedCells[0].ColumnIndex;
            var row = dataGridView.SelectedCells[0].RowIndex;
            var expression = "";
            try
            {
                expression = _table.Sheet[row][col].Expression;
            }
            catch 
            {
                MessageBox.Show("Selected incorrect cell");    
            }
            textBox.Text = expression;
            textBox.Focus();
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new System.Windows.Forms.DataGridViewRow();
            if (dataGridView.Columns.Count == 0)
            {
                MessageBox.Show("There are no colums");  
                return;
            }
            dataGridView.Rows.Add(row);
            dataGridView.Rows[_table.RowsAmount].HeaderCell.Value = _table.RowsAmount.ToString();
            _tableService.AddRow(_table, dataGridView);

        }
        private void addColButton_Click(object sender, EventArgs e)
        {
            string name = ColumnNameConverter.To26System(_table.ColumnsAmount);
            dataGridView.Columns.Add(name, name);
            _tableService.AddCol(_table);
        }

        private void delRowButton_Click(object sender, EventArgs e)
        {
            if (!_tableService.DeleteRow(_table, dataGridView))
                return;
            dataGridView.Rows.RemoveAt(_table.RowsAmount);
        }

        private void delColButton_Click(object sender, EventArgs e)
        {
            if (!_tableService.DeleteColumn(_table, dataGridView))
                return;
            dataGridView.Columns.RemoveAt(_table.ColumnsAmount);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "TableFile|*.txt";
            saveFileDialog1.Title = "Save table file";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                StreamWriter sw = new StreamWriter(fs);
                _tableService.Save(_table, sw);
                sw.Close();
                fs.Close();
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "TableFile|*.txt";
            openFileDialog1.Title = "Open Table File";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            _tableService.Clear(_table);
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            int.TryParse(sr.ReadLine(), out var row);
            int.TryParse(sr.ReadLine(), out var column);
            InitializeDataGridView(row, column);
            _tableService.Open(_table, row, column, sr, dataGridView);
            sr.Close();
        }
    }
}
