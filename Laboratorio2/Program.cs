using Laboratorio2.Entities;
using Laboratorio2.Interface;
/*Esta es la rama dev*/
public class Program
{
    private static List<Persona> ListaGeneral = new List<Persona>(); /*<- Se crea una lista con objetos Persona*/

    public static void OperarRegistro(Persona elemento)
    {
        ListaGeneral.Add(elemento);
    }

    public static void RegistrarAsistencia(Persona elemento)
    {
        foreach(Persona registro in ListaGeneral)
        {
            if(registro.UUID == elemento.UUID)
            {
                elemento.TomarAsistencia();
            }
        }
    }

    public static void VerMisDatos(Persona elemento)
    {
        if (elemento is Alumno)
        {
            Alumno auxiliar = (Alumno)elemento;
            auxiliar.ListarMisDatos(auxiliar.Carne);
        }
        else if (elemento is Profesor)
        {
            Profesor auxiliar = (Profesor)elemento; /*Creamos un objeto de tipo Profesor y (Profesor)elemento; <-------- Convierte elemento a un objeto de tipo Profesor*/
            auxiliar.ListarMisDatos(auxiliar.CUI);
        }
    }

    public static void QuitarAsignatura(Persona elemento, string asignatura)
    {
        ((IOperaciones)elemento).EliminarAsignatura(asignatura);
    }

    public static void Main(string[] args)
    {

        Alumno alumno1 = new Alumno("123", "Pirir Romero", "Jose Sebastian", "jpirir@gmail.com", "2017059", 77);
        Profesor profesor1 = new Profesor("767","Mancilla Paz","Raul Antonio","rmancilla@kalum.edu.gt","2489392620102","Instructor de informática");

        OperarRegistro(alumno1);
        OperarRegistro(profesor1);

        RegistrarAsistencia(alumno1);
        RegistrarAsistencia(profesor1);

        VerMisDatos(alumno1);
        VerMisDatos(profesor1);

        QuitarAsignatura(alumno1, "Fisica");
        QuitarAsignatura(profesor1, "Lenguaje");
    }
}