using System;

namespace EMS.Framework.Core.DependencyInjection
{
    public abstract class ContainerSetup
    {
        /// <summary>
        /// Declarações
        /// </summary>
        private Boolean configured;

        /// <summary>
        /// Verifica necessidade de reconfiguração
        /// </summary>
        public void Reconfigure()
        {
            configured = false;
            Configure();
        }

        /// <summary>
        /// Configura o container
        /// </summary>
        public void Configure()
        {
            if (!configured)
            {

                ContainerFactory.Setup();
                configured = true;

                #region FullBind

               ConfigureBinds();
                    
                #endregion
            }
        }

        public abstract void ConfigureBinds();

    }
}
