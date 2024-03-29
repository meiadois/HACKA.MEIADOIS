﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HACKA.MEIADOIS.UI.Api
{
    public class Estatisticas
    {

        static public double calcularMedia(double[] listaValores)
        {
            double resultadoMedia = 0.0;
            double somatorio = 0.0;
            int tamanhoVetor = listaValores.Length;

            for (int i = 0; i < tamanhoVetor; i++)
            {
                somatorio = somatorio + listaValores[i];
            }

            resultadoMedia = somatorio / tamanhoVetor;

            return resultadoMedia;
        }

        //Procura e retorna o menor valor de uma lista de valores
        static public double obterMinimo(double[] listaValores)
        {
            // É inicializado com o maior valor possivel,
            // para qualquer valor que vier seja menor que esse.
            double valorMinimo = double.PositiveInfinity;

            for (int i = 0; i <= listaValores.Length - 1; i++)
            {
                if (listaValores[i] < valorMinimo)
                    valorMinimo = listaValores[i];
            }
            return valorMinimo;
        }

        //Procura e retorna o maior valor de uma lista de valores
        static public double obterMaximo(double[] listaValores)
        {
            // É inicializado com o menor valor possivel,
            // para que qualquer valor que vier seja maior que esse.
            double valorMaximo = double.NegativeInfinity;

            for (int i = 0; i <= listaValores.Length - 1; i++)
            {
                if (listaValores[i] > valorMaximo)
                    valorMaximo = listaValores[i];
            }
            return valorMaximo;
        }

        //Calcula e retorna o desvio padrão de um vetor de números
        static public double calcularDesvioPadrao(double[] listaValores)
        {
            double mediaAritimetica = listaValores.Average();
            double somatorio = 0.0;
            int tamanhoVetor = listaValores.Length;

            for (int i = 0; i < tamanhoVetor; i++)
            {
                somatorio = somatorio + Math.Pow(listaValores[i] - mediaAritimetica, 2);
            }

            double valorVariancia = 0.0;
            double valorDesvioPadrao = 0.0;

            // soma dos quadrados da diferença entre cada valor e
            // a média aritmética, dividida pela quantidade de elementos observados.
            valorVariancia = somatorio / tamanhoVetor;

            // Desvio padrão é a raiz quadrada da variância.
            valorDesvioPadrao = valorVariancia;

            return valorDesvioPadrao;
        }

        // Calcula e retorna o valor da Mediana (estatística)
        static public double calcularMediana(double[] listaValores)
        {
            //Ordena o vetor
            double[] listaValoresOrdenada = listaValores.ToArray();
            Array.Sort(listaValoresOrdenada);

            double valorMediana = 0.0;

            bool numElementosImpar = (listaValoresOrdenada.Length % 2 != 0);
            if (numElementosImpar)
            // Caso a lista tenha numero impar de elementos, 
            // o resultado será o valor da posição do meio
            {
                int posicao = (listaValoresOrdenada.Length + 1) / 2;
                valorMediana = listaValoresOrdenada[posicao - 1];
            }

            else
            // Caso a lista tenha número par de elementos,
            // o resultado será a média dos valores do meio
            {
                int posicao1 = (listaValoresOrdenada.Length / 2);
                int posicao2 = (listaValoresOrdenada.Length / 2) + 1;

                valorMediana = (listaValoresOrdenada[posicao1 - 1] + listaValoresOrdenada[posicao2 - 1]) / 2;
            }

            return valorMediana;
        }
    }
}