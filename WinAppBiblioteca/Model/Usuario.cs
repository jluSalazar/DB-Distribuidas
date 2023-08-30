using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppBiblioteca.Model
{
    internal class Usuario
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool ismaster { get; set; }

        public Usuario() { 
        
        }
    }
}
