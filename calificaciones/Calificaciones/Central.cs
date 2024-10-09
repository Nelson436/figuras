using Calificaciones.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    class Central
    {
        static string constrg = "Data Source=DESKTOP-9LEERSH\\PROGRAMMING;" +
            "Initial Catalog=Calificaciones;User ID=sa;Password=123456;TrustServerCertificate=True";
        //"Data Source=DESKTOP-9LEERSH\\PROGRAMMING;Initial Catalog=unidep;User ID=sa;Password=123456;TrustServerCertificate=True");

        public static Response RegistrarAlumno(Alumno alumno)
        {
            Response response = new Response();
            //codigo para registrar alumno
            SqlConnection conn = new SqlConnection(constrg);
            SqlCommand comm = new SqlCommand("insert into Alumnos (nombre,apellidos,matricula)values(@Nombre,@Apellidos,@Matricula) ", conn);
            comm.Parameters.AddWithValue("@Nombre", alumno.Nombre);
            comm.Parameters.AddWithValue("@Apellidos", alumno.Apellidos);
            comm.Parameters.AddWithValue("@Matricula", alumno.Matricula);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                response.Codigo = 1;
                response.Mensaje = "Alumno regitrado correctamente";
            }
            catch (Exception ex)
            {
                response.Codigo = 2;
                response.Mensaje = "Ocurrio un error, el alumno no pudo ser registrado";
                Logger.Log(ex.Message, "RegistrarAlumno","Central");
            }
            finally
            {
                conn.Close();
            }
            return response;
        }
        public static DataTable CaragarAlumnos()
        {
            DataTable dtalumnos = new DataTable();
            SqlConnection conn = new SqlConnection(constrg);
            SqlCommand comm = new SqlCommand("select * from alumnos", conn);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dtalumnos);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, "CaragarAlumnos", "Central");
            }
            finally
            {
                conn.Close();
            }
            return dtalumnos;
        }

        //se define el parametro com objeto para evitar el agregar mas campos si se requieren despues
        public static void RegistarMateria(Materia materia)
        {
            //codigp para registrar materia
        }
        public static DataTable CaragarMaterias()
        {
            DataTable dtmaterias = new DataTable();
            //codigo para obtener lista de materias
            return dtmaterias;
        }

    }
}
