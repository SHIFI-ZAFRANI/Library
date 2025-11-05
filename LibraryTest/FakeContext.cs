namespace library
{
    public class FakeContext:IDataContext
    {
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }
        public List<Category> Categories { get; set; }
        public FakeContext() { }
    }
}
