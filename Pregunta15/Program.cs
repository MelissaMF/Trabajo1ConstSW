void manageContacts()
{
    Dictionary<string, int> contacts = new Dictionary<string, int>();

    bool keepRunning = true;

    while (keepRunning)
    {
        Console.WriteLine("1. Agregar contacto");
        Console.WriteLine("2. Eliminar contacto");
        Console.WriteLine("3. Mostrar contactos");
        Console.WriteLine("4. Salir");
        Console.Write("Selecciona una opción: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                AddContact();
                break;
            case "2":
                RemoveContact();
                break;
            case "3":
                ShowContacts();
                break;
            case "4":
                keepRunning = false;
                break;
            default:
                Console.WriteLine("Opción inválida. Por favor, selecciona una opción válida.");
                break;
        }
    }


    void AddContact()
    {
        Console.Write("Ingresa el nombre del contacto: ");
        string name = Console.ReadLine();

        Console.Write("Ingresa el número de teléfono del contacto: ");
        int phoneNumber = int.Parse(Console.ReadLine());

        if (!contacts.ContainsKey(name))
        {
            contacts[name] = phoneNumber;
            Console.WriteLine("Contacto agregado con éxito.");
        }
        else
        {
            Console.WriteLine("El contacto ya existe.");
        }
    }

    void RemoveContact()
    {
        Console.Write("Ingresa el nombre del contacto que deseas eliminar: ");
        string name = Console.ReadLine();

        if (contacts.ContainsKey(name))
        {
            contacts.Remove(name);
            Console.WriteLine("Contacto eliminado con éxito.");
        }
        else
        {
            Console.WriteLine("El contacto no existe.");
        }
    }

    void ShowContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No hay contactos");
        }
        Console.WriteLine("Lista de contactos:");
        foreach (var contact in contacts)
        {
            Console.WriteLine($"Nombre: {contact.Key}, Teléfono: {contact.Value}");
        }
    }
}

manageContacts();