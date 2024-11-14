using IFuzeHostage.UnityTable.Data;
using UnityEngine;
using UnityEngine.UI;

namespace ThirdParty.Plugins.UnityTable.Scripts.TableElement
{
    public class ImageTableElement : TableElement
    {
        [SerializeField]
        private Image _image;
        
        public void SetData(ImageElementData data)
        {
            _image.sprite = data.Content;
        }
    }
}