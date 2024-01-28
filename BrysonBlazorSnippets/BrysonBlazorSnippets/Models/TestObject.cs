namespace BrysonBlazorSnippets.Models
{
    public class TestObject
    {
        public TestObject() { }

        public TestObject(int id, string name, int imageId, string region) 
        {
            Id = id;
            Name = name;
            ImageId = imageId;
            Region = region;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ImageId { get; set; }
        public string Region { get; set; }
    }
}
