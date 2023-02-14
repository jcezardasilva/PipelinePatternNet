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
        private List<IStep<TCollection, TCollection>>? _steps;
        private IStep<Context, IEnumerable<TCollection>>? _collectionStep;

        public Context Process(Context input)
        {
            if(_collectionStep == null)
            {
                throw new StepException("Collection is null");
            }
            if(_steps == null)
            {
                throw new StepException("Steps is null");
            }

            var collection = _collectionStep.Process(input);
            List<TCollection> results = new List<TCollection>();
            for (var i = 0; i < collection.Count(); i++)
            {
                var item = collection.ElementAt(i);
                TCollection output;
                foreach(var step in _steps)
                {
                    item = step.Process(item);
                }
            }
            input.Data.Add("_results", results);
            return input;
        }
        public IterationStep<TCollection> With(IStep<Context,IEnumerable<TCollection>> collectionStep)
        {
            _collectionStep = collectionStep;
            return this;
        }
        public IterationStep<TCollection> Pipe(IStep<TCollection, TCollection> step)
        {
            _steps ??= new List<IStep<TCollection, TCollection>>();
            _steps.Add(step);
            return this;
        }
    }
}
