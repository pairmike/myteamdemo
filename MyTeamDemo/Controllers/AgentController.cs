using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;
using MyTeamDemo.Datasouce;

namespace MyTeamDemo.Controllers
{
    [EnableQuery]
    public class AgentController : ODataController
    {
        public IHttpActionResult Get()
        {
            return Ok(AgentDataSource.Instance.Agents.AsQueryable());
        }
    }
}
