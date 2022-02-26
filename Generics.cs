using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    internal class Generics
    {

        public class Alunos
        {
            public Alunos()
            {
                this.nome = "AlunoQualquer";
                this.idade = 0;
                this.notaFinal = 0;


            }
            public string nome { get; set; }
            public int idade { get; set; }
            public int notaFinal { get; set; }


            public static List<object> NomeQ()
            {
                List<object> list = new List<object>();
                Alunos A = new Alunos();
                list.Add(A);


                return list;
            }

            public static List<T> Funcao<T>()
            {
                List<T> list = new List<T>();
                List<Alunos> alunos = new List<Alunos>();
                T A1, A2, A3, A4, A5, A6, A7, A8, A9, A10;

                alunos.Add(new Alunos { nome = "Felipe" , idade = 21, notaFinal = 20});
                alunos.Add(new Alunos { nome = "Felipe2", idade = 21, notaFinal = 20 });
                alunos.Add(new Alunos { nome = "Felipe3", idade = 21, notaFinal = 20 });
                alunos.Add(new Alunos { nome = "Felipe4", idade = 21, notaFinal = 20 });
                alunos.Add(new Alunos { nome = "Felipe5", idade = 21, notaFinal = 20 });

                /*list.Add(new typeof(A1));
                list.Add(A2);
                list.Add(A3);
                list.Add(A4);
                list.Add(A5);
                list.Add(A6);
                list.Add(A7);
                list.Add(A8);
                list.Add(A9);
                list.Add(A10);*/



                return list;
            }

        }
    }
}
