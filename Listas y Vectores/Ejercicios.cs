using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class ListasYVectores
    {
        public void inicio(int ejercicio)
        {
            switch(ejercicio)
                { 
                case 1:
                    ejercicio1();
                    break;
                case 2:
                    ejercicio2();
                    break;
                case 3:
                    ejercicio3();
                    break;
                case 4:
                    ejercicio4();
                    break;
                case 5:
                    ejercicio5();
                    break;
                case 6:
                    ejercicio6();
                    break;
                case 7:
                    ejercicio7();
                    break;
                case 8:
                    ejercicio8();
                    break;
            }
        }
        private void ejercicio1()
        {
            //Vector que almacena los nombres pedidos
            string[] names = new string[9] { "Frodo", "Sam", "Meriadoc", "Peregrin", "Gimli", "Legolas", "Gandalf", "Aragorn", "Boromi"};
           
            //Lista que recibe datos que cargue el usuario
            List<string> userData = new List<string>();
            Console.WriteLine("¿Cuántos datos desea ingresar?");
            int cantidadDatos = int.Parse(Console.ReadLine());
            for(int i = 0; i < cantidadDatos; i++)
            {
                userData.Add(Console.ReadLine());
            }
            Console.WriteLine("Usted ha ingresado:");
            foreach (string item in userData)
            {
                Console.WriteLine($"\n{item}");
            }

        }

        private void ejercicio2()
        {
            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine("Ingrese 10 números, uno abajo del otro.");
            for (int index = 0; index < 10; index++)
            {
                numeros[index] = int.Parse(Console.ReadLine());
            }

            // Comparo elementos de la lista y almaceno el menor y el mayor
            int mayor = numeros[0];
            int menor = numeros[0];
            for(int index = 0; index < 10; index++)
            {
                if(mayor < numeros[index]) mayor = numeros[index];
                if (menor > numeros[index]) menor = numeros[index];
            }
            Console.WriteLine($"El número mayor ingresadoe es {mayor} y el menor es {menor}");
        }

        private void ejercicio3()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Ingrese 15 números, uno abajo del otro.");
            for (int index = 0; index < 15; index++) numeros.Add(int.Parse(Console.ReadLine()));

            //Contar cantidad de 3s en la lista
            int cantidadDeTres = 0;
            foreach(int item in numeros) if (item == 3) cantidadDeTres++;

            Console.WriteLine($"Has ingresado el 3 unas {cantidadDeTres} veces.");
        }

        private void ejercicio4()
        {
            List<double> sueldos = new List<double>();
            Console.WriteLine("Ingrese sus 12 sueldos.");
            for (int index = 0; index < 12; index++) sueldos.Add(double.Parse(Console.ReadLine()));

            //Sumar sueldos
            double sumaSueldos = 0;
            foreach (double item in sueldos)
            {
                sumaSueldos += item;
            }

            Console.WriteLine($"El ingreso total de estos 12 meses es {sumaSueldos} pesos, lo cual es en promedio {sumaSueldos/12} pesos por mes.");
        }

        private void ejercicio5()
        {
            List<string> ciudades = new List<string>();
            List<float> temperaturasMinimas = new List<float>();
            List<float> temperaturasMaximas = new List<float>();

            Console.WriteLine("Deberá ingresar los datos de únicamente 5 ciudades.");
            for (int index = 0; index < 5; index++)
            {
                Console.WriteLine("Ingrese una ciudad:");
                ciudades.Add(Console.ReadLine());
                Console.WriteLine("Ingrese su temperatura mínima alcanzada esta semana:");
                temperaturasMinimas.Add(float.Parse(Console.ReadLine()));
                Console.WriteLine("Ingrese su temperatura máxima alcanzada esta semana:");
                temperaturasMaximas.Add(float.Parse(Console.ReadLine()));
            }
            // Comparo elementos de la lista y me quedo con los ÍNDICES únicamente
            int indiceMayor = 0;
            int indiceMenor = 0;
            for (int index = 0; index < 5; index++)
            {
                if (temperaturasMaximas[indiceMayor] < temperaturasMaximas[index]) indiceMayor = index;
                if (temperaturasMinimas[indiceMenor] > temperaturasMinimas[index]) indiceMenor = index;
            }

            Console.WriteLine($"La ciudad con temperatura más baja esta semana fue {ciudades[indiceMenor]} con {temperaturasMinimas[indiceMenor]} grados y la ciudad con temperatura más alta fue {ciudades[indiceMayor]} con {temperaturasMaximas[indiceMayor]} grados.");
            //Esto vale pues el índice de una ciudad con sus temperaturas es el mismo
        }

        private void ejercicio6() //no funciona
        {
            int[] tablaUno = tablaDeN(1);
            int[] tablaDos = tablaDeN(2);
            int[] tablaTres = tablaDeN(3);
            int[] tablaCuatro = tablaDeN(4);
            int[] tablaCinco = tablaDeN(5);
            int[] tablaSeis = tablaDeN(6);
            int[] tablaSiete = tablaDeN(7);
            int[] tablaOcho = tablaDeN(8);
            int[] tablaNueve = tablaDeN(9);
            int[] tablaDiez = tablaDeN(10);
            
            for(int i= 0; i<= 9; i++) Console.WriteLine(tablaDiez[i]); //pido que me muestre alguna lista nada más para chequear
        }

        int[] tabla = new int[10];
        int[] multiplicadores = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private int[] tablaDeN(int n)
        {
            int index = 0;
            foreach (int item in multiplicadores) 
            {
                tabla[index] = item * n;
                index++;
            }
            return tabla;
        }

        private void ejercicio7()
        {
            List<float> positivosHastaNegativo = new List<float>();
            Console.WriteLine("Ingrese numeros positivos y al menos un negativo.");
            float numero = float.Parse(Console.ReadLine());
            if(numero < 0) Console.WriteLine("El promedio de los numeros positivos obtenidos es 0.");
            while (numero >= 0) 
            {
                positivosHastaNegativo.Add(numero);
                numero = float.Parse(Console.ReadLine());
            }

            Console.WriteLine($"El promedio de los numeros positivos obtenidos es {totales(positivosHastaNegativo)/positivosHastaNegativo.Count()}.");
        }

        private float totales(List<float> datos)
        {
            float sumaTotal = 0;
            foreach (int item in datos)
            {
                sumaTotal += item;
            }
            return sumaTotal;
        }

        private void ejercicio8() //SELECTION SORT
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Indique la cantidad de números que quiere ingresar:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese {n} números, uno abajo del otro.");
            for(int a = 0; a<n; a++)
            {
                int numero = numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }
            //List<int> numerosOrdenados = numeros.OrderBy(numero=>numero).ToList();
            //int maximo = numerosOrdenados.Last();
            //Console.WriteLine($"El máximo es {maximo}.");

            int i = 0;
            while (i < n)
            {
                int indiceMenor = indiceMinSubsec(numeros, i, n - 1); // busco el indice del menor numero entre los elementos numero[i], ... , numero[n-1]
                int primerNumero = numeros[i]; //ubico al que quiero poner primero en la subsecuencia
                numeros[i] = numeros[indiceMenor];//lo cambio por el número menor de la subsecuencia
                numeros[indiceMenor] = primerNumero;//guardo el valor del numero cambiado en donde anteriormente se encontraba el otro
                i++;

            }
            //Console.WriteLine("La lista ordenada de forma ascendente es:");
            //for (int a = 0; a < n; a++) Console.WriteLine(numerosOrdenados[a]);
            Console.WriteLine("La lista ordenada de forma ascendente es:");
            for (int a = 0; a < n; a++) Console.WriteLine(numeros[a]);8

        }

        //Esta funcion compara elementos entre el indicePrimero y el indiceUltimo de una lista, devuelve el indice del valor mínimo de esa subsecuencia
        //Es decir, compara dentro de la subsecuencia numeros[i], ..., numeros[n-1]
        //Esto es necesario para chequear que se ordenen todos los elementos de la lista
        private int indiceMinSubsec(List<int> lista, int indicePrimero, int indiceUltimo)
        {
            int menorIndice = indicePrimero; //se inicializa con el primer indice
            for(int i = indicePrimero; i<=indiceUltimo; i++) // recorre toda la subsecuencia
            {
                if (lista[i] <= lista[menorIndice])
                {
                    menorIndice = i; //compara elementos y retiene el indice del menor elemento
                }
                else
                {
                    menorIndice = menorIndice;
                }

            }
            return menorIndice;
        }

    }
}
