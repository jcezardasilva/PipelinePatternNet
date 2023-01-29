using PipelinePattern.Domain.Entities;
using PipelinePattern.Domain.Interfaces;

namespace PipelinePattern.Core.Steps
{
    public class SetPersonNameStep : IStep<Context, Context>
    {
        public Context Process(Context input)
        {
            var person = (Person)input.Data[Person.PERSON];
            person.Name = "julio cezar da silva";
            input.Data.Remove(Person.PERSON);
            input.Data.Add(Person.PERSON, person);
            return input;
        }
    }
}