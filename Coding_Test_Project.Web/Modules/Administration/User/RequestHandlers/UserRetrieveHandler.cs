using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Coding_Test_Project.Administration.UserRow>;
using MyRow = Coding_Test_Project.Administration.UserRow;


namespace Coding_Test_Project.Administration;
public interface IUserRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class UserRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUserRetrieveHandler
{
    public UserRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}