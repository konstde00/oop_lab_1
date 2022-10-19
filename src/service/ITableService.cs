using System.IO;
using System.Windows.Forms;
using Excel.domain;

namespace Excel.service
{
    public interface ITableService
    {
        Table CreateTable(int columnsAmount, int rowsAmount);

        void Clear(Table table);

        void ChangeCellWithAllPointers(Table table, int row, int col, string expression,
            DataGridView dataGridView1);

        void AddRow(Table table, DataGridView dataGridView1);

        void AddCol(Table table);

        bool DeleteRow(Table table, DataGridView dataGridView1);

        bool DeleteColumn(Table table, DataGridView dataGridView1);

        void Save(Table table, StreamWriter sw);

        void Open(Table table, int row, int column, StreamReader sr, DataGridView dataGridView1);
    }
}