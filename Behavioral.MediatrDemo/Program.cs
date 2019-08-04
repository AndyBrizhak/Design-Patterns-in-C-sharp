using System;
using System.Threading.Tasks;
using Autofac;
//using DotNetDesignPatternDemos.Annotations;
using MediatR;

namespace MediatrDemo
{
  public class Demo
  {
    public static async Task Main()
    {
      var builder = new ContainerBuilder();
      builder.RegisterType<Mediator>()
        .As<IMediator>()
        .InstancePerLifetimeScope(); // singleton

      builder.Register<ServiceFactory>(context =>
      {
        var c = context.Resolve<IComponentContext>();
        return t => c.Resolve(t);
      });

      builder.RegisterAssemblyTypes(typeof(Demo).Assembly)
        .AsImplementedInterfaces();

      var container = builder.Build();
      var mediator = container.Resolve<IMediator>();
      var response = await mediator.Send(new PingCommand());
      Console.WriteLine($"We got a pong at {response.Timestamp}");
    }
  }
}