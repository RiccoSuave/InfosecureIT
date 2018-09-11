using InfosecureIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InfosecureIT.Controllers
{
    public class ClientInquiriesController : Controller
    {
        // GET: ClientInquiries
        public ActionResult Index()
        {
            List<Client> NewClientInquirie = new List<Client>();
            Client firstClient = new Client();
            firstClient.FirstName = "Shahin";
            firstClient.LastName = "Ansari";
            firstClient.LastName = "571-549-1026";
            firstClient.Title = "Director, CEO";
            firstClient.PotentialProject = "We like to improve the security of our Web Services";
            NewClientInquirie.Add(firstClient);
            return View(NewClientInquirie);
        }
    }
}