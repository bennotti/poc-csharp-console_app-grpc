using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;

namespace SampleProjectGrpcClient
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Grpc.Core.Channel channel = new Grpc.Core.Channel("127.0.0.1", 5000, ChannelCredentials.Insecure);
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
