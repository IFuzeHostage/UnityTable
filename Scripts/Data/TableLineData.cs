using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IFuzeHostage.UnityTable.Data
{
    public class TableLineData
    {
        public int Id { get; }
        public List<ITableElementData> Elements { get; }
        
        public TableLineData(int id, List<ITableElementData> elements)
        {
            Id = id;
            Elements = elements;
        }
    }
}
