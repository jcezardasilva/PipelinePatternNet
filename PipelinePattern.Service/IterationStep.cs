using PipelinePattern.Domain.Entities;
using PipelinePattern.Domain.Exceptions;
using PipelinePattern.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PipelinePattern.Core
{
    public class IterationStep<TCollection> : IStep<Context, Context>
    {
        private Pipeline<TCollection>? _pipeline;
        private IStep<Context, IEnumerable<TCollection>>? _collectionStep;
        public Context Process(Context input)
        {
            if(_collectionStep == null)
            {
                throw new StepException("Collection is null");
            }
            foreach(var item in _collectionStep.Process(input))
            {
                //add commands
                continue;
            }
            
            return new Context();
        }
        public IterationStep<TCollection> With(IStep<Context,IEnumerable<TCollection>> collectionStep)
        {
            _collectionStep = collectionStep;
            return this;
        }
    }
}
