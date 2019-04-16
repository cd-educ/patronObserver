using System;

namespace OurTube
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creo usuarios
            Usuario user1 = new Usuario("pepit0123");
            Usuario user2 = new Usuario("JuancitoXxGamerxX");
            Usuario user3 = new Usuario("TutorialesByPedro");
            Usuario user4 = new Usuario("ElRubiusxD");

            // Los subscribo a ElRubius
            user1.subscribirseA(user4);
            user2.subscribirseA(user4);
            user3.subscribirseA(user4);

            // Subo video
            user4.subirVideo("Jugando al MineCraft");

            // Pruebo que el usuario que sube un video tambien puede recibir notificaciones
            user4.subscribirseA(user3);
            user3.subirVideo("Como usar Photoshop | Parte 1");

            // Trabo la consola para poder leer los resultado
            Console.ReadLine();

        }
    }
}
