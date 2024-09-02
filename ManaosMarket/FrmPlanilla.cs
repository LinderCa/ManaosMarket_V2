using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReglasNegocio;
using Entidades;
using ClosedXML.Excel;

namespace ManaosMarket
{
    public partial class FrmPlanilla : Form
    {
        List<Planilla> planillas = new List<Planilla>();


        public FrmPlanilla()
        {
            InitializeComponent();
            

        }
        private void FormularioPlanilla_Load(object sender, EventArgs e)
        {
           
        }
        private void FrmPlanilla_Load(object sender, EventArgs e)
        {
            CargarDatosPlanillas();
        }
        private void CargarDatosPlanillas()
        {
            rnPlanilla rn = new rnPlanilla();
            try
            {
                // Obtener los datos de las planillas desde el negocio
                List<Planilla> planillas = rn.ObtenerPlanillas();

                // Vincular los datos al DataGridView
                DgvPlanilla.DataSource = planillas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de las planillas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            rnPlanilla rn = new rnPlanilla();
            try
            {
                string filtro = TxtEmpleado.Text.Trim(); // Obtener el texto del filtro

                // Llamar al método ObtenerPlanillas con el filtro proporcionado
                List<Planilla> planillas = rn.ObtenerPlanillasFiltradas(filtro);

                // Mostrar los resultados en el DataGridView
                MostrarPlanillasEnDataGridView(planillas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de las planillas filtradas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
        private void MostrarPlanillasEnDataGridView(List<Planilla> planillas)
        {

            foreach (Planilla planilla in planillas)
            {
                DgvPlanilla.DataSource = planillas;

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un nuevo libro de Excel
                using (var workbook = new XLWorkbook())
                {
                    // Agregar una nueva hoja de Excel
                    var worksheet = workbook.Worksheets.Add("Planillas");

                    // Obtener los datos del DataGridView
                    DataTable dt = GetDataFromDataGridView(DgvPlanilla);

                    // Insertar los datos en la hoja de Excel
                    worksheet.Cell(1, 1).InsertTable(dt);

                    // Guardar el libro de Excel en un archivo
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivos de Excel (.xlsx)|.xlsx";
                    saveFileDialog.FileName = "Planillas.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("¡Datos guardados exitosamente en Excel!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos en Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private DataTable GetDataFromDataGridView(DataGridView dataGridView)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = dt.NewRow();
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    dataRow[i] = row.Cells[i].Value ?? DBNull.Value;
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }
    }
}
