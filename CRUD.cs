// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.ComponentModel.Design;using System.Linq.Expressions;
using System.Text.RegularExpressions;

const bool conf = true;
ArrayList pes = new ArrayList();
while (conf)
{
    switch (Menuzin())
    {
        case 1:
            CadastraUsuarios();
            break;
        case 2:
            VisualizaUsuarios();
            break;
        case 3:
            EditaUsuarios();
            break;
        case 4:
            ExcluiUsuarios();
            break;
        case 0:
            int exitCode = 0;
            Environment.Exit(exitCode);
            break;
    }
}

return;

static int Menuzin()
{
    Console.WriteLine("\n** MENU **");
    Console.WriteLine("1. Cadastro ");
    Console.WriteLine("2. Visualização ");
    Console.WriteLine("3. Edição ");
    Console.WriteLine("4. Exclusão ");
    Console.WriteLine("0. Sair ");
    var menu = System.Convert.ToInt32(Console.ReadLine());
    return menu;
}

void CadastraUsuarios()
{
    Console.WriteLine("Insira o nome a ser cadastrado: ");
    pes.Add(Console.ReadLine());
    Console.WriteLine("Usuário Cadastrado, voltando ao menu!");
}

void VisualizaUsuarios()
{
    Console.WriteLine("Segue lista de usuários: ");
    foreach (string x in pes)
    {
        Console.WriteLine(x);
    }
}

void EditaUsuarios()
{
    Console.WriteLine("Deseja buscar por nome ou pelo ID? (1 = Nome | 2 = ID)");
    int edit = System.Convert.ToInt32(Console.ReadLine());
    if (edit == 1)
    {
        Console.WriteLine("Insira o nome a ser editado: ");
        string? nomeX = Console.ReadLine();
        for (int i = 0 ; i < pes.Count; i++)
        {
            if (pes.Contains(nomeX))
            {
                Console.WriteLine("Qual será o novo nome? ");
                pes.Add(Console.ReadLine());
                pes.Remove(nomeX);
            }
            else
            {
                Console.Write("Nome não está cadastrado");
            }
        }
                    
    } else if (edit == 2)
    {
        for (int i = 0; i < pes.Count; i++)
        {
            Console.WriteLine(i + " - {0}", pes[i]);
            Console.WriteLine("Escolha o ID do nome a ser editado: ");
            var id = Convert.ToInt32(Console.ReadLine());
            pes.Remove(pes[id]);
        }
        Console.WriteLine("Digite o novo nome: ");
        pes.Add(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("\nNúmero inválido.");
    }
}

void ExcluiUsuarios()
{
    Console.WriteLine("\nDeseja buscar por nome ou pelo ID? (1 = Nome | 2 = ID)");
    var resp = System.Convert.ToInt32(Console.ReadLine());
    if (resp == 1)
    {
        Console.WriteLine("\nInsira o nome a ser excluído: ");
        string? nomeX = Console.ReadLine();
        for (int i = 0; i < pes.Count; i++)
        {
            if (pes.Contains(nomeX))
            {
                pes.Remove(nomeX);
            }
            else
            {
                Console.Write("Nome não está cadastrado");
            }
        }

    } else if (resp == 2)
    {
        for (int i = 0; i < pes.Count; i++)
        {
            Console.WriteLine(i + " + {0}", pes);
            Console.WriteLine("Escolha o ID do nome a ser excluído: ");
            var id = Convert.ToInt32(Console.ReadLine());
            pes.Remove(pes[id]);
            Console.WriteLine("Nome excluído com sucesso!");
        }
    }
    else
    {
        Console.WriteLine("\nNumero inválido.");
    }

}
