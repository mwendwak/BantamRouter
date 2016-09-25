using BantamRouter.Managers;
using System.ServiceProcess;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections.Generic;
using BantamRouter.Models;
using BantamRouter.Faces;

namespace BantamRouter
{
    public class BantamRouterService : ServiceBase, IBantamRouterEmployees
    {
        public ServiceHost serviceHost = null;
        public EmployeeManager NavEmployeeManager = new EmployeeManager();

        public BantamRouterService()
        {
            ServiceName = "BantamRouterSVC";
        }

        public static void Main()
        {
            ServiceBase.Run(new BantamRouterService());
        }

        // Start the Windows service.
        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            // Create a ServiceHost for the CalculatorService type and 
            // provide the base address.
            serviceHost = new ServiceHost(typeof(BantamRouterService));

            // Open the ServiceHostBase to create listeners and start 
            // listening for messages.
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }

        public List<Employee> GetNavActiveEmployees()
            {
                List<Employee> allEmployees = new List<Employee>();
                allEmployees = NavEmployeeManager.getAllActiveEmpoyees();
                return allEmployees;
            }


    }
}
