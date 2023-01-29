
using PipelinePattern.Core;
using PipelinePattern.Core.Steps;
using PipelinePattern.Domain.Entities;
using System.Text.Json;

namespace PipelinePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var output = new Pipeline<Context>().Initialize(args)
                .Pipe(new InitializeContextStep())
                .Pipe(new CreatePersonStep())
                .Pipe(new SetPersonNameStep())
                .Pipe(new SetPersonBirthDateStep())
                .Pipe(new IsBirthDateSettedConditionStep()
                    .WithNext(new IsNotBirthDateSettedConditionStep())
                )
                .GetOutput();

            var example = output.Data[Person.PERSON];
            Console.WriteLine(JsonSerializer.Serialize(example));
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}