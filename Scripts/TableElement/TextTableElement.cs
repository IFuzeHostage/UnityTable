using IFuzeHostage.UnityTable.Data;
using TMPro;
using UnityEngine;

namespace ThirdParty.Plugins.UnityTable.Scripts.TableElement
{
    public class TextTableElement : TableElement
    {
        [SerializeField]
        private TextMeshProUGUI _text;

        public void SetData(StringElementData data)
        {
            _text.text = data.Content;
        }
    }
}