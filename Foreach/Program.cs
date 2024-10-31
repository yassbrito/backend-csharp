string[] frutas = {"melancia", "carambola","maracuja","morango","limao","Jabuticaba",
"abacate","kiwi","acerola","pinha","lichia","pitaya","pessego","banana"};

Console.WriteLine($"Sua sacola contem {frutas.Length} frutas!");

foreach(string f in frutas)
{
    Console.WriteLine(f);
}