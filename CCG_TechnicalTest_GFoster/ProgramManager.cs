using ChoETL;

namespace CCG_TechnicalTest_GFoster
{
    public class ProgramManager : ProgramManagerBase
    {
        private readonly IConsoleManager m_ConsoleManager;

        public ProgramManager(IConsoleManager consoleManager)
        {
            m_ConsoleManager = consoleManager;
        }

        public override void Run()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MenuOptions();
            }
        }

        static bool MenuOptions()
        {
            // Menu options could be handled differently, potentially as a list.

            Console.Clear();
            Console.WriteLine("Cloud Commerce Group - Simple File input & Conversion - Test - G Foster");
            Console.WriteLine("\r\nChoose an option:");
            Console.WriteLine("\r\n1) CSV To JSON");
            Console.WriteLine("2) CSV To XML");
            Console.WriteLine("\r\n3) JSON To CSV");
            Console.WriteLine("4) XML To CSV");
            Console.WriteLine("\r\n5) XML To JSON");
            Console.WriteLine("6) JSON To XML");
            Console.WriteLine("\r\n7) Convert From Database!");
            Console.WriteLine("\r\n8) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\n\rType in path & filename for source csv");
                    var fileSource = Console.ReadLine();
                    Console.WriteLine("The file path for import as entered is: " + fileSource);
                    Console.WriteLine("\n\r");
                    CSVToJSON();
                    return true;
                case "2":
                    CSVToXML();
                    return true;
                case "3":
                    JSONToCSV();
                    return true;
                case "4":
                    XMLToCSV();
                    return true;
                case "5":
                    XMLToJSON();
                    return true;
                case "6":
                    JSONToXML();
                    return true;
                case "7":
                    bool showMenu = true;
                    while (showMenu)
                    {
                        showMenu = DataBaseMenuOptions();
                    }
                    return true;
                case "8":
                    Console.WriteLine("Exit Option Selected - Console Application Terminating....");
                    return false;
                default:
                    Console.WriteLine("\r\nInvalid Option Selected - Console Application Terminating....");
                    return false;
            }
        }

        private static void CSVToJSON()
        {
            // The csv input has been simulated below simply in order to avoid any possible 
            // absolute path issues - this would be addressed correctly in a finished application or
            // could easily reference a dummy csv file located in the Data folder of the solution.
            
            string csv = @"name, address_line1, address_line2
                            Dave,  Street, Town";

            using var w = new ChoJSONWriter(Console.Out)
                .Configure(c => c.DefaultArrayHandling = false);
            using var r = ChoCSVReader.LoadText(csv).WithFirstLineHeader()
                .Configure(c => c.NestedColumnSeparator = '_');
            w.Write(r);

            // Note: This is a very crude method to arrest processing whilst output is inspected

            var pause = true;
            while (pause)
            {
                Console.Write("\r\n\r\nPress return to continue when output has been inspected.... ");
                var input = Console.ReadLine();
                pause = false;
            }
        }

        private static void CSVToXML()
        {
            Console.WriteLine("\r\nCSV To XML Option Not Yet Implemented...");
            Thread.Sleep(3000);
        }

        private static void JSONToCSV()
        {
            Console.WriteLine("\r\nJSON To CSV Option Not Yet Implemented...");
            Thread.Sleep(3000);
        }

        private static void XMLToCSV()
        {
            Console.WriteLine("\r\nXML To CSV Option Not Yet Implemented...");
            Thread.Sleep(3000);
        }

        private static void XMLToJSON()
        {
            Console.WriteLine("\r\nXML To JSON Option Not Yet Implemented...");
            Thread.Sleep(3000);
        }

        private static void JSONToXML()
        {
            Console.WriteLine("\r\nJSON To XML Option Not Yet Implemented...");
            Thread.Sleep(3000);
        }

        private static bool DataBaseMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("Cloud Commerce Group - Database File input & Conversion - Test - Glen Foster");
            Console.WriteLine("\r\nChoose an option:");
            Console.WriteLine("\r\n1) Microsoft SQL To JSON");
            Console.WriteLine("2) Microsoft SQL To XML");
            Console.WriteLine("\r\n3) Oracle To JSON");
            Console.WriteLine("4) Oracle To XML");
            Console.WriteLine("\r\n5) MySQL To JSON");
            Console.WriteLine("6) MySQL To XML");
            Console.WriteLine("\r\n7) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                    ConvertFromDataBase();
                    return true;
                case "7":
                    Console.WriteLine("Exit Option Selected - Returning to File Import Options Menu....");
                    Thread.Sleep(3000);
                    return false;
                default:
                    Console.WriteLine("\r\nInvalid Option Selected - Returning to File Import Options Menu....");
                    Thread.Sleep(3000);
                    return false;
            }
        }

        static void ConvertFromDataBase()
        {
            Console.WriteLine("\r\nOption Not Yet Implemented!! - Returning To Database Option Menu...");
            Thread.Sleep(3000);
        }
    }
}
