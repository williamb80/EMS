using EMS.Framework.Core.DependencyInjection;
using System;
using System.Data.Entity;
using System.Web;

namespace EMS.Framework.Core.Context
{
    public class ContextManager : IContextManager
    {
        private string _contextKey = "ContextManager.Context";

        public ContextManager()
        {
            Type dbContext = ContainerFactory.Get<IDbContext>().GetType();
            _contextKey = "ContextKey." + dbContext.Name;
        }

        public DbContext GetContext()
        {
            if (HttpContext.Current.Items[_contextKey] == null)
                HttpContext.Current.Items[_contextKey] = ContainerFactory.Get<IDbContext>();
            return HttpContext.Current.Items[_contextKey] as DbContext;
        }

        public void Finish()
        {
            if (HttpContext.Current.Items[_contextKey] != null)
                (HttpContext.Current.Items[_contextKey] as IDbContext).Dispose();
        }
    }
}
