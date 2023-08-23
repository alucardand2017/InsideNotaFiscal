using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO.Compression;
using InsideNotaFiscal;
namespace Valur.Utilities
{
    internal class ChromeUpdate
    {
        static readonly HttpClient client = new HttpClient();
        //static string archiveNameZip = "chromedriver_win32.zip";
        static string archiveNameZip = "chromedriver-win64.zip";
        static string archiveName = "chromedriver-win64";

        static string archiveNameExe = "chromedriver.exe";
        static string archiveNameLicense = "LICENSE.chromedriver";
        public static async Task AtualizacaoChromiun()
        {
            try
            {
                //string latestVersion = await GetVersionChromium(); //pega o numero da versão
                string sourceDownloadChromeVersion = GetUriChromeVersion(); //baixa o zip dela
                
                string destinationDownloadChromeVersion = Environment.CurrentDirectory + $"\\{archiveNameZip}"; //monta o endereço do zip
                string chromedriverZipFolder = destinationDownloadChromeVersion; //diz que o endereço do driver zipado é o mesmo da versão de download
                await CopyZiFileInCurrentDirectory(sourceDownloadChromeVersion);
                ExtractorArchivesInLocal(destinationDownloadChromeVersion, Environment.CurrentDirectory);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Erro na busca datualização do Chrome: " + e.Message);
            }
        }
        private static string GetUriChromeVersion()
        {
            //return $"https://chromedriver.storage.googleapis.com/{latestVersion}/{archiveNameZip}";
            return $"https://edgedl.me.gvt1.com/edgedl/chrome/chrome-for-testing/116.0.5845.96/win64/chromedriver-win64.zip";
        }
        private static void ExtractorArchivesInLocal(string destinationDownloadChromeVersion, string chromedriverFolder)
        {
            try
            {
                CheckDeleteExtractFoldersInDirectory(destinationDownloadChromeVersion, chromedriverFolder);
            }
            catch (Exception)
            {
                throw new ArgumentException("Erro ao extrair os arquivos para o sistema");
            }
        }
        private static void CheckDeleteExtractFoldersInDirectory(string destinationDownloadChromeVersion, string chromedriverFolder)
        {
            if (Directory.Exists(Environment.CurrentDirectory + $"\\chromedriver-win64"))
                Directory.Delete(Environment.CurrentDirectory + $"\\chromedriver-win64", true);
            if (File.Exists(Environment.CurrentDirectory + $"\\{archiveNameExe}"))
                File.Delete(Environment.CurrentDirectory + $"\\{archiveNameExe}");
            if (File.Exists(Environment.CurrentDirectory + $"\\{archiveNameLicense}"))
                File.Delete(Environment.CurrentDirectory + $"\\{archiveNameLicense}");

            ZipFile.ExtractToDirectory(destinationDownloadChromeVersion, chromedriverFolder);

            if (File.Exists(Environment.CurrentDirectory + $"\\{archiveNameZip}"))
                File.Delete(Environment.CurrentDirectory + $"\\{archiveNameZip}");

            File.Copy(Environment.CurrentDirectory + $"\\chromedriver-win64\\{archiveNameExe}", Environment.CurrentDirectory +$"\\{archiveNameExe}");
            Directory.Delete(Environment.CurrentDirectory + $"\\chromedriver-win64", true);


        }
        private static async Task CopyZiFileInCurrentDirectory(string sourceDownloadChromeVersion)
        {
            try
            {
                using (var stream = await client.GetStreamAsync(sourceDownloadChromeVersion))
                {
                    using (var fileStream = new FileStream(archiveNameZip, FileMode.CreateNew))
                    {
                        await stream.CopyToAsync(fileStream);
                    }
                }
            }
            catch (Exception)
            {
                throw new ArgumentException("Erro na realização do download dos arquivos do site da Google");
            }
           
        }

        //falta atualizar a função para retornar as versões superior as 115 do Chromiun, que mudaram de endereço -> 
        public static async Task<string> GetVersionChromium()
        {
            try
            {
                using (HttpResponseMessage response = await client.GetAsync("https://googlechromelabs.github.io/chrome-for-testing/LATEST_RELEASE_116"))
                {
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody;
                }
            }
            catch (Exception)
            {

                throw new ArgumentException("Erro em adquirir informação da última versão do Google Chrome");
            }
           
        }
    }
}

