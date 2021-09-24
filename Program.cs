using System;
using System.Collections.Generic;
using System.Linq;

namespace OrientaçãoaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exec 01

            //Pessoa pes = new Pessoa();
            //Console.WriteLine("Preencha esta pessoa");
            //pes.nome = Console.ReadLine();
            //pes.idade = int.Parse(Console.ReadLine());
            //pes.cpf = Console.ReadLine();
            //pes.endereco = Console.ReadLine();
            //Console.WriteLine("-----------//-----------");
            //Console.WriteLine(pes.nome);
            //Console.WriteLine(pes.idade);
            //Console.WriteLine(pes.cpf);
            //Console.WriteLine(pes.endereco);

            //exec 02

            //List<Cachorro> doginhos = new List<Cachorro>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Insira o doguinho");
            //    Cachorro cao = new Cachorro();
            //    cao.nome = Console.ReadLine();
            //    cao.nomeDoDono = Console.ReadLine();
            //    cao.idade = Convert.ToInt32(Console.ReadLine());
            //    doginhos.Add(cao);
            //}
            //Console.WriteLine("-----------//----------");

            //foreach (var item in doginhos)
            //{
            //    if (item.idade > 6)
            //    {
            //        Console.WriteLine(item.nome);
            //        Console.WriteLine(item.nomeDoDono);
            //        Console.WriteLine(item.idade);
            //        Console.WriteLine("--------//-----------");
            //    }
            //}

            //exec 03
            //List<SerHumano> pessoas = new List<SerHumano>();
            //for (int i = 0; i < 5; i++)
            //{
            //    SerHumano temp = new SerHumano();
            //    Console.WriteLine("Insira a pessoa");
            //    temp.nome = Console.ReadLine();
            //    temp.idade = int.Parse(Console.ReadLine());
            //    temp.genero = Console.ReadLine().ToLower();
            //    pessoas.Add(temp);
            //}

            //int indiceHomem = -1, idadeHomem = -1;
            //int indiceMulher = -1, idadeMulher = -1;

            //for (int i = 0; i < pessoas.Count; i++)
            //{
            //    if (pessoas[i].genero == "m")
            //    {
            //        if (idadeMulher < pessoas[i].idade)
            //        {
            //            indiceMulher = i;
            //            idadeMulher = pessoas[i].idade;
            //        }
            //    }

            //    else
            //    {
            //        if (idadeHomem < pessoas[i].idade)
            //        {
            //            indiceHomem = i;
            //            idadeHomem = pessoas[i].idade;
            //        }
            //    }
            //}

            //try
            //{
            //    Console.WriteLine("Esta é a mulher mais velha");
            //    Console.WriteLine(pessoas[indiceMulher].nome);
            //    Console.WriteLine(pessoas[indiceMulher].idade);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Não existe mulheres nessa lista");
            //}

            //try
            //{
            //    Console.WriteLine("Esta é o homem mais velho");
            //    Console.WriteLine(pessoas[indiceHomem].nome);
            //    Console.WriteLine(pessoas[indiceHomem].idade);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Não existe homens nessa lista");
            //}

            //exec 04
            //Crie 3 animais de um zoológico com nome, espécie e tempo no zoo.
            //Peça para o usuario inseir todos os animais, em seguida,
            //mostre todos os animas do mais novo para o mais velho no zoo

            //List<Zoologico> animais = new List<Zoologico>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Zoologico temp = new Zoologico();
            //    Console.WriteLine("Adicione o animal, em ordem: nome, especie e tempo no zoologico");
            //    temp.nome = Console.ReadLine();
            //    temp.especie = Console.ReadLine();
            //    temp.tempoNoZoo = int.Parse(Console.ReadLine());
            //    animais.Add(temp);
            //}

            //SortManual(animais);
            //foreach (var item in animais)
            //{
            //    Console.WriteLine(item.nome);
            //    Console.WriteLine(item.especie);
            //    Console.WriteLine(item.tempoNoZoo);
            //    Console.WriteLine(" ");
            //}

            //exec 05
            //Crie 5 produtos com nome,preço e quantidade no estoque.
            //Peça para o usuario preencher todos os produtos,
            //em seguida, mostre na tela os produtos começando
            //pelos que tem maior quantidade no estoque

            //List<Produto> produtos = new List<Produto>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Produto temp = new Produto();
            //    Console.WriteLine("Adicione seu produto, em ordem: nome, preço e quantidade de estoque");
            //    temp.nome = Console.ReadLine();
            //    temp.preco = double.Parse(Console.ReadLine());
            //    temp.estoque = int.Parse(Console.ReadLine());
            //    produtos.Add(temp);
            //}

            //Console.WriteLine(" ");

            //SortManual(produtos);
            //foreach (var item in produtos)
            //{
            //    Console.WriteLine(item.nome);
            //    Console.WriteLine(item.preco);
            //    Console.WriteLine(item.estoque);
            //    Console.WriteLine(" ");
            //}
        }

        public static void SortManual(List<Empresa> zoo)
        {
            for (int i = 0; i < zoo.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (zoo[j].salario > zoo[j - 1].salario)
                    {
                        Empresa c = zoo[j];
                        zoo[j] = zoo[j - 1];
                        zoo[j - 1] = c;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

    }
}
