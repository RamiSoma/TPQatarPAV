using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.Datos.Interfaces
{
    internal interface IJugador
    {
         DataTable RecuperarTodos(string fpais);
        void eliminarJugador(string tipo_doc, string nro_doc);

        bool validar(string tipo_doc, string nro_doc);

        void crearJugador(string tipo_doc, string nro_Doc, string nombre, string apellido,string pais);
        
        void modificarJugador(string tipo_doc, string nro_doc,string nombre, string apellido);
    }

}
