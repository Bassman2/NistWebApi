using NISTWebApi;

namespace NISTConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                using var client = new Nist("nist", "Demo");
                var cpes = client.GetCPEProductsByKeywordSearchAsync("jpeg");

                await foreach (var cpe in cpes)
                {
                    Console.WriteLine(cpe.Cpe23Uri);
                }
            }).Wait();        
        }
    }
}
