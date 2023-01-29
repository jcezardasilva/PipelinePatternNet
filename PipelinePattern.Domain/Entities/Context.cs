using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelinePattern.Domain.Entities
{
    public class Context
    {
        public IDictionary<string, object> Data { get; set; } = new Dictionary<string, object>();
    }
}
