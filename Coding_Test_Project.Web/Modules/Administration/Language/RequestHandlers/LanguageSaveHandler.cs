using MyRequest = Serenity.Services.SaveRequest<Coding_Test_Project.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Coding_Test_Project.Administration.LanguageRow;


namespace Coding_Test_Project.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}