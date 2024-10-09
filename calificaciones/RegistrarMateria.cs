using Calificaciones.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class RegistrarMateria : Form
    {
        public RegistrarMateria()
        {
            InitializeComponent();
        }

        private void RegistarMateria(object sender, EventArgs e)
        {
            //crear instancia de materia para pasarla al metodo de registarr materia
            Materia materia = new Materia()
            {
                Nombre=tbnombre.Text,
                Codigo=tbcodigo.Text
            };
            Central.RegistarMateria(materia);
        }
    }
}
