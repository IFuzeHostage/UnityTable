using UnityEngine;

namespace IFuzeHostage.UnityTable.Data
{
    public class ImageElementData : ITableElementData
    {
        public Sprite Content { get; }
        
        public ImageElementData(Sprite content)
        {
            Content = content;
        }
    }
}