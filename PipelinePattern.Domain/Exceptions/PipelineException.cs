using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelinePattern.Domain.Exceptions
{
    public class StepException : Exception
    {
        public StepException() { } 
        public StepException(string message) : base(message) { }
        public StepException(string message,Exception innerException) : base(message, innerException) { }
    }
}
