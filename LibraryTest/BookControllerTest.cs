using library;
using library.Controllers;
using Microsoft.Extensions.Logging;

namespace LibraryTest
{
    public class BookControllerTest
    {
        private readonly FakeContext fakeContext = new FakeContext();
        [Fact]
        public void Get_ReturnList()
        {
            var controller = new BookControlle(fakeContext);
            var result = controller.Get();
            Assert.IsType<List<Book>>(result);

        }
    }
}