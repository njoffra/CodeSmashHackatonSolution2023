// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Foo
{
    /*
     * Complete the 'IsBuyerWinner' function below.
     *
     * The function is expected to return an Integer.
     * The function accepts following parameters:
     *  1. List (STRING_ARRAY) - codeList
     *  2. List (STRING_ARRAY) - shoppingCart
     */

    public static int IsBuyerWinner(List<string> codeList, List<string> shoppingCart)
    {
        int j = 0; // indeks trenutnog codeList elemente
        int group = 0; // indeks grupe
        int counter = 0; // brojac koji prati postojanje grupe
        if (codeList.Count == 0) return 1; // ako je prazna korisnik je winner
        for (int i = 0; i < shoppingCart.Count; i++)
        { 
            if (codeList.Count == group) break; // ako dodjemo do zadnje grupe
            string[] current_group = codeList[group].Split(' '); // djelimo trenutnu grupu po rijecima
            if (shoppingCart[i] == current_group[j] || current_group[j] == "anything")
            {
                j++;
                if (current_group.Length == j) // kad dodjemo do kraja grupe ako se sve poklapa
                {
                    counter++; 
                    group++;
                    j = 0; // restart brojaca da bi brojali sljedecu grupu
                }
            }
            else
            {
                j = 0; 
                if (shoppingCart[i] == current_group[j] || current_group[j] == "anything")
                {
                    j++; // ako se podudaraju onda se povecava j, tj. item u grupi. ovdje je implementirana neka vrsta backtrackinga kako ne bi preskakali iteme i kombinacije
                }
            }
        }
        if (counter == codeList.Count) return 1; // ako smo izbrojali da su sve grupe tacne
        else return 0;
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        
        int codeListCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> codeList = new List<string>();

        
        for (int i = 0; i < codeListCount; i++)
        {
            string codeListItem = Console.ReadLine();
            codeList.Add(codeListItem);
        }

      
        int shoppingCartCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> shoppingCart = new List<string>();


       
        for (int i = 0; i < shoppingCartCount; i++)
        {
            string shoppingCartItem = Console.ReadLine();
            shoppingCart.Add(shoppingCartItem);
        }

        int foo = Foo.IsBuyerWinner(codeList, shoppingCart);

        Console.WriteLine(foo);
    }
}

