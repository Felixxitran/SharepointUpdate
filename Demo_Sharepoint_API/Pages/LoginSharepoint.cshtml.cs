using Demo_Sharepoint_API.Pages.REST;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Demo_Sharepoint_API.Pages
{
    public class LoginSharepointModel : PageModel
    {
        public void OnGet()
        {
        }
        public GetAccessToken tenantInfo = new GetAccessToken();
        public ActionResult OnPost() {
            tenantInfo.clientID = Request.Form["clientID"];
            tenantInfo.clientSecret = Request.Form["clientSecret"];
            tenantInfo.DomainSite = Request.Form["DomainSite"];
            tenantInfo.DocumentLibrary = "SeatechFiles";
            tenantInfo.FolderName = Request.Form["FolderName"];

            //connect to Sharepoint
            ConstructREST restClient = new ConstructREST();
            HTTPRest restHTTPClient = new HTTPRest();
            //restClient.getAccessToken(tenantInfo.clientID, tenantInfo.DomainSite, tenantInfo.clientSecret);
            string accessToken = restHTTPClient.getAccessToken(tenantInfo.clientID, tenantInfo.DomainSite, tenantInfo.clientSecret);

            restHTTPClient.createNewFolder(accessToken, tenantInfo.DomainSite, tenantInfo.DocumentLibrary,tenantInfo.FolderName);
            
            return Redirect("SharepointUI");
        }
    }
    public class GetAccessToken
    {
        public string clientID = "";
        public string clientSecret = " ";
        public string DomainSite = "";
        public string DocumentLibrary = "";
        public string FolderName = "";
    }
}
