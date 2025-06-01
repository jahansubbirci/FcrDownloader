using LoggerService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FcrDownloader
{
    public partial class Form1 : Form
    {
        LoggerService.ILog logger;
        public Form1()
        {
            InitializeComponent();
            logger = new XlsLog();
        }

        private void UnzipButton_Click(object sender, EventArgs e)
        {
            var list = FcrGrid.Rows.Cast<DataGridViewRow>()
                .Select(r => r.Cells[0].Value.ToString())
                .ToHashSet();
            string rootFolderPath = @"C:\Users\MSJ046\Downloads";
            string destionationDirectory = @"C:\Users\MSJ046\OneDrive - Maersk Group\AuditFCR";
            DirectoryInfo di = new DirectoryInfo(rootFolderPath);
            //var zipFiles=di.GetFiles("GenerateMultipleFCRReport*").Where(a=>a.Extension == ".zip").ToList();

            foreach (string zipFilePath in Directory.GetFiles(rootFolderPath, "GenerateMultipleFCRReport*"))
            {
                using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        // Skip directories
                        if (string.IsNullOrWhiteSpace(entry.Name)) continue;

                        string destinationPath = Path.Combine(destionationDirectory, entry.Name);

                        // Skip file if already extracted
                        if (File.Exists(destinationPath))
                        {
                            logger.LogInfo($"File already exists: {entry.Name}");
                            continue;
                        }

                        entry.ExtractToFile(destinationPath);
                        logger.LogInfo($"Extracted: {entry.Name}");
                    }
                }
            }


        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            var clipBoardText = Clipboard.GetText();
            var array = clipBoardText.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            FcrGrid.DataSource = array.Select(a => new { FCR = a }).ToList();

        }

        FcrReader fcrReader = new FcrReader();
        private void GetFcrNoButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\MSJ046\OneDrive - Maersk Group\AuditFCR");
            var files = di.GetFiles("*.pdf").ToList();
            foreach (var file in files)
            {
                
                
                {
                    var pair = fcrReader.Read(file.FullName);
                    var fcrNo = pair.Value;
                    logger.LogInfo($"{fcrNo}");
                    var destinationFile = Path.Combine(file.DirectoryName, fcrNo + ".pdf");
                    if (!File.Exists(destinationFile))
                    {
                        File.Move(file.FullName, destinationFile);
                        logger.LogInfo($"\tFile {file.Name} renamed to \t{fcrNo}\t.pdf");
                    }
                    else
                    {
                        logger.LogInfo($"\tFile {file.Name} already exists as \t{fcrNo}\t.pdf, skipping rename.");
                        continue;

                    }
                    if (!fcrNo.Contains("CTG") &&
                        !fcrNo.Contains("CGP")
                        )
                    {
                        logger.LogInfo($"\t"+fcrNo + " does not contain CTG or CGP, skipping file: " + file.Name);
                    }
                }
            }

        }
    }
}
