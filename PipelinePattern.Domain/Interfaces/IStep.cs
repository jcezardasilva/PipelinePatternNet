using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelinePattern.Domain.Interfaces
{
    public interface IStep<TIn,TOut>
    {
        public TOut Process(TIn input);
    }
}
