using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SocialFly.Models;

namespace SocialFly.Controllers
{
    public class ConnectController : Controller
    {
        SocialBEntities db = new SocialBEntities();
        // GET: Connect
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetByFilter()
        {
            ConnectModel looking = new ConnectModel();

            SocialBEntities db = new SocialBEntities();
            looking.Followers = db.Followers.ToList();
            looking.Regions = db.Regions.ToList();
            looking.Compensation = db.Compensations.ToList();

             return View(looking);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetByFilter(FormCollection form)
        {
            string reg = form["Region"].ToString();
            string fol = form["Follower"].ToString();
            string com = form["Compensation"].ToString();

            return RedirectToAction("GetUsers", new { rid = reg, fid = fol, cid = com} );
        }

        public ActionResult GetUsers(string rid, string fid, string cid)
        {
            ConnectModel looking = new ConnectModel();

            var socialUsers = from su in db.SocialUsers
                              select su;
            var filteredUsers = socialUsers;

            int tempRId = Convert.ToInt32(rid);
            if (rid != null)
                filteredUsers = socialUsers.Where(s => s.RegionId == tempRId);

            //if (fid != null)
            //    filteredUsers = socialUsers.Where(s => s.FollowerCountId == Convert.ToInt32(fid));

            //if (cid != null)
            //    filteredUsers = socialUsers.Where(s => s.CompId == Convert.ToInt32(cid));

            return View(filteredUsers);
        }
    }
}