using LINQ;
using System;
using System.Linq; //importação do linq
using System.Collections.Generic; //importação das listas
using System.ComponentModel.DataAnnotations;

static void Print<T>(string mensagem, IEnumerable<T> colecao) //função para imprimir informações
{
    Console.WriteLine(mensagem);
    foreach(T obj in colecao)
    {
        Console.WriteLine(obj);
    }
    Console.WriteLine(); 
}

Categoria c1 = new Categoria() { id = 1, nome = "Ferramentas", nivel = 2 }; //lista de categorias vinculadas ao produtos
Categoria c2 = new Categoria() { id = 2, nome = "Utensilios", nivel = 3 };
Categoria c3 = new Categoria() { id = 3, nome = "Eletronicos", nivel = 1 };

List<Produtos> lista = new List<Produtos>() { //lista de produtos
            new Produtos { Id = 1, Nome = "Computador", Preco = 2000.00, Categoria = c3},
            new Produtos { Id = 2, Nome = "Martelo de obra", Preco = 25.99, Categoria = c1},
            new Produtos { Id = 3, Nome = "Monitor LCD", Preco = 700.99, Categoria = c3},
            new Produtos { Id = 4, Nome = "Faca de cozinha", Preco = 15.99, Categoria = c2},
            new Produtos { Id = 5, Nome = "Serrote de obra", Preco = 50.00, Categoria = c1},
            new Produtos { Id = 6, Nome = "Teclado Gamer", Preco = 89.99, Categoria = c3},
            new Produtos { Id = 6, Nome = "Luva de obra", Preco = 11.99, Categoria = c1},
            new Produtos { Id = 6, Nome = "Pano de prato", Preco = 5.99, Categoria = c2},
            new Produtos { Id = 6, Nome = "Regua de obra", Preco = 13.99, Categoria = c1},
            new Produtos { Id = 6, Nome = "Panela de cozinha", Preco = 120.99, Categoria = c2},
            new Produtos { Id = 6, Nome = "Mouse Gamer", Preco = 135.99, Categoria = c3}
        };

var r1 = from Produtos s in lista //select via LINQ
         where s.Categoria.nivel == 1 && s.Preco < 900.00
         select s;

Print("Nivel 1 e o preço menor que R$ 900.00: ", r1);

var r2 = from Produtos s in lista
         where s.Categoria.nome == "Ferramentas"
         select s.Nome;

Print("Todos os produtos da categoria ferramentas: ", r2);

var r3 = from Produtos s in lista
         where s.Nome[0] == 'M' //uso do like
         select new //instanciação de um novo objeto com os elementos determinados
         {
             s.Nome,
             s.Preco,
             s.Categoria.nome
         };

Print("Todos os produtos que começam com M: ", r3);

var r4 = from Produtos s in lista
         where s.Categoria.nivel == 1
         orderby s.Nome //uso do order by
         orderby s.Preco
         select s;

Print("Nível 1 ordenados por preço, senão por nome: ", r4);

var r5 = (from s in r4
          select s)
          .Skip(2) //pula 2 registros
          .Take(4); //captura 4 registros   

Print("Nível um, pulando 2 e capturando 4: ", r5);

var r6 = from Produtos s in lista
         group s by s.Categoria; //group by
foreach(IGrouping<Categoria, Produtos> grupo in r6)
{
    Console.WriteLine("Categoria " + grupo.Key.nome + ":");
    foreach(Produtos s in grupo)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine();
}



OrderStatus os2 = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered"); //notação de enum