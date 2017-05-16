using System;
using System.Threading;
using System.Threading.Tasks;
using CodingMilitia.ActorPerEntityProtoActorSample.Messages;
using Proto.Cluster;
using Proto.Cluster.Consul;
using Proto.Remote;

namespace CodingMilitia.ActorPerEntityProtoActorSample.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            Serialization.RegisterFileDescriptor(CodingMilitia.ActorPerEntityProtoActorSample.Messages.ProtosReflection.Descriptor);
            Remote.Start("127.0.0.1", 0);
            Cluster.Start("MyCluster", new ConsulProvider(new ConsulProviderOptions()));

            string input;
            Console.WriteLine("Enter the name of an actor and: 1 for Action to be performed; 2 AnotherAction to be performed; 3 a query on the performed actions.");
            while (!(input = Console.ReadLine().ToLower()).Equals("exit"))
            {
                var splitInput = input.Split(' ');
                var pid = await Cluster.GetAsync(splitInput[0], "ActionPerformerKind");
                switch (int.Parse(splitInput[1]))
                {
                    case 1:
                        pid.Tell(new DoActionRequest());
                        break;
                    case 2:
                        pid.Tell(new DoAnotherActionRequest());
                        break;
                    case 3:
                        var response = await pid.RequestAsync<QueryExecutedActionsResponse>(new QueryExecutedActionsRequest());
                        Console.WriteLine($"Actor {pid.Id} on server {response.ServerId} has executed an Action {response.ActionCount} times and AnotherAction {response.AnotherActionCount} times.");
                        break;
                }
            }
        }
    }
}
