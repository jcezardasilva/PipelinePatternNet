using PipelinePattern.Domain.Entities;
using PipelinePattern.Domain.Interfaces;

namespace PipelinePattern.Core.Steps
{
    public class IsBirthDateSettedConditionStep : IConditionStep
    {
        private IConditionStep? nextCondition;
        public IConditionStep? GetNextCondition()
        {
            return nextCondition;
        }

        public Context Process(Context input)
        {
            var person = (Person)input.Data[Person.PERSON];
            if(person.BirthDate!= null)
            {
                person.Age = (int)((DateTime.Now - person.BirthDate).Value.TotalDays / 365.2425);
                input.Data.Remove(Person.PERSON);
                input.Data.Add(Person.PERSON, person);
                return input;
            }

            if(nextCondition != null)
            {
                nextCondition.Process(input);
            }
            return input;
        }

        public void SetNextCondition(IConditionStep nextCondition)
        {
            this.nextCondition = nextCondition;
        }

        public IConditionStep WithNext(IConditionStep nextCondition)
        {
            var next = GetNextCondition();
            if (next == null)
            {
                SetNextCondition(nextCondition);
            }
            else
            {
                next.WithNext(nextCondition);
            }
            return this;
        }
    }
}
