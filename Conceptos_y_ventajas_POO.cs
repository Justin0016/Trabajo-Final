
// 1. ¿Qué es un objeto en POO?
// Un objeto es una instancia de una clase. Es un conjunto de atributos y métodos definidos en la clase.
Perro perro = new Perro();
perro.Comer(); // Salida: El perro está comiendo croquetas.

// 2. Define el término clase en POO.
// Una clase es un plano o plantilla que define los atributos y comportamientos de un objeto.
public class Animal {
    public string Nombre { get; set; }
    public void Comer() {
        Console.WriteLine("El animal está comiendo.");
    }
}

// 3. ¿Qué son los atributos de una clase?
// Los atributos son las variables dentro de una clase que definen el estado del objeto.
class Animal {
    public string Nombre { get; set; } // Atributo Nombre
}

// 4. ¿Qué son los métodos de una clase?
// Los métodos son las funciones dentro de una clase que definen el comportamiento del objeto.
class Animal {
    public void Comer() {
        Console.WriteLine("El animal está comiendo.");
    }
}

// 5. Explica la diferencia entre una clase base y una clase derivada.
// La clase base es la clase principal y la clase derivada hereda los atributos y métodos de la clase base.
// Ejemplo:
public class Animal {
    public string Nombre { get; set; }
    public void Comer() {
        Console.WriteLine("El animal está comiendo.");
    }
}

public class Perro : Animal {
    public void Ladrar() {
        Console.WriteLine("¡Guau!");
    }
}

// 6. ¿Qué ventajas tiene utilizar la POO frente a la programación estructurada?
// Ventajas: Reutilización de código, fácil mantenimiento, flexibilidad, modularidad y escalabilidad.
// La POO facilita el manejo de proyectos grandes y complejos debido a su enfoque modular.
