using System;
using grpc;
using Grpc.Core;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            var port = 10000;
            var channel = new Channel($"localhost:{port}", ChannelCredentials.Insecure);
            var client = new Greeter.GreeterClient(channel);
            for(var i = 0; i < 105; i++)
            {
                try
                {
                    client.SayHello(new HelloRequest()
                    {
                        Name = "world"
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
