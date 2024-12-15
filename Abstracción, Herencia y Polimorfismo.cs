
// 6. ¿Cómo se implementa la herencia en C#?
// La herencia se implementa mediante el uso de la palabra clave "base" en las clases derivadas.
// Ejemplo de herencia:
class Perro : Animal {
    public override void Comer() {
        Console.WriteLine("El perro está comiendo croquetas.");
    }
}

// 7. Da un ejemplo práctico de polimorfismo en C#.
// Polimorfismo: Permite que diferentes objetos (Perro y Gato) usen el mismo método Comer(), pero con comportamientos diferentes.
class Program {
    static void Main(string[] args) {
        List<Animal> animales = new List<Animal> {
            new Perro(),
            new Gato()
        };

        foreach (var animal in animales) {
            animal.Comer(); // El comportamiento cambia dependiendo si es Perro o Gato
        }
    }
}
