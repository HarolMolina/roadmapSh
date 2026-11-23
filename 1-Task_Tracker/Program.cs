void Main()
{
    string? entradaUsuario;
    string menuSelectivo = "";

    do
    {
        Console.Clear();

        Console.WriteLine("Pendientes...");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("(A) - Agregar tarea");
        Console.WriteLine("(E) - Editar Tarea");
        Console.WriteLine("(D) - Borrar Tarea");

        entradaUsuario = Console.ReadLine();
        if (entradaUsuario != null)
        {
            menuSelectivo = entradaUsuario.ToLower();
        }
    } while (menuSelectivo != "exit");
}
