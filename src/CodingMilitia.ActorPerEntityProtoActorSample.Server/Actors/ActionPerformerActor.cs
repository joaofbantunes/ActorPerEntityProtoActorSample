using System;
using System.Threading.Tasks;
using CodingMilitia.ActorPerEntityProtoActorSample.Messages;
using Proto;

namespace CodingMilitia.ActorPerEntityProtoActorSample.Server.Actors
{
    public class ActionPerformerActor : IActor
    {
        private static Guid ActorServerInstanceGuid = Guid.NewGuid();
        private int _actionCounter = 0;
        private int _anotherActionCounter = 0;

        public Task ReceiveAsync(IContext context)
        {
            var message = context.Message;
            Console.WriteLine($"\"{context.Self.Id}\" on server {ActorServerInstanceGuid} received {message.GetType().Name}");
            switch (message)
            {
                case Started _:
                    Console.WriteLine($"Actor \"{context.Self.Id}\" started.");
                    //context.SetReceiveTimeout(TimeSpan.FromSeconds(1));
                    break;
                case ReceiveTimeout _:
                    Console.WriteLine($"Actor \"{context.Self.Id}\" timedout.");
                    //TODO: is there a way to terminate the actor execution after timeout?
                    break;
                case DoActionRequest doIt:
                    ++_actionCounter;
                    break;
                case DoAnotherActionRequest doTheOther:
                    ++_anotherActionCounter;
                    break;
                case QueryExecutedActionsRequest query:
                    context.Respond(new QueryExecutedActionsResponse
                    {
                        ActionCount = _actionCounter,
                        AnotherActionCount = _anotherActionCounter,
                        ServerId = ActorServerInstanceGuid.ToString()
                    });
                    break;
            }
            return Actor.Done;
        }
    }
}