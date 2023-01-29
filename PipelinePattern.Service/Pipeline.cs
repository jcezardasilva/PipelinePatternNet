using PipelinePattern.Domain.Exceptions;
using PipelinePattern.Domain.Interfaces;

namespace PipelinePattern.Core
{
    public class Pipeline<T>
    {
        private T? input;

        public Pipeline()
        {
        }

        public Pipeline(T input)
        {
            this.input = input;
        }
        
        public Pipeline<TIn> Initialize<TIn>(TIn i)
        {
            return new Pipeline<TIn>(i);
        }

        public Pipeline<TOut> Pipe<TOut>(IStep<T, TOut> next)
        {
            if (input == null)
            {
                throw new PipelineException("The pipeline input is null");
            }
            return new Pipeline<TOut>(next.Process(input));
        }

        public T GetOutput()
        {
            if(input == null)
            {
                throw new PipelineException("The pipeline input is null");
            }
            return input;
        }
    }
}
