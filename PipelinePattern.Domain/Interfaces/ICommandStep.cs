using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelinePattern.Domain.Interfaces
{
    public interface ICommandStep<TIn,TOut> : IStep<TIn, TOut>
    {
        public IList<IStep<TIn, TOut>> GetSteps();
        public void SetSteps(IList<IStep<TIn, TOut>> steps);
        public ICommandStep<TIn,TOut> AddStep(IStep<TIn,TOut> step)
        {
            var steps = GetSteps();
            if(steps == null)
            {
                steps = new List<IStep<TIn,TOut>>();
                SetSteps(steps);
            }
            steps.Add(step);
            return this;
        }
    }
}
