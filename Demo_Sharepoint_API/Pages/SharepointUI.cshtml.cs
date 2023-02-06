using Demo_Sharepoint_API.Pages.REST;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace Demo_Sharepoint_API.Pages
{
    public class SharepointUIModel : PageModel
    {
        public void OnGet()
        {
        }
        public ActionResult TransferAll() {
            /*//connect to Sharepoint
            ConstructREST restClient = new ConstructREST();
            HTTPRest restHTTPClient = new HTTPRest();
            //restClient.getAccessToken(tenantInfo.clientID, tenantInfo.DomainSite, tenantInfo.clientSecret);
            string accessToken = restHTTPClient.getAccessToken(tenantInfo.clientID, tenantInfo.DomainSite, tenantInfo.clientSecret);
            //restClient.getAccessTokenWithHTTP(tenantInfo.clientID, tenantInfo.DomainSite, tenantInfo.clientSecret);
            //return RedirectToPage("Index");
            restHTTPClient.createNewFolder(accessToken, tenantInfo.DomainSite, tenantInfo.FolderName);
            return Redirect("Success");*/
            return Redirect("Success");
        }
    }
}
