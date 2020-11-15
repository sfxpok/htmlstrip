using System;
using System.IO;
using System.Text.RegularExpressions;
//using System.Runtime.InteropServices;

namespace htmlstrip
{
    class Program
    {

        //bool isWindows = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        //bool isLinux = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        //string documentDirectory = Environment.CurrentDirectory;

        string documentDirectory = Path.GetFullPath(Path.Combine(
            System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().Location), @"../../../")); // isto é terrível

        string documentFileName = "index.html";

        static string regexParser(string documentPath, string HTMLTag)
        {

            string htmlContent = File.ReadAllText(documentPath);
            string regexExpression = "<" + HTMLTag + @">\s*(.+?)\s*</" + HTMLTag + ">";

            Match parseOutput = Regex.Match(htmlContent, regexExpression);

            if (parseOutput.Success)
            {
                return parseOutput.Groups[1].Value;
            }
            else
            {
                return "A tag HTML " + HTMLTag + " não foi encontrada.";
            }
        }

        static void Main(string[] args)
        {

            Program parser = new Program();

            string documentPath = parser.documentDirectory + "/" + parser.documentFileName;

            Console.WriteLine("Insira uma tag HTML válida. Exemplo: title");
            string HTMLTag = Console.ReadLine();

            string parseOutput = regexParser(documentPath, HTMLTag);
            Console.WriteLine(parseOutput);

        }

    }
}
