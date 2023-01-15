using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Font;
using iText.Layout.Properties;

namespace CriarPdfComCsharp.PdfGenerator
{
    public class PdfGenerator
    {
        public PdfWriter Writer { get; set; }

        public PdfGenerator(PdfWriter writer)
        {
            Writer = writer;
        }

        public void Write()
        {
            PdfDocument pdf = new PdfDocument(Writer);
            Document document = new Document(pdf);

            //PdfFont font = PdfFontFactory.CreateFont(
            //    @"D:\Meus Projetos\Estudos\CriarPdfComCsharp\fonts\Roboto-Regular.ttf"
            //);
            
            //FontProvider fontProvider = new FontProvider();

            //fontProvider.AddFont(font.GetFontProgram());

            //document.SetFontProvider(fontProvider);
            //document.SetFontFamily(fontProvider.GetDefaultFontFamily());

            DeviceRgb principalColor = new DeviceRgb(33, 4, 86);

            Image img = new Image(ImageDataFactory
            .Create(@"D:\Meus Projetos\Estudos\CriarPdfComCsharp\Assets\Teste-Logo.png"))
            .SetMarginTop(25)
            .SetWidth(150)
            .SetTextAlignment(TextAlignment.LEFT);

            Paragraph header = new Paragraph("RELATÓRIO DE CONTRATAÇÃO - CHECKLIST TRIBUTÁRIO")
               .SetRelativePosition(175, 0, 0, 50)
               .SetFontColor(principalColor)
               .SetFontSize(11);

            Paragraph subHeader = new Paragraph("Prestação de serviços")
               .SetRelativePosition(175, 0, 0, 50)
               .SetFontColor(principalColor)
               .SetFontSize(11);

            Paragraph subHeaderTwo = new Paragraph("Gerência de Planejamento Tributário")
               .SetRelativePosition(175, 0, 0, 50)
               .SetFontColor(principalColor)
               .SetBold()
               .SetFontSize(11);

            SolidLine sl = new SolidLine();
            sl.SetColor(principalColor);

            LineSeparator ls = new LineSeparator(sl);
            ls.SetRelativePosition(0, 0, 0, 35);

            Text fornecedorTitle = new Text("Fornecedor: ").SetBold();
            Text fornecedorName = new Text("TESTE EMPRESA LTDA");

            Paragraph fornecedor = new Paragraph();

            fornecedor.Add(fornecedorTitle).Add(fornecedorName)
               .SetRelativePosition(0, -20, 0, 0)
               .SetTextAlignment(TextAlignment.LEFT)
               .SetFontColor(principalColor)
               .SetFontSize(10);

            Text cnpjTitle = new Text("CNPJ: ").SetBold();
            Text cnpjDocument = new Text("00.000.000/0000-00");

            Paragraph cnpj = new Paragraph();
            cnpj.Add(cnpjTitle).Add(cnpjDocument)
               .SetRelativePosition(0, -15, 0, 0)
               .SetTextAlignment(TextAlignment.LEFT)
               .SetFontColor(principalColor)
               .SetFontSize(10);

            Text cpfTitle = new Text("CPF: ").SetBold();
            Text cpfDocument = new Text("000.000.000-00");

            Paragraph cpf = new Paragraph();
            cpf.Add(cpfTitle).Add(cpfDocument)
               .SetRelativePosition(300, -38, 0, 0)
               .SetTextAlignment(TextAlignment.LEFT)
               .SetFontColor(principalColor)
               .SetFontSize(10);

            document.Add(img);
            document.Add(header);
            document.Add(subHeader);
            document.Add(subHeaderTwo);
            document.Add(ls);

            document.Add(fornecedor);
            document.Add(cnpj);
            document.Add(cpf);

            document.Close();
        }
    }
}
