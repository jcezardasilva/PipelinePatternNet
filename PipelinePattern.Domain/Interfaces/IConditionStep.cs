using PipelinePattern.Domain.Entities;

namespace PipelinePattern.Domain.Interfaces
{
    public interface IConditionStep : IStep<Context,Context>
    {
        public IConditionStep? GetNextCondition();
        public void SetNextCondition(IConditionStep nextCondition);
        public IConditionStep WithNext(IConditionStep nextCondition);
    }
}
