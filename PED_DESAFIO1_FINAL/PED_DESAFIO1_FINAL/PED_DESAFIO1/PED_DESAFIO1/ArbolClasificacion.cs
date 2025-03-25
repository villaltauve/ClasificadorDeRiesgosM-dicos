using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PED_DESAFIO1
{
    public class ArbolClasificacion
    {
        private TreeNode root;

        public ArbolClasificacion()
        {
            root = new TreeNode("Pacientes");
        }

        public void AgregarPaciente(Paciente paciente)
        {
            // Buscar o crear el nodo de género
            TreeNode generoNode = root.Nodes.Find(paciente.Genero, false).FirstOrDefault();
            if (generoNode == null)
            {
                generoNode = new TreeNode(paciente.Genero) { Name = paciente.Genero };
                root.Nodes.Add(generoNode);
            }

            // Buscar o crear el nodo de tipo de sangre
            TreeNode tipoSangreNode = generoNode.Nodes.Find(paciente.TipoSangre, false).FirstOrDefault();
            if (tipoSangreNode == null)
            {
                tipoSangreNode = new TreeNode(paciente.TipoSangre) { Name = paciente.TipoSangre };
                generoNode.Nodes.Add(tipoSangreNode);
            }

            // Buscar o crear el nodo de presión arterial
            TreeNode presionNode = tipoSangreNode.Nodes.Find(paciente.PresionArterial, false).FirstOrDefault();
            if (presionNode == null)
            {
                presionNode = new TreeNode(paciente.PresionArterial) { Name = paciente.PresionArterial };
                tipoSangreNode.Nodes.Add(presionNode);
            }

            // Crear un nodo con la información completa del paciente
            string infoPaciente = $"{paciente.Nombre} - {paciente.Genero}, {paciente.TipoSangre}, {paciente.PresionArterial}";
            TreeNode pacienteNode = new TreeNode(infoPaciente);
            pacienteNode.Tag = paciente; 

            // Agregar el nodo del paciente al nodo de presión arterial
            presionNode.Nodes.Add(pacienteNode);
        }

        public TreeNode GetArbol()
        {
            return root;
        }
    }
}