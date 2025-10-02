using System;
using System.Windows.Forms;

namespace Asistencia
{
    public partial class AgregarAlumnoForm : Form
    {
        public string Nombre { get; private set; }
        public bool Asistencia { get; private set; }
        public DateTime FechaAsistencia { get; private set; } // Agregar la propiedad FechaAsistencia
        public string Curso { get; private set; } // Agregar la propiedad Curso

        public AgregarAlumnoForm()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {
            // Obtener el nombre del alumno desde el TextBox
            Nombre = txtNombre.Text;

            // Obtener el estado de la asistencia del CheckBox
            Asistencia = chkAsistencia.Checked;

            // Obtener la fecha de asistencia desde el DateTimePicker
            FechaAsistencia = dtpFechaAsistencia.Value;

            // Obtener el curso desde el ComboBox
            Curso = cmbCurso.Text;

            // Cerrar el formulario con DialogResult.OK
            DialogResult = DialogResult.OK;
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            // Cerrar el formulario con DialogResult.Cancel
            DialogResult = DialogResult.Cancel;
        }

        private void AgregarAlumnoForm_Load(object sender, EventArgs e)
        {
            // Agregar cursos al ComboBox en el constructor
            cmbCurso.Items.Add("2785- PANADERO");
            cmbCurso.Items.Add("2786- PELUQUERO");
            cmbCurso.Items.Add("2787- GASISTA DE UNIDADES UNIFUNCIONALES");
            cmbCurso.Items.Add("2788- PANADERO");
            cmbCurso.Items.Add("2789- OPERADOR DE MAQUINA P CONF.INDUMENTARIA");
            cmbCurso.Items.Add("2790- PRACTICO EN MANTENIMIENTO DE EDIFICIOS");
            cmbCurso.Items.Add("2791- OPERADORA / OR CARPINTERIA Y FAB.MOBILIARIO");
            cmbCurso.Items.Add("2792- OPERARIO / A HORTICOLA");
            cmbCurso.Items.Add("2793- MECANICO CICLOMOTORES");
            cmbCurso.Items.Add("2794- VIDRIERISTA");
            cmbCurso.Items.Add("2795- HABILIDADES DIGITALES");
            cmbCurso.Items.Add("2796- CULTIVADOR DE HONGOS COMESTIBLES");
            cmbCurso.Items.Add("2797- HABILIDADES DIGITALES");
            cmbCurso.Items.Add("2798- SOLDADOR");
            cmbCurso.Items.Add("2799- PRACTICO EN SERIGRAFIA");
            cmbCurso.Items.Add("2800- OPERADOR DE INFORMATICA P / ADMIN Y GESTION");
            cmbCurso.Items.Add("2801- CULTIVADOR DE HONGOS COMESTIBLES");
            cmbCurso.Items.Add("2802- PRACTICO EN DISEÑO GRAFICO SIST.INF.NIVEL1");
            cmbCurso.Items.Add("2803- ESTAMPADOR MULTIPLE");
            cmbCurso.Items.Add("2804- CULTIVADOR DE HONGOS COMESTIBLES");
            cmbCurso.Items.Add("2805- COMUNICADOR PARA ORGANIZACIONES SOCIALES");
            cmbCurso.Items.Add("2806- JARDINERO");
            cmbCurso.Items.Add("2807- MECANICO DE CICLOMOTORES");
            cmbCurso.Items.Add("2808- PRACTICO MARQUETERIA");
            cmbCurso.Items.Add("2809- ESPECIALIZACION PROF GESTION EMPRE.PRODUCT");
            cmbCurso.Items.Add("2810- PRACTICO EN DISEÑO GRAFICO SIST.INF.NIVEL2");
            cmbCurso.Items.Add("2811- ARM Y MONT PANELES, CIELORRASOS PLACA YESO");
            cmbCurso.Items.Add("2812- BOLSILLERO");
            cmbCurso.Items.Add("2813- AUXILIAR EN MARKETING DE PRODUCTOS");
            cmbCurso.Items.Add("2814- DISEÑO Y FABRICACION DIGITAL");
            cmbCurso.Items.Add("2815- COCINERO PRIMERO MODULO");  
            // Agregar más cursos si es necesario

            // Seleccionar el primer curso por defecto
            cmbCurso.SelectedIndex = 0;
        }
    }
}
