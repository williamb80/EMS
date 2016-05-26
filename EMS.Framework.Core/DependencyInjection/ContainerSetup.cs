using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.DependencyInjection
{
    public class ContainerSetup
    {
        /// <summary>
        /// Declarações
        /// </summary>
        private static Boolean configured;

        /// <summary>
        /// Verifica necessidade de reconfiguração
        /// </summary>
        public static void Reconfigure()
        {
            configured = false;
            Configure();
        }

        /// <summary>
        /// Configura o container
        /// </summary>
        public static void Configure()
        {
            if (!configured)
            {

                ContainerFactory.Setup();
                configured = true;

                #region FullBind

                new BaseRegisterDependencyInjection().Configure();

                #endregion
            }
        }

    }
}
