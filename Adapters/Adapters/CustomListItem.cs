namespace Adapters
{
    public class CustomListItem
    {
        public string title { get; set; }
        public string description { get; set; }
        public int image { get; set; }

        public CustomListItem(string title, string description, int image)
        {
            this.title = title;
            this.description = description;
            this.image = image;
        }
        
    }
}