using System.Collections.Generic;
using Excel.domain;

namespace Excel.service
{
    public interface ICellService
    {
        void UpdateCellData(Cell cell, string expression, string value, List<Cell> references, List<Cell> pointers);

        bool CheckLoop(Cell cell, List<Cell> list);

        void AddPointersAndReferences(Cell cell);

        void DeletePointersAndReferences(Cell cell);
    }
}