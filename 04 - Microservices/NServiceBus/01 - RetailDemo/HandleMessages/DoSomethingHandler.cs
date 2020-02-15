using Commands;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HandleMessages
{
    public class DoSomethingHandler :
       IHandleMessages<DoSomethingCommand>,
       IHandleMessages<DoSomethingComplexCommand>
    {
        public Task Handle(DoSomethingCommand message, IMessageHandlerContext context)
        {
            Console.WriteLine("Received DoSomething");
            return Task.CompletedTask;
        }

        public Task Handle(DoSomethingComplexCommand message, IMessageHandlerContext context)
        {
            Console.WriteLine("Received DoSomethingComplex");
            return Task.CompletedTask;
        }
    }
}
