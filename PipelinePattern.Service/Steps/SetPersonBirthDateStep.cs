using PipelinePattern.Domain.Entities;
using PipelinePattern.Domain.Interfaces;

namespace PipelinePattern.Core.Steps
{
    public class SetPersonBirthDateStep : IStep<Context, Context>
    {
        public Context Process(Context input)
        {
            var person = (Person)input.Data[Person.PERSON];
            person.BirthDate = new DateTime(1987,8,18);
            input.Data.Remove(Person.PERSON);
            input.Data.Add(Person.PERSON, person);
            return input;
        }
    }
}