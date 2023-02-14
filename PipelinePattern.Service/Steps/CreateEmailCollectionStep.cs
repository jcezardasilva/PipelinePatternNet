using PipelinePattern.Domain.Entities;
using PipelinePattern.Domain.Interfaces;

namespace PipelinePattern.Core.Steps
{
    public class CreateEmailCollectionStep : IStep<Context, IEnumerable<KeyValuePair<string, string>>>
    {
        public IEnumerable<KeyValuePair<string, string>> Process(Context input)
        {
            return ((Person)input.Data[Person.PERSON]).Emails;
        }
    }
}