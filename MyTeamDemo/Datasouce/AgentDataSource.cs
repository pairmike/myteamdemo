using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyTeamDemo.Models;

namespace MyTeamDemo.Datasouce
{
    public class AgentDataSource
    {

        private static AgentDataSource instance = null;

        public static AgentDataSource Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AgentDataSource();
                }
                return instance;
            }
        }

        public List<Agent> Agents { get; set; }

        private AgentDataSource()
        {
            this.Reset();
            this.Initialize();
        }


        public void Reset()
        {
            this.Agents = new List<Agent>();

        }

        public void Initialize()
        {
            this.Agents.AddRange(new List<Agent>
            {
                new Agent()
                {
                    AgentId = "32KEQ",
                    AgentCode = "32KEQ",
                    Generation = "0",
                    Name= "ALMAZAN",
                    AgentLevel = "70",
                    UplineCode = "1200W"


                },
                new Agent()
                {
                    AgentId = "42LYQ",
                    AgentCode = "42LYQ",
                    Generation = "0",
                    Name= "ALTAS",
                    AgentLevel = "70",
                    UplineCode = "1200W"


                },
                new Agent()
                {
                    AgentId = "25MIU",
                    AgentCode = "25MIU",
                    Generation = "0",
                    Name= "AMINDALAN",
                    AgentLevel = "70",
                    UplineCode = "1200W"


                },
                new Agent()
                {
                    AgentId = "4412M",
                    AgentCode = "4412M",
                    Generation = "0",
                    Name= "JAMES JONES",
                    AgentLevel = "70",
                    UplineCode = "1200W"


                },
                new Agent()
                {
                    AgentId = "1231Q",
                    AgentCode = "1231Q",
                    Generation = "0",
                    Name= "MARK JOHSON",
                    AgentLevel = "70",
                    UplineCode = "780AM"


                },
                new Agent()
                {
                    AgentId = "003ACC",
                    AgentCode = "003ACC",
                    Generation = "0",
                    Name= "PENNY OI",
                    AgentLevel = "70",
                    UplineCode = "780AM"


                },
                new Agent()
                {
                    AgentId = "5139P",
                    AgentCode = "5139P",
                    Generation = "0",
                    Name= "RICH THAWLEY",
                    AgentLevel = "70",
                    UplineCode = "780AM"


                }

            });
        }
    }
}