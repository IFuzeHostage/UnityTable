using System.Collections;
using System.Collections.Generic;
using System.Linq;
using IFuzeHostage.UnityTable.Data;
using UnityEngine;

public class Table : MonoBehaviour
{
    [SerializeField]
    private TableLine _linePrefab;
    [SerializeField] 
    private RectTransform _parent;
    [SerializeField]
    private List<TableColumnData> _columns;
    [SerializeField]
    private TableLine _header;
    
    private Dictionary<int, TableLine> _lines = new Dictionary<int, TableLine>();
    
    public void SetData(TableData data)
    {
        InitHeader();
        
        foreach (Transform child in _parent)
        {
            Destroy(child.gameObject);
        }
        _lines.Clear();
        var size = GerParentSize();
        var totalSize = _columns.Sum(data => data.Width);
        
        foreach (var lineData in data.Lines)
        {
            var line = Instantiate(_linePrefab, _parent);
            line.SetData(lineData);
            _lines.Add(lineData.Id, line);
            line.SetSizes(_columns.ConvertAll(columnData => columnData.Width / totalSize * size));
        }
    }
    
    public void UpdateLine(int index, TableLineData data)
    {
        if (_lines.TryGetValue(index, out var line))
        {
            line.SetData(data);
        }
        else
        {
            line = Instantiate(_linePrefab, _parent);
            line.SetData(data);
            _lines.Add(index, line);
        }
    }

    public void UpdateTable(TableData tableData)
    {
        foreach (var data in tableData.Lines)
        {
            UpdateLine(data.Id, data);
        }
    }
    
    public void RemoveLine(int index)
    {
        if (_lines.TryGetValue(index, out var line))
        {
            Destroy(line.gameObject);
            _lines.Remove(index);
        }
    }

    private float GerParentSize()
    {
        return _parent.rect.width;
    }

    private void InitHeader()
    {
        var headerData = new TableLineData(0,
            _columns.ConvertAll(columnData => new StringElementData(columnData.Name) as ITableElementData));
        
        var size = GerParentSize();
        var totalSize = _columns.Sum(data => data.Width);
        
        _header.SetData(headerData);
        _header.SetSizes(_columns.ConvertAll(columnData => columnData.Width / totalSize * size));
    }
}
