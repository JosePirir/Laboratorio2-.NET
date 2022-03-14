using Laboratorio2.Interface;

namespace Laboratorio2.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string CUI {get;set;}
        public string Cargo {get;set;}

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Tomando asistencia {this.Apellidos} {this.Nombres}");
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"{this.UUID} {this.Apellidos} {this.Nombres} {this.Cargo}");
        }

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura {this.Apellidos} {this.Nombres}");
            return true;
        }

        public Profesor():base()
        {
        }

        public Profesor (string uuid, string apellidos, string nombres, string email, string cui, string cargo):
        base(uuid, apellidos, nombres, email)
        {
            this.CUI = cui;
            this.Cargo = cargo;
        }
    }
}