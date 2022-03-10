using Laboratorio2.Interface;
namespace Laboratorio2.Entities
{
    public abstract class Persona
    {
        public string UUID;
        public string Apellidos;
        public string Nombres;
        public string Email;
        public abstract void TomarAsistencia();
    }
}