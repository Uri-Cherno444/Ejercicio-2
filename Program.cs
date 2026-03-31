namespace ejercicio02;

class Program
{
    static void Main(string[] args)
    {
        //Inicializar el diccionario con al menos 3 recursos y sus cantidades.
        Dictionary<string, int> inventario = new Dictionary<string, int>();
        inventario.Add("madera", 5);
        inventario.Add("vidrio", 0);
        inventario.Add("oro", 10);
        
        //Menú 
        int opcion;

        do {
            Console.Clear();
            opcion = Funciones.IngresarNumero("Ingrese opción:");

            switch(opcion) {
                case 1:
                 //Ver inventario
                foreach(string item in inventario.Keys) {
                    Console.WriteLine("MATERIAL: " + item + ", STOCK: " + inventario[item]);
                }
                break;
                
                case 2:
                string recursoSumar = Funciones.IngresarTexto("Ingrese recurso:").ToLower();
                int cantidadSumar = Funciones.IngresarNumero("Ingrese cantidad a sumar:");
                if(inventario.ContainsKey(recursoSumar)&& cantidadSumar >= 1) {
                    inventario[recursoSumar] += cantidadSumar;
                } else {
                    inventario.Add(recursoSumar, cantidadSumar);
               }

                break;
                case 3:
                string recursoRestar = Funciones.IngresarTexto("Ingrese recurso:").ToLower();
                int cantidadRestar = Funciones.IngresarNumero("Ingrese cantidad a restar:");
                if(inventario.ContainsKey(recursoRestar) && cantidadRestar >= 1) {
                    inventario[recursoRestar] -= cantidadRestar;
                    if(inventario[recursoRestar] < 5){
                        Console.WriteLine("ALERTA: REABASTECER " + recursoRestar);
                    }
                } 
                break;
                case 4: 
                string recurso = Funciones.IngresarTexto("Ingrese recurso:").ToLower();
                if(inventario.ContainsKey(recurso)){
                    Console.WriteLine("MATERIAL: " + recurso + ", STOCK: " + inventario[recurso]);
                }else{
                    Console.WriteLine("El material no existe");
                }
                break;
                case 5:
                Console.WriteLine("Saliste del programa...");
                break;
            }
            Console.ReadLine();

        } while(opcion != 5);
        

        //Opción 4: Consultar un recurso específico que el usuario ingresa por teclado y mostrar su información.

        //Opción 5: Salir del programa
    }


}