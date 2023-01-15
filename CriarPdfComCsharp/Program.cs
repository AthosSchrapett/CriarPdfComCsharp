using CriarPdfComCsharp.PdfGenerator;
using iText.Kernel.Pdf;

PdfWriter writer = new(@"D:\Meus Projetos\Documentos\demo.pdf");

PdfGenerator pdfGenerator = new(writer);
pdfGenerator.Write();