using Autofac;
using System;
using System.Reflection;
using DIDemoLibrary;
using DIDemoLibrary.Utilities;
using System.Linq;

namespace DependencyInjectsionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // you need a container configure to configure all type and interface
            var container = ConfigureContainer();
            //IBusinessLogic businessLogic = new BusinessLogic(new Logger(), new DataAccess());
            //var businessLogic = container.Resolve<IBusinessLogic>();
            //businessLogic.ProessData();

            //auto fac how to begin scope? what's the use of scope?
            using(var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadKey();
        }

        static IContainer ConfigureContainer()
        {
            // initial a containerbuilder
            var builder = new ContainerBuilder();

            // register type
            // you also can use other methods to create a instance of class for whole project
            // if you have a BetterBusinessLogic, just change it here , no other palces need to be changed
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<Application>().As<IApplication>();

            //register as yourself
            //builder.RegisterType<Application>().AsSelf();
            //builder.RegisterType<Application>()；
            
            //builder.RegisterType<Logger>().As<ILogger>();
            //builder.RegisterType<DataAccess>().As<IDataAccess>();


            // If you have plenty of classes and you already move all class files to uitilies folder
            // you can use Assembly register right?
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DIDemoLibrary)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            //builder.RegisterInstance(new Logger())
            //    .As<ILogger>();
            //builder.RegisterInstance(new DataAccess())
            //    .As<IDataAccess>();
            //builder.RegisterInstance(new BusinessLogic())
            //    .As<IBusinessLogic>();


            // store key value paralist
            var container = builder.Build();

            return container;
        }
    }
}
