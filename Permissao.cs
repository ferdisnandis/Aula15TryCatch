using System;

namespace Aula15TryCatch
{
    public class Permissao
    {
        private bool Acesso { get; set; }

        public void Autorizar(){

            try{
            System.Console.WriteLine("Acessar aplicação? True/False");
            Acesso = Boolean.Parse( Console.ReadLine() ); 
            }catch (Exception ex){
                System.Console.WriteLine("Erro nos dados inseridos, erro gerado "+ex );
            }
        }
    }
}