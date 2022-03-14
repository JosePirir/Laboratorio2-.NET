using Laboratorio2.Interface;

namespace Laboratorio2.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne {get;set;}
        public int NumeroCreditos{get;set;}

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura de {this.Apellidos} {this.Nombres}, Perderá la cantidad de {this.NumeroCreditos} creditos.");
            return true;
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"{this.UUID} {this.Apellidos} {this.Nombres} {this.NumeroCreditos}");
        }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Tomando asistencia {this.Apellidos} {this.Nombres}");
        }
        public Alumno():base()
        {            
        }

        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos):
        base (uuid, apellidos, nombres, email)
        {
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
        }
    }
}