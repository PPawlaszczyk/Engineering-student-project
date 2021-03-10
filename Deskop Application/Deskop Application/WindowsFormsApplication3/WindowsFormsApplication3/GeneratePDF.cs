using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange
{
    public static class GeneratePDF
    {

        public static Document CreatePDF(string shooter, string avgTime, string maxTime, string minTime, string gunType, string gunName)
        {
            Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("SHOOTER_wyniki.pdf", FileMode.Create));
            doc.Open();


            if (shooter == "")
            {
                shooter = "Stormtrooper";
            }

            Paragraph paragraph1 = new Paragraph(Convert.ToString("Nazwa strzelca: " + shooter));
            doc.Add(paragraph1);


            Paragraph paragraph2 = new Paragraph(Convert.ToString("Data: " + DateTime.Now.ToString()));
            doc.Add(paragraph2);

            Paragraph paragraph3 = new Paragraph(Convert.ToString("Bron: " + gunName));
            doc.Add(paragraph3);
            Paragraph paragraph4 = new Paragraph(Convert.ToString("Typ broni: " + gunType));
            doc.Add(paragraph4);

            Paragraph paragraph6 = new Paragraph(Convert.ToString("Wartosc maksymalna: " + maxTime));
            doc.Add(paragraph6);
            Paragraph paragraph7 = new Paragraph(Convert.ToString("Wartosc srednia: " + avgTime));
            doc.Add(paragraph7);
            Paragraph paragraph8 = new Paragraph(Convert.ToString("Wartosc minimalna " + minTime));
            doc.Add(paragraph8);

            doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n")); doc.Add(new Chunk("\n"));

            Paragraph paragraph9 = new Paragraph(Convert.ToString("ShooterProRaportGenerator"));
            doc.Add(paragraph9);
            Paragraph paragraph10 = new Paragraph(Convert.ToString("Wszelkie uwagi - mail kontaktowy: Pawel.Pawlaszczyk@gmail.com"));
            doc.Add(paragraph10);
            doc.Close();

            return null;
        }
    }
}
