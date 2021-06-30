using Grpc.Net.Client;
using GrpcService;
using GrpcService.Protos;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*            var input = new HelloRequest { Name = "Harshit Pradhan" };

                        var channel = GrpcChannel.ForAddress("https://localhost:5001");
                        var client = new Greeter.GreeterClient(channel);

                        var reply = await client.SayHelloAsync(input);

                        Console.WriteLine(reply.Message);*/

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var employeeClient = new RemoteEmployee.RemoteEmployeeClient(channel);
            var employeeInput = new EmployeeLookupModel { EmployeeId = 1 };
            var employeeReply = await employeeClient.GetEmployeeInfoAsync(employeeInput);
            Console.WriteLine($"{employeeReply.EmployeeName} {employeeReply.EmployeeProfile}");



            Console.ReadLine();
        }
    }
}
