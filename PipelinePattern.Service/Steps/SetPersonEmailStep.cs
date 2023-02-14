using PipelinePattern.Domain.Entities;
using PipelinePattern.Domain.Interfaces;

namespace PipelinePattern.Core.Steps
{
    public class SetPersonEmailStep : IStep<Context, Context>
    {
        public Context Process(Context input)
        {
            var person = (Person)input.Data[Person.PERSON];
            person.Emails.Add(new KeyValuePair<string, string>("personal", "jcezardasilva@outlook.com"));
            person.Emails.Add(new KeyValuePair<string, string>("personal", "jcezardasilva@hotmail.com"));
            person.Emails.Add(new KeyValuePair<string, string>("personal", "jcezardasilva@gmail.com"));
            person.Emails.Add(new KeyValuePair<string, string>("personal", "jcesardasilva@gmail.com"));
            input.Data.Remove(Person.PERSON);
            input.Data.Add(Person.PERSON, person);
            return input;
        }
    }
}