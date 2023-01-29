using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelinePattern.Domain.Interfaces
{
    public interface IPipeline<T>
    {
        public IPipeline<TIn> Initialize<TIn>(TIn input);
        public IPipeline<TOut> Pipe<TOut>(IStep<T,TOut> next);
        public T GetOutput();
    }
}
