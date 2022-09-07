using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.LogicaNegocio
{
    internal class Usuario
    {
        private string nombreUsu;
        private string prflUsu;

        public Usuario(string nombreUsuario, string perfilUsuario)
        {
            nombreUsu = nombreUsuario;
            prflUsu = perfilUsuario;
        }

        public string nombreUsuario  //Permite el geteo y seteo del nombreUsuario
        {
            get => nombreUsu;
            set => nombreUsu = value;
        }
        public string perfilUsuario
        {
            get => prflUsu;
            set => prflUsu = value;
        }
    }
}
