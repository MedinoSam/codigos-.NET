using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraLista
{
    public class ValidarDados
    {
        string nome = LerNome();
        string cpf = LerCPF();
        DateTime dataNascimento = LerDataNascimento();
        float rendaMensal = LerRendaMensal();
        char estadoCivil = LerEstadoCivil();
        int dependentes = LerDependentes();
        public static bool ValidarCpf(string cpf)
        {
            // Verificar comprimento e números repetidos
            if (cpf.Length != 11 || new string(cpf[0], 11) == cpf)
                return false;

            int[] multiplicadorPrimeiroDigitoVerificador = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadorSegundoDigitoVerificador = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            // Primeiro dígito verificador
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadorPrimeiroDigitoVerificador[i];
            int resto = soma % 11;
            int primeiroDigitoVerificador = resto < 2 ? 0 : 11 - resto;

            tempCpf += primeiroDigitoVerificador;
            soma = 0;

            // Segundo dígito verificador
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadorSegundoDigitoVerificador[i];
            resto = soma % 11;
            int segundoDigitoVerificador = resto < 2 ? 0 : 11 - resto;

            return cpf.EndsWith(primeiroDigitoVerificador.ToString() + segundoDigitoVerificador.ToString());

        }
        public static string LerNome()
        {
            while (true)
            {
                Console.WriteLine(" digite um nome com no minimo 5 caracteres");
                string nome = Console.ReadLine();
                if (nome.Length >= 5)
                {
                    return nome;
                }
                Console.WriteLine("Nome invalido! um nome precisa ter  no minimo 5 caracteres");
            }
        }

        public static string LerCPF()
        {
            while (true)
            {
                Console.WriteLine(" digite um cpf sem ponto nem hifen");
                string cpf = Console.ReadLine();
                if (ValidarCpf(cpf))
                    return cpf;
                Console.WriteLine("CPF fora do padrao");
            }
        }

        public static DateTime LerDataNascimento()
        {
            while (true)
            {
                Console.WriteLine(" Digita uma data de nascimento nesse padrao: dia, mes e ano");
                if (DateTime.TryParse(Console.ReadLine(), new CultureInfo("pt-BR"), DateTimeStyles.None, out DateTime dataNascimento))
                {
                    int idade = DateTime.Now.Year - dataNascimento.Year;
                    if (idade >= 18)
                    {
                        return dataNascimento;
                    }
                    Console.WriteLine("Idade minima de 18 anos nao foi atingida.");
                }
                else
                {
                    Console.WriteLine("data fora do formato, formato esperado: dia/mes/ano");
                }
            }
        }

        public static float LerRendaMensal()
        {
            while (true)
            {
                Console.WriteLine(" digite sua renda mensal com duas casas decimais apos a virgula");
                if (float.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, new CultureInfo("pt-BR"), out float rendaMensal) && rendaMensal >= 0)
                    return rendaMensal;
                Console.WriteLine("Erro! Renda mensal negativa ou fora do padrao 0,00");
            }
        }

        public static char LerEstadoCivil()
        {
            while (true)
            {
                Console.Write("Digite seu estado civil (C, S, V ou D): ");
                char estadoCivil = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (estadoCivil == 'C' || estadoCivil == 'S' || estadoCivil == 'V' || estadoCivil == 'D')
                    return estadoCivil;
                Console.WriteLine("Erro! Estado civil inválido. Use C, S, V ou D.");
            }
        }

        public static int LerDependentes()
        {
            while (true)
            {
                Console.Write("Digite o número de dependentes (0 a 10): ");
                if (int.TryParse(Console.ReadLine(), out int dependentes) && dependentes >= 0 && dependentes <= 10)
                    return dependentes;
                Console.WriteLine("Erro! Número de dependentes deve estar entre 0 e 10.");
            }
        }
    }
}
