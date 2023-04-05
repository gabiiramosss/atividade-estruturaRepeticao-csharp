//Faça um programa que leia e valide as seguintes informações:
// 1. Nome: diferente de vazio;
// 2. Idade: entre 0 e 100 anos;
// 3. Salário: maior que zero;
// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

Console.WriteLine($"Insira seu nome: ");
string nome = Console.ReadLine();

while (nome == "")
{
    Console.WriteLine($"Este campo não pode ficar em branco. Preencha corretamente.");
    nome = Console.ReadLine();
}

Console.WriteLine($"Insira sua idade: ");
int idade = int.Parse(Console.ReadLine());

while (idade > 100)
{
    Console.WriteLine($"Idade não corresponde. Preencha corretamente.");
    idade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Insira seu salário: ");
float salario = float.Parse(Console.ReadLine());

while (salario <= 0)
{
    Console.WriteLine($"Seu salário precisa ser maior que 0. Preencha corretamente.");
    salario = float.Parse(Console.ReadLine());
}

Console.WriteLine($"Insira seu estado civil. Digite 's' para solteiro(a), 'c' para casado(a), 'v' para viuvo(a), 'd' para divorciado(a): ");
char estadoCivil = char.Parse(Console.ReadLine());

while (estadoCivil != 's' && estadoCivil != 'c'&& estadoCivil != 'v'&& estadoCivil != 'd')
{
    Console.WriteLine($"O estado civil inserido não corresponde. Digite 's' para solteiro(a), 'c' para casado(a), 'v' para viuvo(a), 'd' para divorciado(a): ");
    estadoCivil = char.Parse(Console.ReadLine());
}

Console.WriteLine($"Dados recebidos com sucesso!");

