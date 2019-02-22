using iTextSharp.text;
using iTextSharp.text.pdf;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Omb_SQL_SERVER.Vistas
{
    public partial class Listado_Reporte_Vig_Pol : MaterialForm
    {
        public Listado_Reporte_Vig_Pol()
        {
            InitializeComponent();
            MaterialSkinManager Tema = MaterialSkinManager.Instance;
            Tema.AddFormToManage(this);
            Tema.Theme = MaterialSkinManager.Themes.LIGHT;

            // COLOR
            Tema.ColorScheme = new ColorScheme(
                Primary.Blue900, Primary.Blue900,
                Primary.Blue900, Accent.Blue400,
                TextShade.WHITE);
            //.....
            DataGrid_Listado_Vig_Pol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        // INSTANCIANDO METODO PARA EL DATAGRID
        Capa_Logica.Logica_Metodos Metodos = new Capa_Logica.Logica_Metodos();

        private void Listado_Reporte_Vig_Pol_Load(object sender, EventArgs e)
        {
            //Metodos.LlenarTabla_Vigencia(DataGrid_Listado_Vig_Pol);
            // ACTUALIZAR AUTOMATICAMENTE POLIZA SI ESTA ACTIVA O INACTIVA
            string PolqueryActivo = "UPDATE Poliza SET Pol_Estado = 'ACTIVO' where Pol_Vigencia_Final >= GETDATE()";
            Metodos.Insertar(PolqueryActivo);
            string PolqueryInactivo = "UPDATE Poliza SET Pol_Estado = 'INACTIVO' where Pol_Vigencia_Final < GETDATE()";
            Metodos.Insertar(PolqueryInactivo);
            // FINALIZACION POLIZA UPDATE

            //ACTUALIZAR ACTIVO O INACTIVO EN VEHICULOS
            string SOATqueryActivo = "UPDATE Vehiculo SET Veh_Soat_Estado = 'ACTIVO' where Veh_Vigencia_Soat >= GETDATE()";
            Metodos.Insertar(SOATqueryActivo);
            string SOATqueryInactivo = "UPDATE Vehiculo SET Veh_Soat_Estado = 'INACTIVO' where Veh_Vigencia_Soat < GETDATE()";
            Metodos.Insertar(SOATqueryInactivo);
            // FIN 
        }

        private void DataGrid_Listado_Vig_Pol_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DataGrid_Listado_Vig_Pol.Columns[e.ColumnIndex].Name == "Estado de la poliza")
            {
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {


                        if (e.Value.ToString().Equals("ACTIVO"))
                        {
                            e.CellStyle.BackColor = Color.LightGreen;

                        }

                        if (e.Value.ToString().Equals("INACTIVO"))
                        {
                            e.CellStyle.BackColor = Color.IndianRed;
                        }

                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void PDF_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance("C:\\Program Files\\OMB\\Programa OMB Seguros\\Images\\Logo.png");
            iTextSharp.text.Font palatino = FontFactory.GetFont("MS GOTHIC", 15, iTextSharp.text.Font.BOLD);
            palatino.SetColor(246, 246, 246);

            // VALIDANDO SI EL DATAGRID ESTA VACIO O NO
            if (DataGrid_Listado_Vig_Pol.DataSource==null)
            {
                Alert.Alert.Show_Alert_Message("Genere la tabla para realizar PDF", Alert.Alert.AlertType.warning);
            }
            else
            {
            //CREANDO EL ARCHIVO CON ITEXTSHARP
            PdfPTable pdfTable = new PdfPTable(DataGrid_Listado_Vig_Pol.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.DefaultCell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //AÑADIENDO EL HEADER DE LA COLUMNA
            foreach (DataGridViewColumn column in DataGrid_Listado_Vig_Pol.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, palatino));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(31, 48, 76);
                pdfTable.AddCell(cell);
            }

            //AÑADIENDO LOS REGISTROS
            foreach (DataGridViewRow row in DataGrid_Listado_Vig_Pol.Rows)
            {
                try
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null)
                        {
                            pdfTable.AddCell(cell.Value.ToString());

                        }

                    }
                }
                catch (Exception)
                {


                }

            }

            //EXPORTANDO A PDF
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Reporte Vigencia Polizas";
            save.Filter = "PDF (*.pdf)|*.pdf";
            if (save.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(save.FileName, FileMode.Create);

                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(Logo);
                pdfDoc.AddTitle("REPORTE VIGENCIA POLIZAS");
                pdfDoc.Add(new Paragraph("REPORTE VIGENCIA POLIZAS", FontFactory.GetFont("MS GOTHIC", 30, iTextSharp.text.Font.BOLD)));
                pdfDoc.Add(new Paragraph("                          "));
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(new Paragraph("FECHA REPORTE: ", FontFactory.GetFont("ARIAL", 9, iTextSharp.text.Font.UNDERLINE)));
                pdfDoc.Add(new Paragraph("" + System.DateTime.Now + "", FontFactory.GetFont("ARIAL", 9, iTextSharp.text.Font.NORMAL)));
                pdfDoc.Close();
                stream.Close();
                Alert.Alert.Show_Alert_Message("PDF Guardado correctamente", Alert.Alert.AlertType.success);
            }
            else
            {
                Alert.Alert.Show_Alert_Message("Error al guardar PDF", Alert.Alert.AlertType.error);
            }
          }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void DataGrid_Listado_Vig_Pol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel_Superior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Buscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (Buscar.Text=="")
            {
                DataGrid_Listado_Vig_Pol.DataSource = null;
            }
            else
            {
                Metodos.Reporte_Vigencia_Poliza_Buscar(DataGrid_Listado_Vig_Pol,Buscar.Text);
            }
        }

        private void DP_Mes_onItemSelected(object sender, EventArgs e)
        {
            if (DP_Mes.selectedIndex >= 0)
            {
                int Seleccion_Correcta = DP_Mes.selectedIndex + 1;
                Metodos.LlenarTabla_Vigencia(DataGrid_Listado_Vig_Pol,Seleccion_Correcta);
            }
        }
    }
}
