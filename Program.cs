using System;


//CREACION DE CLASES E INSTANCIAS
namespace EjemploPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIAS DE CLASE

            //Primera instacia de clase circulo
            Circulo miCirculo;  //creacion de objeto de tipo Circulo. Variable/Objeto de tipo Circulo

            miCirculo = new Circulo();//iniciacion de variable/objeto de tipo Circulo--> Instanciar una clase

            Console.WriteLine(miCirculo.calculoArea(5));//veremos el area e consola

            //segunda instancia de Circulo

            Circulo miCirculoDos = new Circulo(); //inicilizacion de una variable durante su creacion

            Console.WriteLine(miCirculoDos.calculoArea(10));

        }
    }


    //CLASES

    //clases para crear circulos de diferentes areas Area de un circulo es= PI * radio^2
    //la clase circulo sera capaz de crear objeto del tipo circulo
    class Circulo
    {
        //propiedades --> caracteristicas
        const double pi = 3.1416;//Propiedad de la clase circulo--> Campo de clase --constante de clase 

        //metodos ---> que pueden hacer nuestros circulos        
        public double calculoArea(int radio)//Metodo de la clase-->comportamiento del metodo de mi clase
        {

            return pi * radio * radio;

        }

        /*usamos public para permitir el acceso a los metodos y propiedades de una clase ya que al no declarar
        una un metodo como publico se hara presente el atributo de encapsulacion que trata de protejer el codigo
        de una clase desde accesos externos
        */
    }


}
