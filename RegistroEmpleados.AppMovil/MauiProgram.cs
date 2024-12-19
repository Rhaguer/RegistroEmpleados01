using Firebase.Database;
using Firebase.Database.Query;
using Microsoft.Extensions.Logging;
using RegistroEmpleados.Modelos.Modelos;

namespace RegistroEmpleados.AppMovil
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            Registrar();
            return builder.Build();


        }

        public static void Registrar()
        {
            FirebaseClient client = new FirebaseClient("https://registroempleados-433b8-default-rtdb.firebaseio.com/");

            var cargos = client.Child("Cursos").OnceAsync<Curso>();

            if (cargos.Result.Count == 0) 
            {
                client.Child("Cursos").PostAsync(new Curso { Nombre = "1er Básico" });
                client.Child("Cursos").PostAsync(new Curso { Nombre = "2do Básico" });
                client.Child("Cursos").PostAsync(new Curso { Nombre = "3ero Básico" });
                client.Child("Cursos").PostAsync(new Curso { Nombre = "4to Básico" });
                client.Child("Cursos").PostAsync(new Curso { Nombre = "5to Básico" });
                client.Child("Cursos").PostAsync(new Curso { Nombre = "6to Básico" });
                client.Child("Cursos").PostAsync(new Curso { Nombre = "7mo Básico" });
                client.Child("Cursos").PostAsync(new Curso { Nombre = "8vo Básico" });
                client.Child("Cursos").PostAsync(new Curso { Nombre = "1er Medio" });
                client.Child("Cursos").PostAsync(new Curso { Nombre = "2do Medio" });
                client.Child("Cursos").PostAsync(new Curso { Nombre = "3ero Medio" });
                client.Child("Cursos").PostAsync(new Curso { Nombre = "4to Medio" });
            }
        }
    }
}
