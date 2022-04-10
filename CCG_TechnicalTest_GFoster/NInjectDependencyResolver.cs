using Ninject.Modules;

namespace CCG_TechnicalTest_GFoster
{
    public class NinjectDependencyResolver : NinjectModule
    {
        public override void Load()
        {
            Bind<IConsoleManager>().To<ConsoleManager>();
            Bind<IProgramManager>().To<ProgramManager>();
        }
    }
}
