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

    }
}