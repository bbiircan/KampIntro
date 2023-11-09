// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

//string[] isimler = new string[] { "Rümeysa", "Bircan" };
//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);

//isimler = new string[3];
//isimler[2] = "Eylül Ada";
//Console.WriteLine(isimler[2]);
//Console.WriteLine(isimler[0]);

List<string> isimler2= new List<string> {"Rümeysa","Bircan"};
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
isimler2.Add("Eylül Ada");
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[0]);