namespace Classes.JsonObjectApi
{
    public class JsonObjectViewModel
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
        public string Tags { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string DueDate { get; set; }
    }

    public static class JsonObjectViewModelStatic
    {
        public static string Id = "a84f6978-3c7c-4b48-9016-08f655bd8361";
        public static string Content = "is a string of text content";
        public static string CreatedData = "2011-10-05T14:48:00.000Z";
        public static string ModifiedDate = "2011-10-05T14:48:00.000Z";
        public static string Tags = "tag1, tag2, tag3";
        public static string Title = "is a string of text content";
        public static string Type = "is a string representing an item type";
        public static string DueDate = "2011-10-05T14:48:00.000Z";
    }
}