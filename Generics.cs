using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    public class Generics
    {

        public class Alunos
        {
            public Alunos()
            {
                this.nome = "AlunoQualquer";
                this.idade = 0;
                this.notaFinal = 0;


            }

            public Alunos(string nome,int idade, int notaFinal)
            {
                this.nome = nome;
                this.idade = idade;
                this.notaFinal = notaFinal;


            }
            public string nome { get; set; }
            public int idade { get; set; }
            public int notaFinal { get; set; }


       

        }

        public static List<T> Funcao<T>(T[] alunoQualquer)
        {
            List<T> list = new List<T>();
            for(int i = 0;i < 10 ;i++ )
            { 
            list.Add(alunoQualquer[i]);
            }
          



            return list;
        }

        public static string BuscarAlunoPeloNome<Alunos>(List<Generics.Alunos> listaDosAlunos,string nomeBuscado )
        {

         

            var filtro =  listaDosAlunos.Where(a => a.nome.Equals(nomeBuscado)).Select(a=>a);

            
            Generics.Alunos[] array = filtro.ToArray();
            
            Console.WriteLine(array.GetType().Name);
            foreach (Generics.Alunos listado in array)
            {
                Console.WriteLine ("\nNome : " + listado.nome +"\nIdade : "+ listado.idade +"\nNota Final : "+listado.notaFinal+ "\n");
            }

           


            return "Hey";
        }

    }


}
