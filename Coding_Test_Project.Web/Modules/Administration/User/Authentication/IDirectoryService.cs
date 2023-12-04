
namespace Coding_Test_Project;

public interface IDirectoryService
{
    AppServices.DirectoryEntry Validate(string username, string password);
}