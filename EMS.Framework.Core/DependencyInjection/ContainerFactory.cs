using Microsoft.Practices.ServiceLocation;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonServiceLocator.NinjectAdapter.Unofficial;
using Ninject.Activation;

namespace EMS.Framework.Core.DependencyInjection
{
    public class ContainerFactory
    {
        private static IKernel kernel;

        public static void Setup()
        {
            kernel = new StandardKernel();
            //kernel.Load(@"~\Container\ContainerDependencyInjection.xml");
            //bool teste = kernel.HasModule("myXmlConfigurationModule");
        }

        public static void Bind<TInterface, TImplementation>()
        {
            ValidateContainer();
            kernel.Bind<TInterface, TImplementation>().To(typeof(TImplementation));
        }

        public static void Bind<TInterface, TImplementation, TInjected>()
        {
            ValidateContainer();
            kernel.Bind<TInterface>().To(typeof(TImplementation)).WhenInjectedInto(typeof(TInjected));
        }

        public static void Bind<TInterface>(Func<IContext, TInterface> method)
        {
            ValidateContainer();
            kernel.Bind<TInterface>().ToMethod(method);
        }

        public static object Get(Type type)
        {
            ValidateContainer();
            return kernel.Get(type);
        }

        /// <summary>
        /// Retorna uma instância do tipo informado, obtendo a instância
        /// do container de IoC (Ninject)
        /// </summary>
        /// <typeparam name="T">O tipo do objeto a ser retornado</typeparam>
        /// <returns>Uma instância do tipo informado</returns>
        public static T Get<T>()
        {
            ValidateContainer();
            return kernel.Get<T>();
        }

        public static void Inject(object instance)
        {
            ValidateContainer();
            kernel.Inject(instance);
        }

        private static void ValidateContainer()
        {
            if (kernel == null)
            {
                throw new InvalidOperationException("O container não foi inicializado. Execute o método DependencyInjectionContainer.Setup() antes de utilizar o container");
            }
        }
    }
}