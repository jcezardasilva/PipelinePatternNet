using PipelinePattern.Domain.Entities;
using PipelinePattern.Domain.Interfaces;

namespace PipelinePattern.Core.Steps
{
    public class ChangePersonEmailStep : IStep<KeyValuePair<string, string>, KeyValuePair<string, string>>
    {
        public KeyValuePair<string, string> Process(KeyValuePair<string, string> input)
        {
            return new KeyValuePair<string, string>("comercial",input.Value);
        }
    }
}