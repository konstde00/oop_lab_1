using System.Collections.Generic;
using System.Linq;
using Excel.domain;

namespace Excel.service.impl
{
    public class CellService : ICellService
    {
        public void UpdateCellData(Cell cell, string expression, string value, List<Cell> references, List<Cell> pointers)
        {
            cell.ReferencesFromThis.Clear();
            cell.ReferencesFromThis.AddRange(references);
            cell.PointersToThis.Clear();
            cell.PointersToThis.AddRange(pointers);
        }

        public bool CheckLoop(Cell cell, List<Cell> list)  //??
        {
            if (list.Any(c => c.Name == cell.Name))
            {
                return false;
            }
            foreach (var point in cell.PointersToThis)
            {
                if (list.Any(c => c.Name == point.Name))
                {
                    return false;
                }

                if (!CheckLoop(cell, list))
                {
                    return false;
                }
            }
            return true;
        }

        public void AddPointersAndReferences(Cell cell)
        {
            foreach (var point in cell.NewReferencesFromThis)
            {
                point.PointersToThis.Add(cell);
            }
            cell.ReferencesFromThis = cell.NewReferencesFromThis;
        }

        public void DeletePointersAndReferences(Cell cell)
        {
            if (cell.ReferencesFromThis == null) return;

            foreach (var point in cell.ReferencesFromThis)
            {
                point.PointersToThis.Remove(cell);
            }
            cell.ReferencesFromThis = null;
        }
    }
}