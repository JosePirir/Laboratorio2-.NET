using Laboratorio2.Interface;

namespace Laboratorio2.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne {get;set;}
        public string NumeroCreditos{get;set;}

        public bool EliminarAsignatura(string asignatura)
        {
            throw new NotImplementedException();
        }

        public void ListarMisDatos(string identificador)
        {
            throw new NotImplementedException();
        }

        public override void TomarAsistencia()
        {
            throw new NotImplementedException();
        }
        public Alumno()
        {            
        }

        public Alumno(string carne, string numeroCreditos, Persona persona):
        base (persona.UUID, persona.Apellidos, persona.Nombres, persona.Email)
        {
            Carne = carne;
            NumeroCreditos = numeroCreditos;         
        }
    }
}