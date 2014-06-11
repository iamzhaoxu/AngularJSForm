using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularJSForm.Models;
using AngularJSForm.Models.DBContexts;

namespace AngularJSForm.Controllers.api
{
    public class LoginController : ApiController
    {
        LoginContext _ctx = new LoginContext();
        // GET api/login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/login
        public HttpResponseMessage Post(UserViewModel userVM)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, ModelState);
                }

                bool userExist = _ctx.Users.Any(u => u.UserName == userVM.UserName);
                if (!userExist)
                {
                    UserModel user = _ctx.Entry(userVM.ToModle()).Entity;
                    user.UserID = Guid.NewGuid();
                    _ctx.Users.Add(user);
                    _ctx.SaveChanges();
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new Exception("User has already exited"));
                }
                var response = Request.CreateResponse(HttpStatusCode.OK, userVM);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = userVM.UserID }));
                return response;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        // PUT api/login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/login/5
        public void Delete(int id)
        {
        }
    }
}
