namespace Coding_Test_Project.Administration;


public class TranslationUpdateRequest : ServiceRequest
{
    public string TargetLanguageID { get; set; }
    public Dictionary<string, string> Translations { get; set; }
}