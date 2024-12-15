
// 1. ¿Cómo se declara un objeto en C#?
// Se crea una instancia de una clase con la palabra "new".
Persona persona = new Persona();

// 2. ¿Qué sucede si no se declara un constructor en una clase?
// Si no se declara un constructor, C# proporciona uno por defecto que inicializa los atributos con valores predeterminados.
public class Persona {
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

// 3. Código para implementar una clase Persona con los atributos Nombre y Edad.
public class Persona {
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

// 4. ¿Qué es un getter y un setter? Da un ejemplo en C#.
public class Persona {
    private string nombre;
    public string Nombre {
        get { return nombre; }
        set { nombre = value; }
    }
}

// 5. ¿Cómo se utiliza la palabra clave override en C#?
// La palabra clave "override" permite cambiar la implementación de un método heredado.
public class Animal {
    public virtual void Comer() {
        Console.WriteLine("El animal está comiendo.");
    }
}

public class Perro : Animal {
    public override void Comer() {
        Console.WriteLine("El perro está comiendo croquetas.");
    }
}

// 6. Explica el uso de la palabra clave base en C#.
// La palabra clave "base" se utiliza para hacer referencia a los miembros de la clase base.
public class Animal {
    public void Comer() {
        Console.WriteLine("El animal está comiendo.");
    }
}

public class Perro : Animal {
    public void Comer() {
        base.Comer(); // Llama al método Comer() de la clase base
        Console.WriteLine("El perro está comiendo croquetas.");
    }
}
