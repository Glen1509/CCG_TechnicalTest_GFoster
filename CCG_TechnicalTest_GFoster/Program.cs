using Ninject;
using System.Reflection;

namespace MyConsoleApp
{
    class Program
    {
        private static CCG_TechnicalTest_GFoster.IProgramManager? m_ProgramManager = null;

        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            m_ProgramManager = kernel.Get<CCG_TechnicalTest_GFoster.IProgramManager>();
            m_ProgramManager.Run();
        }
    }
}