using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using BabDI.Services;

namespace BabDI
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<ValuesService>().As<IValuesService>().InstancePerLifetimeScope();

        }
    }
}
