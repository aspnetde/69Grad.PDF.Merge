using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace _69Grad.PDF.Merge
{
    public class PDF
    {
        public static List<string> TempFiles;

        private readonly double A4Width = XUnit.FromCentimeter(21).Point;
        private readonly double A4Height = XUnit.FromCentimeter(29.7).Point;

        private string documentPath;
        private string templatePath;

        public string DocumentPath
        {
            get { return documentPath; }
            set { documentPath = value; }
        }

        public string TemplatePath
        {
            get { return templatePath; }
            set { templatePath = value; }
        }

        public void Save(string filename)
        {

            PdfDocument outputDocument = new PdfDocument();
            PdfDocument inputDocument = PdfReader.Open(DocumentPath, PdfDocumentOpenMode.Import);

            for(int i=0; i<= inputDocument.Pages.Count - 1; i++)
            {
                
                // Weil der Stream der einzelnen Seiten immer null ist, und
                // es zur Zeit keine bessere Möglichkeit gibt, wird jede Seite
                // als separates PDF gespeichert und ...
                PdfDocument tmpDocument = new PdfDocument();
                tmpDocument.AddPage(inputDocument.Pages[i]);
                string tmpDocumentName = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "tmp_" + Guid.NewGuid() + ".pdf");
                tmpDocument.Save(tmpDocumentName);
                TempFiles.Add(tmpDocumentName);

                // anschließend wieder eingelesen.
                XPdfForm form = XPdfForm.FromFile(tmpDocumentName);
                string path = TemplatePath;
                PdfPage page = outputDocument.Pages.Add(PdfReader.Open(path, PdfDocumentOpenMode.Import).Pages[0]);
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XRect box = new XRect(0, 0, A4Width, A4Height);
                gfx.DrawImage(form, box);

            }

            if (filename == null)
            {
                filename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "tmp_" + Guid.NewGuid() + ".pdf");
                TempFiles.Add(filename);
            }

            outputDocument.Save(filename);
            Process.Start(filename);

        }

    }
}
