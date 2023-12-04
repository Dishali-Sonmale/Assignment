using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Coding_Test_Project.Administration.RoleRow>;
using MyRow = Coding_Test_Project.Administration.RoleRow;


namespace Coding_Test_Project.Administration;
public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    public RoleListHandler(IRequestContext context)
         : base(context)
    {
    }
}