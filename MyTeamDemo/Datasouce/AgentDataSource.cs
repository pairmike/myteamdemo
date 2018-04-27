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
                    AgentLevel = "70"


                },
                new Agent()
                {
                    AgentId = "42LYQ",
                    AgentCode = "42LYQ",
                    Generation = "0",
                     Name= "ALTAS",
                    AgentLevel = "70"


                },
                new Agent()
                {
                    AgentId = "25MIU",
                    AgentCode = "25MIU",
                    Generation = "0",
                     Name= "AMINDALAN",
                    AgentLevel = "70"


                },
                new Agent()
                {
                    AgentId = "23ECH",
                    AgentCode = "23ECH",
                    Generation = "0",
                     Name= "EMMANUEL KWAME",
                    AgentLevel = "70"


                }

            });
        }
    }
}