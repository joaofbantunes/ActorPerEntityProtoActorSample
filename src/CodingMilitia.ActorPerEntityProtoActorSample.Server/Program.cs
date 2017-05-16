using System;
using CodingMilitia.ActorPerEntityProtoActorSample.Server.Actors;
using Proto;
using Proto.Cluster;
using Proto.Cluster.Consul;
using Proto.Remote;

namespace CodingMilitia.ActorPerEntityProtoActorSample.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Serialization.RegisterFileDescriptor(CodingMilitia.ActorPerEntityProtoActorSample.Messages.ProtosReflection.Descriptor);
            var props = Actor.FromProducer(() => new ActionPerformerActor());

            Remote.RegisterKnownKind("ActionPerformerKind", props);
            Remote.Start("127.0.0.1", 0);
            Cluster.Start("MyCluster", new ConsulProvider(new ConsulProviderOptions()));

            Console.WriteLine("Waiting...");
            Console.ReadLine();
        }
    }
}
