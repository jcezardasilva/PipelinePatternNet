using PipelinePattern.Domain.Entities;
using PipelinePattern.Domain.Interfaces;

namespace PipelinePattern.Core.Steps
{
    public class InitializeContextStep : IStep<string[], Context>
    {
        public Context Process(string[] input)
        {
            var context = new Context();
            context.Data.Add("programArgs", input);
            return context;
        }
    }
}
