using OOPBank;
using System;



namespace ContaCorrente
{
    public class Program
    {


        public static void Main()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("  Digite seu Nome");
            Console.WriteLine("-----------------------");
            string nome = Console.ReadLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Digite seu Saldo");
            Console.WriteLine("-----------------------");
            decimal saldo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");
            Console.WriteLine("Cadastro Concluido com Sucesso");
            Console.WriteLine("-----------------------");
            Console.ReadKey();
            Console.Clear();

            
            ClienteModels cliente = new ClienteModels();
            cliente.Nome = nome;
            cliente.Saldo = saldo;

            Console.WriteLine(cliente);

            
            cliente.Menu(nome);
           
            Console.WriteLine(cliente);



        }

        
           
        

        
    }
}
