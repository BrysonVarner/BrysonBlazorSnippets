using BrysonBlazorSnippets.Interfaces;
using BrysonBlazorSnippets.Models;

namespace BrysonBlazorSnippets.Repositories
{
    public class TestObjectRepository : ITestObjectRepository
    {
        public IEnumerable<TestObject> GetAllTestObjects()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<SomeForeignKeyObject> GetAllForeignKeyObjects()
        {
            throw new NotImplementedException();
        }
    }
}
