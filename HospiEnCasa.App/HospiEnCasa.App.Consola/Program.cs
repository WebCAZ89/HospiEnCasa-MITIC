using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente(new Persistencia.AppContext());
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World EF!");
            //AddPaciente();
            BuscarPaciente(1);
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Carlos",
                Apellidos = "Zapata",
                NumeroTelefono = "3175952608",
                Genero = Genero.Masculino,
                Direccion = "Calle 143 B 141 A 10",
                Longitud = 5.00474748F,
                Latitud = -74.99797F,
                Ciudad = "Bogotá",
                FechaNacimiento = new DateTime (1989, 09, 26)

            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
        }
        
        

    }
}