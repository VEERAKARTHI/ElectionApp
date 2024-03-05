using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionApp.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
    }
}
