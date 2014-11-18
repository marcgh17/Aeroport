using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aeroport_Application.AeroportDataSetTableAdapters;
using System.Net.Mail;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections;
using iTextSharp.text.xml;
using iTextSharp.text.html;
using System.Net;
using iTextSharp.text.html.simpleparser;


namespace Aeroport_Application
{
    public partial class RapportDeMaintenance : Form
    {
        int idVol;
        string dir;// determine le type du rapport
        int equipeM;
        Label[] l;
        TextBox[] t;
        TableLayoutPanel[] p;
        int N;
        public RapportDeMaintenance(int idVol, string dir, string outputFile)
        {
            InitializeComponent();
            this.idVol = idVol;
            this.dir = dir;


            VolTableAdapter ta = new VolTableAdapter();
            DataTable dt = ta.GetDataByVolID(idVol);
            Vol_ProgrammeTableAdapter vta = new Vol_ProgrammeTableAdapter();
            DataTable vdt = vta.GetDataByVolProgrammeID(Convert.ToInt32(dt.Rows[0]["ID_VolProgramme"].ToString()));
            equipeM = Convert.ToInt32(dt.Rows[0]["Code_EquipeM"].ToString());
            Equipe_MaintenanceTableAdapter eta = new Equipe_MaintenanceTableAdapter();
            DataTable edt = eta.GetDataByEquipeCode(equipeM);
            NumeroEquipeLabel.Text = edt.Rows[0]["Numero_EquipeM"].ToString();
         
            Rapport_MaintenanceTableAdapter rta = new Rapport_MaintenanceTableAdapter();
            DataTable rdt = rta.GetDataByIDVol(idVol);
            int idrapport = Convert.ToInt32(rdt.Rows[0]["ID_RapportM"].ToString());
            DateTime dateraport= Convert.ToDateTime(rdt.Rows[0]["Date_RapportM"].ToString());
            DateLabel.Text=dateraport.ToString("MM/dd/yyyy HH:mm");
            CodeAvionLabel.Text = dt.Rows[0]["Code_Avion"].ToString();
            NumeroVolLabel.Text = vdt.Rows[0]["Code_Compagnie"].ToString()+" "+ vdt.Rows[0]["Numero_VolProgramme"].ToString();
            string codeville="";
               if (dir == "D")
               {
                   DirectionLabel.Text = "Départ";
                   codeville=vdt.Rows[0]["Code_Ville_Destination"].ToString();
               }
            if (dir == "A") 
            {DirectionLabel.Text = "Arrivée";
                  codeville=vdt.Rows[0]["Code_Ville_Source"].ToString();
               
            }
            VilleTableAdapter vita = new VilleTableAdapter();
            DataTable vidi = vita.GetDataByCodeVille(codeville);
            VilleLabel.Text = vidi.Rows[0]["Nom_Ville"].ToString();
             

     

            //Create a standard .Net FileStream for the file, setting various flags
            using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //Create a new PDF document setting the size to A4
                using (Document document = new Document(PageSize.A4))
                {
                    //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                    using (PdfWriter w = PdfWriter.GetInstance(document, fs))
                    {
                        //Open the document for writing
                        document.Open();
                          iTextSharp.text.Font fonttitle = new iTextSharp.text.Font(FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLDITALIC));
                          Paragraph title = new Paragraph("Rapport de maintenance", fonttitle);
                          title.Alignment = Element.ALIGN_CENTER;
                          document.Add(title);
                          Paragraph p = new Paragraph(" ");
                          document.Add(p);
                          document.Add(p);
                        //
                        PdfPTable t = new PdfPTable(3);

                        //Borders are drawn by the individual cells, not the table itself.
                        //Tell the default cell that we do not want a border drawn
                        t.DefaultCell.Border = 0;
                        iTextSharp.text.Font fontresume = new iTextSharp.text.Font(FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD));
                        PdfPCell Cell1 = new PdfPCell(new Paragraph("Nº Equipe Maintenance: " + NumeroEquipeLabel.Text, fontresume));
                        PdfPCell Cell2 = new PdfPCell(new Paragraph("NºVol: " + NumeroVolLabel.Text, fontresume));
                        PdfPCell Cell3 = new PdfPCell(new Paragraph("Date rapport: " + DateLabel.Text, fontresume));
                        PdfPCell Cell4 = new PdfPCell(new Paragraph("Direction: " + DirectionLabel.Text, fontresume));
                        PdfPCell Cell5 = new PdfPCell(new Paragraph("Ville: " + VilleLabel.Text, fontresume));
                        PdfPCell Cell6 = new PdfPCell(new Paragraph("Avion: " + CodeAvionLabel.Text, fontresume));
                        PdfPCell Cell7 = new PdfPCell(new Paragraph("\n" ,fontresume));
                        PdfPCell Cell8 = new PdfPCell(new Paragraph("\n", fontresume));
                        PdfPCell Cell9 = new PdfPCell(new Paragraph("\n", fontresume));

                        Cell1.Border = 0;
                        Cell2.Border = 0;
                        Cell3.Border = 0;
                        Cell4.Border = 0;
                        Cell5.Border = 0;
                        Cell6.Border = 0;
                        Cell7.Border = 0;
                        Cell8.Border = 0;
                        Cell9.Border = 0; 

                       
                        t.AddCell(Cell1);
                        t.AddCell(Cell2);
                        t.AddCell(Cell3);
                        t.AddCell(Cell7);
                        t.AddCell(Cell8);
                        t.AddCell(Cell9);
                        t.AddCell(Cell4);
                        t.AddCell(Cell5);
                        t.AddCell(Cell6);

                        document.Add(t);
                        RapportMInfoTableAdapter rima = new RapportMInfoTableAdapter();
                        DataTable ridt = rima.GetDataByIDVol(idVol);
                       
                        document.Add(p);
                        document.Add(p);

                        iTextSharp.text.Font fontbold = new iTextSharp.text.Font(FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD));
                        iTextSharp.text.Font fontsmall = new iTextSharp.text.Font(FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL));
                        for (int i = 0; i < ridt.Rows.Count; ++i)
                        {
                            string nomop = ridt.Rows[i]["Nom_Operation"].ToString();
                            string type = ridt.Rows[i]["Type_Reponse_Operation"].ToString();

                            if (type == "YN")
                            {
                                string resultat = ridt.Rows[i]["Resultat"].ToString();
                                if (resultat == "Y") resultat = "Oui";
                                if (resultat == "N") resultat = "Non";
                                Paragraph pa = new Paragraph(nomop, fontbold);
                                document.Add(pa);
                                Paragraph pb = new Paragraph("Accomplie: " + resultat, fontsmall);
                                document.Add(pb);
                                string remaruqes = ridt.Rows[i]["Remarques"].ToString();
                                if (ridt.Rows[i]["Remarques"].ToString() != "")
                                {
                                    // string remaruqes = rdt.Rows[i]["Remarques"].ToString();
                                    Paragraph pc = new Paragraph("Remarques supplémentaires: " + remaruqes, fontsmall);
                                    document.Add(pc);
                                }
                                document.Add(p);
                                document.Add(p);

                            }

                            if (type == "R")
                            {
                                string resultat = ridt.Rows[i]["Resultat"].ToString();
                                if (resultat == "B") resultat = "Bien";
                                if (resultat == "TB") resultat = "Très Bien";
                                if (resultat == "M") resultat = "Mauvais";
                                if (resultat == "P") resultat = "Passable";
                                Paragraph pa = new Paragraph(nomop, fontbold);
                                document.Add(pa);
                                Paragraph pb = new Paragraph("Etat: " + resultat, fontsmall);
                                document.Add(pb);

                                string remaruqes = ridt.Rows[i]["Remarques"].ToString();
                                if (ridt.Rows[i]["Remarques"].ToString() != "")
                                {
                                    // string remaruqes = rdt.Rows[i]["Remarques"].ToString();
                                    Paragraph pc = new Paragraph("Remarques supplémentaires: " + remaruqes, fontsmall);
                                    document.Add(pc);
                                }
                                document.Add(p);
                                document.Add(p);

                            }
                        }


                    

                        //Close our document
                        document.Close();
                    }
                }
            }

             


        }
    }
}
