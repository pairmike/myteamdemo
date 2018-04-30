using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTeamDemo.Models
{
    public class Agent
    {
        [Key]
        public String AgentId { get; set; }
        [Required]
        public String AgentCode { get; set; }
        public String Generation { get; set; }

        public string Name { get; set; }
        public string AgentLevel { get; set; }

        public String UplineCode { get; set; }
    }
}