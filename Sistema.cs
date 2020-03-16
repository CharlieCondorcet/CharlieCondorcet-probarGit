using System;

namespace taller_2 {

    /**
     * Clase Sistema para ejecutar administracion principal de requerimientos.
     */
    class Sistema {

        //Atributos privados de la clase Sistema.
        private MenuAdmin misMenus = new MenuAdmin ();

        /**
         * Constructor de la clase Sistema.
         */
        public Sistema () {

        }

        /**
         * Metodo para intersectar la opcion elegida por menu con la funcion deseada hasta salir del programa.
         */
        public void App () {

            while (true) {
                int opcionMenu = this.misMenus.menuPrincipal ();
                switch (opcionMenu) {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;

                }

                if (opcionMenu == 21) {
                    Console.WriteLine ("\nSALIENDO DEL SISTEMA...\n");
                    return;
                }
            }

        }

    }

}