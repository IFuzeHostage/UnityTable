namespace IFuzeHostage.UnityTable.Data
{
    public class StringElementData : ITableElementData
    {
        public string Content { get; }
        
        public StringElementData(string content)
        {
            Content = content;
        }
    }
}