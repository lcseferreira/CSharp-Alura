Console.WriteLine("Executando Projeto 4 - Condicionais");

int idadeLucas = 23;

if (idadeLucas >= 18)
{
    Console.WriteLine($"Idade: {idadeLucas}. Pode entrar.");
}
else if (idadeLucas >= 16)
{
    Console.WriteLine($"Idade: {idadeLucas}. Pode entrar acompanhado com os pais.");
}
else
{
    Console.WriteLine($"Idade: {idadeLucas}. Não pode entrar.");
}

// Escopo
int idadeMarcos = 17;
bool acompanhado = false;
string mensagemAdicional;

if (idadeMarcos >= 18 || acompanhado)
{
    if (acompanhado)
    {
        mensagemAdicional = "está acompanhado.";
    }
    else
    {
        mensagemAdicional = "não está acompanhado.";
    }
    Console.WriteLine($"Marcos tem {idadeMarcos} anos e {mensagemAdicional}. Pode entrar.");
}
else
{
    Console.WriteLine("Marcos não pode entrar.");
}