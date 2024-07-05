using System;
 namespace miLibreta{

    class Clase{

        static void Main(){

            List<string> Alumnos = new List<string>();

            Alumnos.Add("pedro");
            Alumnos.Add("tami");

            foreach(var alu in Alumnos){
                Console.WriteLine("Alumnos: {0}", alu);

            }
            Console.WriteLine("tamaño Lista: {0}", Alumnos.Count);


        }
    }
 }