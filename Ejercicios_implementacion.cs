
// Clase abstracta Animal
public abstract class Animal {
    public string Nombre { get; set; }
    public abstract void Comer(); // Método abstracto, debe ser implementado en clases derivadas

    public void Dormir() {
        Console.WriteLine("El animal está durmiendo.");
    }
}

// Clases derivadas de Animal
public class Perro : Animal {
    public override void Comer() {
        Console.WriteLine("El perro está comiendo croquetas.");
    }
}

public class Gato : Animal {
    public override void Comer() {
        Console.WriteLine("El gato está comiendo pescado.");
    }
}

// Uso de interfaces
public interface IMascota {
    void Jugar();
    void SaludarDuenio();
}

public class Perro : Animal, IMascota {
    public override void Comer() {
        Console.WriteLine("El perro está comiendo croquetas.");
    }

    public void Jugar() {
        Console.WriteLine("El perro está jugando.");
    }

    public void SaludarDuenio() {
        Console.WriteLine("El perro saluda a su dueño.");
    }
}

public class Gato : Animal, IMascota {
    public override void Comer() {
        Console.WriteLine("El gato está comiendo pescado.");
    }

    public void Jugar() {
        Console.WriteLine("El gato está jugando.");
    }

    public void SaludarDuenio() {
        Console.WriteLine("El gato saluda a su dueño.");
    }
}

// Polimorfismo en acción
class Program {
    static void Main(string[] args) {
        List<Animal> animales = new List<Animal> {
            new Perro(),
            new Gato()
        };

        foreach (var animal in animales) {
            animal.Comer();
            animal.Dormir();
        }
    }
}
