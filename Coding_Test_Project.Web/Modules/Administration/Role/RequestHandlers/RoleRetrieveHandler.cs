using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Coding_Test_Project.Administration.RoleRow>;
using MyRow = Coding_Test_Project.Administration.RoleRow;


namespace Coding_Test_Project.Administration;
public interface IRoleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
{
    public RoleRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}