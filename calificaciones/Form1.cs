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
    public partial class Form1 : Form
    {

        //TAREA:
        //-------En ventana de materias--------
        //Registrar materia
        //Cargar materias
        //-------En ventana de calificaiones-------
        //Cargar Alumnos en el combobox de alumnos
        //Cargar Materias en el combobox de materias
        //Asignar calificacion al alumno
        //Cargar la lista de calificaciones
        public Form1()
        {
            InitializeComponent();
        }

      
        private void VerMaterias(object sender, EventArgs e)
        {
            Materias _materias = new Materias();
            _materias.Show();
        }
        private void VerAlumnos(object sender, EventArgs e)
        {
            Alumnos _alumnos = new Alumnos();
            _alumnos.Show();
        }

        private void VerCalifciaciones(object sender, EventArgs e)
        {
            FrmCalificaciones _calif = new FrmCalificaciones();
            _calif.Show();
        }

    }
}
