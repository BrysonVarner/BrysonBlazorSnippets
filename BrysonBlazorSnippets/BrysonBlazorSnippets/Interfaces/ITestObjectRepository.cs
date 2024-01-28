using BrysonBlazorSnippets.Models;

namespace BrysonBlazorSnippets.Interfaces
{
    public interface ITestObjectRepository
    {
        //This is just to simulate a repository layer for now as it is not needed for this sample to have a Database

        public IEnumerable<TestObject> GetAllTestObjects();
        public IEnumerable<SomeForeignKeyObject> GetAllForeignKeyObjects();
    }
}
