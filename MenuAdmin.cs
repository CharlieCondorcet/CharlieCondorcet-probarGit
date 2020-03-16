using System;

namespace taller_2 {

    /**
     * Clase para despliegue de menus textuales para la interaccion en el usuario.
     */
    class MenuAdmin {

        //Atributos privados de la clase MenuAdmin.
        private string password = "Gatito123";

        /**
         * Constructor de la clase MenuAdmin.
         */
        public MenuAdmin () {

        }

        /**
         * Metodo para desplegar opciones como menu principal y filtro de opcion.
         */
        public int menuPrincipal () {
            Console.WriteLine ("\n\n****** MENU PRINCIPAL ******\n");
            Console.WriteLine ("1.  Agregar un nuevo cliente. ");
            Console.WriteLine ("2.  Agregar un nuevo automóvil. ");
            Console.WriteLine ("3.  Eliminar un cliente. ");
            Console.WriteLine ("4.  Eliminar un automóvil. ");
            Console.WriteLine ("5.  Agregar una nueva reserva. ");
            Console.WriteLine ("6.  Eliminar una reserva. ");
            Console.WriteLine ("7.  Datos del cliente dado un rut. ");
            Console.WriteLine ("8.  Datos del vehículo dada la patente.");
            Console.WriteLine ("9.  Informacion de reserva dado el numero de reserva. ");
            Console.WriteLine ("10. Reservas vigentes y los vehículos asociados dado el rut. ");
            Console.WriteLine ("11. Datos del cliente con reserva dada una patente. ");
            Console.WriteLine ("12. Cantidad de reservas que ha realizado un cliente este mes. ");
            Console.WriteLine ("13. Cantidad de reservas que ha realizado un cliente este año. ");
            Console.WriteLine ("14. Las reservas de un cliente en el mes actual. ");
            Console.WriteLine ("15. Datos del vehículo con más reservas este año. ");
            Console.WriteLine ("16. Ranking con los 10 vehículos con más reservas este año. ");
            Console.WriteLine ("17. Ranking con los 10 clientes con más reservas este año. ");
            Console.WriteLine ("18. Datos del cliente que avaló a un cliente. ");
            Console.WriteLine ("19. Datos de los clientes que han sido avalados por un cliente. ");
            Console.WriteLine ("20. Vehículos que no reservados en los últimos 30 días. ");
            Console.WriteLine ("21. Salir del programa.\n");
            Console.WriteLine ("Digite una opcion para continuar:");

            string opcion = "";
            int numeric_opcion = 0;

            while (true) {
                opcion = Console.ReadLine ();
                try {
                    numeric_opcion = int.Parse (opcion);
                    if (numeric_opcion < 1 || numeric_opcion > 21) {
                        Console.WriteLine ("se debe ingresar una de las opciones disponibles, intentar otra vez.");

                    } else {
                        Console.WriteLine ($"la opcion ingresada es: {numeric_opcion}");
                        break;
                    }
                } catch (System.Exception) {
                    Console.WriteLine ("el formato de la opcion ingresada es incorrecto, intentar otra vez.");
                    numeric_opcion = 0;
                }
            }

            if (numeric_opcion >= 1 && numeric_opcion <= 4) {
                string finalopc = loginParcial ();

                //Se reiniciara el menu, porque estamos volviendo a seleccionar desde el menu principal.
                if (String.Compare (finalopc, "atras") == 0) {
                    return 100;
                }
            }
            return numeric_opcion;
        }

        /**
         * Metodo para las opciones de 1 al 4 devolver la preferencia de actividades.
         */
        public string loginParcial () {
            Console.WriteLine ("\nDebe ingresar el Password para continuar con esta operacion. \nsi desea retroceder ingrese \"back\" o \"atras\". ");
            string opcion = "";

            while (true) {
                opcion = Console.ReadLine ();
                if (String.Compare (opcion, this.password) == 0) {
                    Console.WriteLine ("Password ingresado correctamente.");
                    return "password";

                } else if (String.Compare (opcion, "atras") == 0 || String.Compare (opcion, "back") == 0) {
                    Console.WriteLine ("\nvolviendo al menu principal...");
                    return "atras";
                } else {
                    Console.WriteLine ("Password no reconocido, intentar otra vez. \npasa salir debe ingresar \"back\" o \"salir\". ");
                }
            }
        }

    }
}