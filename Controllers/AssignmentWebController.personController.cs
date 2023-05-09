using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace AssignmentWeb.Controllers
{
    public partial class AssignmentWebController
    {
        public class personController : ApiController
        {
            [HttpPut]
            public void Put([FromBody] student s)
            {
            }

        }
}