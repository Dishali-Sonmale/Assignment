using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Coding_Test_Project.Administration.LanguageRow>;
using MyRow = Coding_Test_Project.Administration.LanguageRow;


namespace Coding_Test_Project.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
{
    public LanguageListHandler(IRequestContext context)
         : base(context)
    {
    }
}