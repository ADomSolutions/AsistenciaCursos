using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace Asistencia
{
    public partial class Form1 : Form
    {
        public class Alumno
        {
            public string Nombre { get; set; }
            public bool Asistencia { get; set; }
            public DateTime FechaAsistencia { get; set; }
            public string Curso { get; set; }
        }

        private List<Alumno> alumnos = new List<Alumno>();
        private DataGridView dataGridView1;
        private Button btnImportar;
        private Button btnExportar;
        private Button btnAgregarAlumno;

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeButtons();
        }

        private void InitializeDataGridView()
        {
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoGenerateColumns = false;
            Controls.Add(dataGridView1);

            DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.DataPropertyName = "Nombre";
            nombreColumn.HeaderText = "Nombre";
            dataGridView1.Columns.Add(nombreColumn);

            DataGridViewCheckBoxColumn asistenciaColumn = new DataGridViewCheckBoxColumn();
            asistenciaColumn.DataPropertyName = "Asistencia";
            asistenciaColumn.HeaderText = "Asistencia";
            dataGridView1.Columns.Add(asistenciaColumn);

            DataGridViewTextBoxColumn fechaColumn = new DataGridViewTextBoxColumn();
            fechaColumn.DataPropertyName = "FechaAsistencia";
            fechaColumn.HeaderText = "Fecha de Asistencia";
            dataGridView1.Columns.Add(fechaColumn);

            DataGridViewTextBoxColumn cursoColumn = new DataGridViewTextBoxColumn();
            cursoColumn.DataPropertyName = "Curso";
            cursoColumn.HeaderText = "Curso";
            dataGridView1.Columns.Add(cursoColumn);
        }

        private void InitializeButtons()
        {
            btnImportar = new Button();
            btnImportar.Text = "Importar";
            btnImportar.Dock = DockStyle.Bottom;
            btnImportar.Click += btnImportar_Click;
            Controls.Add(btnImportar);

            btnExportar = new Button();
            btnExportar.Text = "Exportar";
            btnExportar.Dock = DockStyle.Bottom;
            btnExportar.Click += btnExportar_Click;
            Controls.Add(btnExportar);

            btnAgregarAlumno = new Button();
            btnAgregarAlumno.Text = "Agregar Alumno";
            btnAgregarAlumno.Dock = DockStyle.Bottom;
            btnAgregarAlumno.Click += BtnAgregarAlumno_Click;
            Controls.Add(btnAgregarAlumno);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar datos desde Excel
            string filePath = "C:/Programacion/formacion/Asistencia/Asistencia/bin/Debug/excel/asistencia.xlsx";
            alumnos = ImportarDesdeExcel(filePath);

            // Mostrar datos en DataGridView
            MostrarDatosEnGrid();
        }

        private void MostrarDatosEnGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alumnos;
        }

        private List<Alumno> ImportarDesdeExcel(string filePath)
        {
            List<Alumno> alumnos = new List<Alumno>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                if (package.Workbook.Worksheets.Count > 0)
                {
                    var worksheet = package.Workbook.Worksheets[0];

                    if (worksheet != null)
                    {
                        var dimension = worksheet.Dimension;

                        if (dimension != null)
                        {
                            int rowCount = dimension.Rows;

                            for (int row = 2; row <= rowCount; row++)
                            {
                                var cellValue = worksheet.Cells[row, 1].Value;
                                if (cellValue != null)
                                {
                                    alumnos.Add(new Alumno
                                    {
                                        Nombre = cellValue.ToString(),
                                        Asistencia = bool.Parse(worksheet.Cells[row, 2].Value.ToString()),
                                        FechaAsistencia = DateTime.Parse(worksheet.Cells[row, 3].Value.ToString()),
                                        Curso = worksheet.Cells[row, 4].Value.ToString()
                                    });
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("La hoja de cálculo no contiene datos.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se pudo cargar la hoja de cálculo.");
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron hojas de cálculo en el archivo Excel.");
                }
            }

            return alumnos;
        }

        private void ExportarAExcel(List<Alumno> alumnos, string filePath)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Asistencia");

                worksheet.Cells[1, 1].Value = "Nombre";
                worksheet.Cells[1, 2].Value = "Asistencia";
                worksheet.Cells[1, 3].Value = "Fecha de Asistencia";
                worksheet.Cells[1, 4].Value = "Curso";

                int row = 2;
                foreach (var alumno in alumnos)
                {
                    worksheet.Cells[row, 1].Value = alumno.Nombre;
                    worksheet.Cells[row, 2].Value = alumno.Asistencia;
                    worksheet.Cells[row, 3].Value = alumno.FechaAsistencia;
                    worksheet.Cells[row, 4].Value = alumno.Curso;
                    row++;
                }

                package.SaveAs(new FileInfo(filePath));
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
            openFileDialog.Title = "Seleccione el archivo Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                alumnos = ImportarDesdeExcel(filePath);
                MostrarDatosEnGrid();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar como Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportarAExcel(alumnos, filePath);
                MessageBox.Show("Datos exportados correctamente.");
            }
        }

        private void BtnAgregarAlumno_Click(object sender, EventArgs e)
        {
            using (var agregarAlumnoForm = new AgregarAlumnoForm())
            {
                var result = agregarAlumnoForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string nombre = agregarAlumnoForm.Nombre;
                    bool asistencia = agregarAlumnoForm.Asistencia;
                    DateTime fechaAsistencia = agregarAlumnoForm.FechaAsistencia;
                    string curso = agregarAlumnoForm.Curso;

                    alumnos.Add(new Alumno { Nombre = nombre, Asistencia = asistencia, FechaAsistencia = fechaAsistencia, Curso = curso });
                    MostrarDatosEnGrid();
                }
            }
        }
    }
}
