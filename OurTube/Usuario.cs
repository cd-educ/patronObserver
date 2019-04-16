using System;
using System.Collections.Generic;
using System.Text;

namespace OurTube
{
    public class Usuario
    {

        private string username;
        private List<Usuario> subscriptores = new List<Usuario>();

        public Usuario(string username)
        {
            this.username = username;
        }
        
        public void subirVideo(string nombreVideo)
        {
            foreach(Usuario usuario in subscriptores)
            {
                usuario.recibirAviso(this.username, nombreVideo);
            }

        }

        public void recibirAviso(string usuario, string nombreVideo)
        {
            Console.WriteLine(this.username + ", "+ usuario + " ha subido un video. Titulo: " + nombreVideo);
        }

        public void subscribirseA(Usuario usuario)
        {
            usuario.añadirSubscriptor(this);
        }

        public void desubscribirseA(Usuario usuario)
        {
            usuario.quitarSubscriptor(this);
        }

        protected void añadirSubscriptor(Usuario usuario)
        {
            this.subscriptores.Add(usuario);
        }

        protected void quitarSubscriptor(Usuario usuario)
        {
            this.subscriptores.Remove(usuario);
        }

    }
}
