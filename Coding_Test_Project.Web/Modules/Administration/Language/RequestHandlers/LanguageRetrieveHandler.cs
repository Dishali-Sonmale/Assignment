using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Coding_Test_Project.Administration.LanguageRow>;
using MyRow = Coding_Test_Project.Administration.LanguageRow;


namespace Coding_Test_Project.Administration;
public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageRetrieveHandler
{
    public LanguageRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}