using Grpc.Core;
using GrpcService.Data;
using GrpcService.Protos;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Services
{
    public class EmployeesService : RemoteEmployee.RemoteEmployeeBase
    {
        private readonly ILogger<EmployeesService> _logger;
        private readonly EmployeeDbContext _context;

        public EmployeesService(ILogger<EmployeesService> logger, EmployeeDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public override Task<EmployeeModel> GetEmployeeInfo(EmployeeLookupModel request, ServerCallContext context)
        {
            EmployeeModel output = new EmployeeModel();

            var employee = _context.Employees.Find(request.EmployeeId);

            _logger.LogInformation("Sending Employee response");

            if (employee != null)
            {
                output.EmployeeId = employee.EmployeeId;
                output.EmployeeName = employee.EmployeeName;
                output.EmployeeEmail = employee.EmployeeEmail;
                output.EmployeeProfile = employee.EmployeeProfile;
            }

            return Task.FromResult(output);
        }
    }
}
