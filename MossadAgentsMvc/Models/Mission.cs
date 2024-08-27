using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MossadAgentsMvc.Models
{
    public class Mission
    {
        [Key]
        public int Id { get; set; }
        public string? status { get; set; }
        public int agentId { get; set; }
        public Agent? agent { get; set; }
        public int targetId { get; set; }
        public Target? target { get; set; }

        public int? TimeToTarget { get; set; }
    }
}
