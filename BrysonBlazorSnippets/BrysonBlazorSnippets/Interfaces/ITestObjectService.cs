using BrysonBlazorSnippets.Models;

namespace BrysonBlazorSnippets.Interfaces
{
    public interface ITestObjectService
    {
        public Task<List<TestObject>> GetAllTestObjects();
        public Task<List<SomeForeignKeyObject>> GetAllForeignKeyObjects();
    }
}
