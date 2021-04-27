using System;

namespace CondicaoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            double n4 = Convert.ToDouble(Console.ReadLine());

            Aluno aluno = new Aluno();

            aluno.nome = nome;
            aluno.n1 = n1;
            aluno.n2 = n2;
            aluno.n3 = n3;
            aluno.n4 = n4;
            
            aluno.media = (n1 + n2 + n3 + n4) / 4;             
                                                                   
            
            if (aluno.media >= 7)
            {
                Console.WriteLine("Aluno(a) {0} está APROVADO, média final {1}.", aluno.nome, aluno.media);
             
            }
            else
            {
                Console.WriteLine("Aluno(a) {0} está de EXAME, média final {1}.", aluno.nome, aluno.media);
            }
                   

            Console.WriteLine("Digite a nota do EXAME: ");            
            aluno.exame = Convert.ToDouble(Console.ReadLine());

            double NovaMedia;

            NovaMedia = (aluno.exame + aluno.media) / 2;            
                           
                                                        
            if ( NovaMedia >= 5)
            {
                Console.WriteLine(" Aluno(a) {0} está APROVADO EM EXAME, média final {1}.", aluno.nome, NovaMedia);
            }
            else
            {
                Console.WriteLine(" Aluno(a) {0} está REPROVADO EM EXAME, média final {1}.", aluno.nome, NovaMedia);
            }       

            

         

        }
    }
}
