using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelinePattern.Domain.Exceptions
{
    public class PipelineException : Exception
    {
        public PipelineException() { } 
        public PipelineException(string message) : base(message) { }
        public PipelineException(string message,Exception innerException) : base(message, innerException) { }
    }
}
