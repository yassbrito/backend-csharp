Console.WriteLine($"Informe a sua nota: ");
float nota = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a sua frequencia: ");
float frequencia= float.Parse(Console.ReadLine());



if (nota >= 7.0 && frequencia >= 75) {
    Console.WriteLine($"Voce foi aprovado! ");
}

else if (nota <= 7.0 && frequencia < 75) {
    Console.WriteLine($"Voce esta reprovado! ");
}

else {
    Console.WriteLine($"Voce esta de recuperacao!");
}