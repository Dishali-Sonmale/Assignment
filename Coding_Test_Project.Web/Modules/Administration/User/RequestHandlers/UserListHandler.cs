using MyRequest = Coding_Test_Project.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<Coding_Test_Project.Administration.UserRow>;
using MyRow = Coding_Test_Project.Administration.UserRow;

namespace Coding_Test_Project.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}