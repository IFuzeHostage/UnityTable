using System;
using UnityEngine;

namespace IFuzeHostage.UnityTable.Data
{
    [Serializable]
    public class TableColumnData
    {
        public float Width => _widthValue;
        public string Name => _name;

        [SerializeField]
        private float _widthValue;
        [SerializeField]
        private string _name;
    }
}