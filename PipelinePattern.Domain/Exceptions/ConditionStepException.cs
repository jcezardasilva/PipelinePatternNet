using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelinePattern.Domain.Exceptions
{
    public class ConditionStepException : StepException
    {
        public ConditionStepException() { } 
        public ConditionStepException(string message) : base(message) { }
        public ConditionStepException(string message,Exception innerException) : base(message, innerException) { }
    }
}
