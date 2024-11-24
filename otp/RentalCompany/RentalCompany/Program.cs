using RentalCompany.Repositories;
using RentalCompany.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

namespace RentalCompany
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormRentalCompany>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<ISellerRepository, SellerRepository>(
                new TransientLifetimeManager()
            );
            container.RegisterType<IClientRepository, ClientRepository>(
                new TransientLifetimeManager()
            );
            container.RegisterType<IProductRepository, ProductRepository>(
                new TransientLifetimeManager()
            );
            container.RegisterType<IReceiptRepository, ReceiptRepository>(
                new TransientLifetimeManager()
            );
            container.RegisterType<IProductReturnRepository, ProductReturnRepository>(
                new TransientLifetimeManager()
            );

            return container;
        }
    }
}
