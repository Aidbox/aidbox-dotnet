using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;

namespace Aidbox.FHIR.Search;


public interface ISearchParameters {
    public string ToSearchString();
}


public class ResourceSearchParameters : ISearchParameters {
    public string? Content;
    public string? Id;
    public string? LastUpdated;
    public string? Profile;
    public string? Query;
    public string? Security;
    public string? Source;
    public string? Tag;

    public string ToSearchString()
    {
        FieldInfo[] fields = GetType().GetFields();

        var queryParams = HttpUtility.ParseQueryString(string.Empty);
        foreach (var field in fields)
        {
            var fieldName = HttpUtility.UrlEncode(PascalToKebabCase(field.Name));
            var fieldValue = HttpUtility.UrlEncode(Convert.ToString(field.GetValue(this)));

            if (fieldValue != "")
            {
                queryParams.Add(fieldName, fieldValue);
            }

        }

        return string.Join("&", queryParams);
    }

    private string PascalToKebabCase(string value)
    {
        return Regex.Replace(
            value,
            "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z0-9])",
            "-$1",
            RegexOptions.Compiled)
            .Trim()
            .ToLower();
    }
}
