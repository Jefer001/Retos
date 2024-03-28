// See https://aka.ms/new-console-template for more information

/*
 * Crea un programa que sea capaz de transformar texto natural a código
 * morse y viceversa.
 * - Debe detectar automáticamente de qué tipo se trata y realizar
 *   la conversión.
 * - En morse se soporta raya "—", punto ".", un espacio " " entre letras
 *   o símbolos y dos espacios entre palabras "  ".
 * - El alfabeto morse soportado será el mostrado en
 *   https://es.wikipedia.org/wiki/Código_morse.
 */

using MorceCode;

Alfabeto_Morce _Morce = new();
string text = Alfabeto_Morce.VerifyText("Hello, World!");
if (text != "") Console.WriteLine(_Morce.Encode(text));