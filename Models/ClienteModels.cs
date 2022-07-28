using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBank
{
    internal class ClienteModels
    {
        public string  Nome { get; set; }
        public decimal Saldo { get; set; }

        
        public ClienteModels( string nome, decimal saldo)
        {
            Nome = nome;
            Saldo = saldo;

        }

        public ClienteModels()
        {
        }

        public override string ToString()
        {
            return $"       Status da Conta\nCliente: {Nome} \nSaldo Atual:{Saldo}";
        }

        public decimal Depositar(decimal saldo)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"-------- nome ------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Quanto Deseja Depositar ?");
            decimal resp = decimal.Parse(Console.ReadLine());   

            var saldoFinal = saldo + resp;
            Console.WriteLine($"{saldoFinal}");
            return saldoFinal;
        }

        public void Menu ( string nome)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"--------{nome} ------" );
            Console.WriteLine("-----------------------");
            Console.WriteLine("Digite 1 para Depositar");
            Console.WriteLine("Digite 2 para Sacar    ");
            
            int resp = int.Parse(Console.ReadLine());
            switch (resp)
            {
                case 1: Depositar(Saldo); break;
                case 2: Sacar(Saldo); break;
                case 3: Depositar(Saldo); break;

            }

        }

        public virtual void Sacar(decimal sacar)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"-------- nome ------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Quanto Deseja Sacar?");
            decimal resp = decimal.Parse(Console.ReadLine());

            var saldoFinal = sacar - resp;
            Console.WriteLine($"{saldoFinal}");
           
            
            
        }
    }

    

}
