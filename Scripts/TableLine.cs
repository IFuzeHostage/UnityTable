using System.Collections;
using System.Collections.Generic;
using IFuzeHostage.UnityTable.Data;
using ThirdParty.Plugins.UnityTable.Scripts.TableElement;
using UnityEngine;
using UnityEngine.UIElements;

public class TableLine : MonoBehaviour
{
    [SerializeField] 
    private List<TableElement> _elements;
    
    public void SetData(TableLineData data)
    {
        for (int i = 0; i < _elements.Count; i++)
        {
            if(data.Elements.Count <= i)
            {
                Debug.LogError($"Table arguments less than expected {data.Elements.Count} <= {_elements.Count}");
                return;
            }
            
            var elementData = data.Elements[i];
            var element = _elements[i];
            
            //TODO: thats trash
            if (elementData is StringElementData textData && element is TextTableElement textElement)
            {
                textElement.SetData(textData);
            }
            else if (elementData is ImageElementData imageData && element is ImageTableElement imageElement)
            {
                imageElement.SetData(imageData);
            }
            else
            {
                Debug.LogError($"Table signature mismatch on element {i}");
            }
        }
    }
}
