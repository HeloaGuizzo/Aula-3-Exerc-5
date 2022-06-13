using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            double reajuste;
            double novoSalario;

            Console.WriteLine("----- CÁLCULO DO NOVO SALÁRIO DOS FUNCIONÁRIOS DA BLUE  -----");

            Console.WriteLine("Digite um valor: ");
            float salario = Convert.ToSingle(Console.ReadLine());
            Console.Write(salario.ToString("C"));


            if ((salario) >= 0 && (salario) <= 400)
            {
                reajuste = salario * 0.15;
                novoSalario = salario + reajuste;
                Console.WriteLine(" Seu salário novo salário é : R$" + (novoSalario) + " . ");
                Console.WriteLine(" O reajuste é de :" + (reajuste) + " . ");
                Console.WriteLine(" O percentual é de : 15% ");

            }
            else if (salario > 400 && salario <= 800)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                Console.WriteLine(" Seu salário novo salário é : R$" + (novoSalario) + " . ");
                Console.WriteLine(" O reajuste é de :" + (reajuste) + " . ");
                Console.WriteLine(" O percentual é de : 12% ");
            }
            else if (salario > 800 && salario <= 1200)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                Console.WriteLine(" Seu salário novo salário é : R$" + (novoSalario) + " . ");
                Console.WriteLine(" O reajuste é de :" + (reajuste) + " . ");
                Console.WriteLine(" O percentual é de : 10% ");

            }
            else if (salario > 1200 && salario <= 2000)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                Console.WriteLine(" Seu salário novo salário é : R$" + (novoSalario) + " . ");
                Console.WriteLine(" O reajuste é de :" + (reajuste) + " . ");
                Console.WriteLine(" O percentual é de : 7% ");

            }
            else
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                Console.WriteLine(" Seu salário novo salário é : R$" + (novoSalario) + " . ");
                Console.WriteLine(" O reajuste é de :" + (reajuste) + " . ");
                Console.WriteLine(" O percentual é de : 4% ");
            }
        }
    }
}
