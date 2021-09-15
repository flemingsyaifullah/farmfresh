using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FarmFresh.ApplicationCore.Constants;
using FarmFresh.Web.Extensions;
using FarmFresh.Web.Services;
using FarmFresh.Web.ViewModels;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;

namespace FarmFresh.Web.Pages.Admin
{
    [Authorize(Roles = BlazorShared.Authorization.Constants.Roles.ADMINISTRATORS)]
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
           
        }
    }
}
