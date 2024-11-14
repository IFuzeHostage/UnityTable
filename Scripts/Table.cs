using System.Collections;
using System.Collections.Generic;
using IFuzeHostage.UnityTable.Data;
using UnityEngine;

public class Table : MonoBehaviour
{
    [SerializeField]
    private TableLine _linePrefab;
    [SerializeField] 
    private Transform _parent;
    
    private Dictionary<int, TableLine> _lines = new Dictionary<int, TableLine>();
    
    public void SetData(TableData data)
    {
        foreach (Transform child in _parent)
        {
            Destroy(child.gameObject);
        }
        _lines.Clear();
        
        foreach (var lineData in data.Lines)
        {
            var line = Instantiate(_linePrefab, _parent);
            line.SetData(lineData);
            _lines.Add(lineData.Id, line);
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
}
