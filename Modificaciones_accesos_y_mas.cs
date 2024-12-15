
// 7. ¿Qué es el acoplamiento en POO, y cómo se puede minimizar?
// El acoplamiento se refiere a la dependencia entre clases. Se puede minimizar utilizando interfaces y clases abstractas,
// de forma que las clases dependan de abstracciones y no de implementaciones específicas.
class Persona {
    private string nombre;
    public string Nombre { get; set; }
}

// 8. Explica qué es un constructor en una clase.
// Un constructor es un método especial que se ejecuta cuando se crea una instancia de la clase.
public class Persona {
    public Persona(string nombre) { // Constructor con parámetro
        this.nombre = nombre;
    }
}

// 9. ¿Qué es la sobrecarga de métodos?
// La sobrecarga de métodos permite definir varios métodos con el mismo nombre, pero con diferentes parámetros.
public class Calculadora {
    public int Sumar(int a, int b) {
        return a + b;
    }
    public double Sumar(double a, double b) {
        return a + b;
    }
}

// 10. ¿Qué significa que un método sea virtual?
// Un método virtual puede ser sobrescrito (override) en una clase derivada para cambiar su implementación.
class Animal {
    public virtual void Comer() {
        Console.WriteLine("El animal está comiendo.");
    }
}

class Perro : Animal {
    public override void Comer() {
        Console.WriteLine("El perro está comiendo croquetas.");
    }
}

// 11. ¿Cuál es la diferencia entre una interfaz y una clase abstracta?
// Una interfaz define un contrato sin implementación, mientras que una clase abstracta puede proporcionar una implementación parcial.
public interface IMascota {
    void Jugar();
    void SaludarDuenio();
}

public class Perro : IMascota {
    public void Jugar() {
        Console.WriteLine("El perro está jugando.");
    }

    public void SaludarDuenio() {
        Console.WriteLine("El perro saluda a su dueño.");
    }
}

// 12. ¿Qué es un modificador de acceso y cuáles son los más comunes en C#?
// Los modificadores de acceso controlan la visibilidad de los miembros de una clase.
// Los más comunes son: public, private, protected, internal y protected internal.
class Persona {
    public string Nombre { get; set; }
    private int Edad { get; set; }
}
