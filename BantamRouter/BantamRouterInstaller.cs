using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace BantamRouter
{
    [RunInstaller(true)]
    public class BantamRouterInstaller : Installer
    {
            // Provide the ProjectInstaller class which allows the service to be installed by the Installutil.exe tool
            private ServiceProcessInstaller process;
            private ServiceInstaller service;

            public BantamRouterInstaller()
            {
                process = new ServiceProcessInstaller();
                process.Account = ServiceAccount.LocalSystem;
                service = new ServiceInstaller();
                service.ServiceName = "BantamRouterSVC";
                Installers.Add(process);
                Installers.Add(service);
            }
    }
}
