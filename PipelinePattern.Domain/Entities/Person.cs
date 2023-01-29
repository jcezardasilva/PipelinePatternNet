using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelinePattern.Domain.Entities
{
    public class Person
    {
        public const string PERSON = "person";
        public string? Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age { get; set; }
    }
}
