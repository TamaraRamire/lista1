using System;
  namespace miLibreta {

    class miClase{

        static void Mainx(){

            // así funciona el vector 

            int[] vec = new int [2];

            vec[0] = 10;
            vec[1] = 15;

            Console.WriteLine("vamos con la clase");
            Console.WriteLine(vec [0]);
            Console.WriteLine(vec [1]);

            // así fuunciona la lista
            List<int> miLista = new List<int>();

            miLista.Add(10);
            miLista.Add(15);
            miLista.Add(21);

            Console.WriteLine("tamaño Lista: {0}", miLista.Count);

            Console.WriteLine("recorriendo Lista con foreach");
            foreach( var x in miLista){
               Console.WriteLine("elemento: {0}", x );

            }

            
        }
    }
}