using Autofac;
using Autofac.Integration.Mvc;
using IRepository;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1
{
    public class AutofacConfig
    {
        /// <summary>
        /// 负责调用autofac框架实现业务逻辑层和数据仓储层程序集中的类型对象的创建
        /// 负责创建MVC控制器类的对象(调用控制器中的有参构造函数)
        /// </summary>
        public static void Register()
        {
            ContainerBuilder builder = new ContainerBuilder();
            SetupResolveRules(builder); 
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
        /// <summary>
        /// 所有需要注入的类型
        /// </summary>
        /// <param name="builder"></param>
        private static void SetupResolveRules(ContainerBuilder builder)
        {
            builder.RegisterType<StudentRepository>().As<IStudentRepository>();
        }
    }

}