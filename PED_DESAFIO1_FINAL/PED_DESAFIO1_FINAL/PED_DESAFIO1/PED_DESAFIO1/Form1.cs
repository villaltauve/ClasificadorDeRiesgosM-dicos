using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PED_DESAFIO1
{
    public partial class DESAFIO1_PED: Form
    {
        private ArbolClasificacion arbol;

        public DESAFIO1_PED()
        {
            InitializeComponent();
            arbol = new ArbolClasificacion();

            // Inicializar ComboBox
            comboBoxGenero.Items.AddRange(new string[] { "Masculino", "Femenino" });
            comboBoxTipoSangre.Items.AddRange(new string[] { "A", "B", "O", "AB" });
            comboBoxPresion.Items.AddRange(new string[] { "Alta", "Normal", "Baja" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese el nombre del paciente.");
                return;
            }

            string genero = comboBoxGenero.SelectedItem?.ToString();
            string tipoSangre = comboBoxTipoSangre.SelectedItem?.ToString();
            string presion = comboBoxPresion.SelectedItem?.ToString();

            if (genero == null || tipoSangre == null || presion == null)
            {
                MessageBox.Show("Por favor, seleccione todas las opciones.");
                return;
            }

            // Crear el paciente con el nombre incluido
            Paciente paciente = new Paciente(nombre, genero, tipoSangre, presion);
            arbol.AgregarPaciente(paciente);



            // Actualizar el TreeView
            treeViewClasificacion.Nodes.Clear();
            treeViewClasificacion.Nodes.Add(arbol.GetArbol());
            treeViewClasificacion.ExpandAll();

            lblMensaje.Text = $"Paciente '{nombre}' agregado correctamente."; // Mostrar nombre en el mensaje


            // Limpiar campos después de agregar
            textBoxNombre.Clear();
            comboBoxGenero.SelectedIndex = -1;
            comboBoxTipoSangre.SelectedIndex = -1;
            comboBoxPresion.SelectedIndex = -1;



        }


        private void treeViewClasificacion_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Paciente paciente) 
            {
                string riesgo = paciente.CalcularRiesgoEnfermedad();
                lblMensaje.Text = $"Paciente: {paciente.Nombre}\nRiesgo de enfermedad: {riesgo}";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
    

