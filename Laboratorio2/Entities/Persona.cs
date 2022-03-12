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

        public Persona()
        {
        }
        public Persona (string uuid, string apellidos, string nombres, string email)
        {
            this.UUID = uuid;
            this.Apellidos = apellidos;
            this.Nombres = nombres;
            this.Email = email;
        }
    }
}