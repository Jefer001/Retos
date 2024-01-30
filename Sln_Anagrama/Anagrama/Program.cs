// See https://aka.ms/new-console-template for more information
using Anagrama;

/*
 * Escribe una función que reciba dos palabras (String) y retorne
 * verdadero o falso (Bool) según sean o no anagramas.
 * - Un Anagrama consiste en formar una palabra reordenando TODAS
 *   las letras de otra palabra inicial.
 * - NO hace falta comprobar que ambas palabras existan.
 * - Dos palabras exactamente iguales no son anagrama.
 */

Console.WriteLine("Enter the first word");
string word = Console.ReadLine().Trim();
Console.WriteLine("Enter the second word");
string word2 = Console.ReadLine().Trim();
if (Methods.IsAnagrama(word, word2)) Console.WriteLine("Es Anagrama");
else Console.WriteLine("No es anagrama");