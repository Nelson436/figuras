using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_1.Interfaces
{
    internal interface IUsuarios
    {
        string Nombre { get; set; }
        string Email { get; set; }
        void Login();
        bool ActualizaPerfil(string nombre, string Email);
    }
}