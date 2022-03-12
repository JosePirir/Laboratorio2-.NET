using Laboratorio2.Interface;

namespace Laboratorio2.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string CUI {get;set;}
        public string Cargo {get;set;}

        public override void TomarAsistencia()
        {

        }

        public void ListarMisDatos(string identificador)
        {
            throw new NotImplementedException();
        }

        public bool EliminarAsignatura(string asignatura)
        {
            throw new NotImplementedException();
        }

        public Profesor()
        {
        }
        
        public Profesor (string cui, string cargo, Persona persona): 
        base(persona.UUID, persona.Apellidos, persona.Nombres, persona.Email)
        {
            CUI = cui;
            Cargo = cargo;
        }
    }
}