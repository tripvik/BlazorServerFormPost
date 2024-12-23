using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorApp3
{
    [IgnoreAntiforgeryToken]
    public class HostPageModel : PageModel
    {
        private readonly PostFormService _postFormService;

        public static List<string> PostComponentPages = new List<string>() { "index", "/" };

        public HostPageModel(PostFormService postFormService)
        {
            _postFormService = postFormService;
        }

        public void OnPost()
        {
            if (PostComponentPages.Any(c => Request.Path.ToString().ToLower().Contains(c)))
            {
                if (string.Equals(Request.ContentType, "application/x-www-form-urlencoded", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(Request.ContentType, "multipart/form-data", StringComparison.OrdinalIgnoreCase))
                {
                    _postFormService.Form = Request.Form;
                }
            }
            else
            {
                throw new Exception("HTTP 401 Error - Unauthorized");
            }
        }
    }
}
