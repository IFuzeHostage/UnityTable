using System.Collections.Generic;

namespace IFuzeHostage.UnityTable.Data
{
    public class TableData
    {
        public List<TableLineData> Lines { get; }
        
        public TableData(List<TableLineData> lines)
        {
            Lines = lines;
        }
    }
}