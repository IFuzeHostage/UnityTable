using UnityEngine;

namespace ThirdParty.Plugins.UnityTable.Scripts.TableElement
{
    public abstract class TableElement : MonoBehaviour
    {
        public void SetWidth(float width)
        {
            var rectTransform = GetComponent<RectTransform>();
            rectTransform.sizeDelta = new Vector2(width, rectTransform.sizeDelta.y);
        }
    }
}