/*Teoria : 1) El polimorfismo por herencia es la capacidad de una Superclase de heredar a sus clases hijas comportamientos y propiedades (Por ejemplo, si tengo una superclase ANIMALES 
 * con la propiead Patas y el metodo Hablar, todas las clases hijas heredaran esa propiedad  esa caracteristica).
 * El polimorfismo por abstraccion nos permite tratar a varios objetos hijos de una superclase asbtracta como un mismo tipo.
 * Por ejemplo, si tengo la superclase USUARIO y las clases hijas EMPLEADO, CLIENTE Y JEFE podre crear un arreglo en en el que puedan estar todos
 * 2)Las expresionas lambda son funciones anonimas que nos permiten realizar operacionas como filtrado, busqueda de indices u objetos, ordenamientos,etc
 * en arreglos.
 * List<int> Enteros = new List<int>();
   int promedio = ((int)Enteros.Average()); //CORRECCIÓN: ESTO NO ES UNA EXPRESIÓN LAMBDA, ES UN MÈTODO LINQ
 * 3)En un parametro por valor se copia el valor original en la direccion de memoria ocupada en ese momento. Si dentro del metodo se modifica el valor
 * de este parametro, el valor original no se vera afectado. En un parametro por referencia no da precisamente un valor como parametro, sino la direc65cion
 * de memoria donde esta el valor original. Por lo tanto, si este valor se modifica dentro de el metodo, el original tambien se modificara. Usa la palabra reservada ref.
 * public void ejemplo(ref List<int> lista, int incremento )
        {
            foreach (int numero in lista)
            {
                numero = numero + numero * incremento;
            }
        }
 * 4)El desarrollo en capas es una tecnica de programacion que nos permite estructurar y organizar el codigo de una aplicacion en capas logicas y separadas.
 * Cada capa cumple una funcion determinada y se comunica con las demas mediante el uso de interfaces. Algunos ejemplos pueden ser: Capa de acceso a datos,
 * capa de logica de negocio, capa de interfaz de usuario. La ventaja que nos trae el desarrollo en capas es una mejor organizacion del codigo, ya que estan
 * bien definido lo que hacen las partes, y si se precisa hacer alguna modificación se puede realizar donde se desee sin afectar a las demas capas. Ademas
 * el desarrollo en capas proprociona una mayor seguridad al codigo
 * 5)Se le llama sobrecarga de metodos a la implementacion de metodos con el mismo nombre, pero que reciben parametros distintos y no necesariamente hacen
 * lo mismo. Con la sobreescritura de datos, tengo un metodo heredado de una superclase, que tendra el mismo nombre en todas las clases hijas, pero que
 * se implementan en base a las necesidades de la clase
 * Ej sobrecarga:(Tengo un metodo Suma(int x, int y) y a su vez puedo tener un metodo Suma(decimal m, decimal l). Estos metodos tienen el mismo nombre, pero reciben parametros diferentes.
 * Ej sobreescritura: Tengo una superclase Animal y las clases hijas Perro, Gato, Vaca. Animal implementara el metodo Hablar() y cada clase lo implemetara como lo necesite (Perro = ladrar)
 * 6)Identidad: Es como se diferencia a este objeto de los demas, puede ser su nombre, tipo.
 * Estado interno: Son las propiedades del objeto en un momento determinado, estas pueden ser modificadas a lo largo de toda la vida del objeto.
 * Comportamiento :Son los metodos que puede invocar este objeto*/
