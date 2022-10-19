using System.Collections.Generic;

namespace Excel.domain
{
    public class Table
    {
        public int ColumnsAmount { get; set; }
        public int RowsAmount { get; set; }

        public readonly List<List<Cell>> Sheet = new();

        public Table()
        {

        }

        public Table(int columnsAmount, int rowsAmount)
        {
            ColumnsAmount = columnsAmount;
            RowsAmount = rowsAmount;
        }
    }
}