
// 1. ¿Cuáles son los cuatro pilares de la Programación Orientada a Objetos?
// Los cuatro pilares de la POO son:
// - Abstracción
// - Encapsulamiento
// - Herencia
// - Polimorfismo

// 2. Explica en qué consiste la abstracción en POO.
// La abstracción consiste en ocultar los detalles complejos y mostrar solo la información necesaria.
// Ejemplo de abstracción: Clase Animal con un método abstracto Comer(), donde no se define cómo se come,
public abstract class Animal {
    public string Nombre { get; set; }
    public abstract void Comer(); // Método abstracto, debe ser implementado por clases derivadas
}

// 3. ¿Qué es la herencia y para qué se utiliza?
// La herencia permite a una clase derivada heredar atributos y métodos de una clase base. 
// Esto facilita la reutilización de código y la creación de jerarquías de clases.
class Perro : Animal {
    public override void Comer() {
        Console.WriteLine("El perro está comiendo croquetas.");
    }
}

// 4. Define el concepto de polimorfismo con un ejemplo.
// El polimorfismo permite que diferentes clases tengan el mismo nombre de método, pero con implementaciones distintas.
// Ejemplo de polimorfismo: El método Comer() tiene comportamientos diferentes dependiendo de si el objeto es un Perro o un Gato.
public class Gato : Animal {
    public override void Comer() {
        Console.WriteLine("El gato está comiendo pescado.");
    }
}

// 5. ¿Qué se entiende por encapsulamiento?
// El encapsulamiento consiste en ocultar el estado interno de un objeto y proporcionar métodos públicos (getter y setter)
// para acceder o modificar ese estado.
class Persona {
    private string nombre; // Atributo privado
    public string Nombre { // Getter y Setter públicos
        get { return nombre; }
        set { nombre = value; }
    }
}
