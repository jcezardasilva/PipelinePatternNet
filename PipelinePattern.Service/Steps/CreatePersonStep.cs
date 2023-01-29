using PipelinePattern.Domain.Entities;
using PipelinePattern.Domain.Interfaces;

namespace PipelinePattern.Core.Steps
{
    public class CreatePersonStep : IStep<Context, Context>
    {
        public Context Process(Context input)
        {
            var person = new Person();
            input.Data.Add(Person.PERSON,person);
            return input;
        }
    }
}