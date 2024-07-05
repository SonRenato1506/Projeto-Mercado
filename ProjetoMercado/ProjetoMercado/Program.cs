using System.Runtime.Remoting;

namespace ProjetoMercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Produtos[] p = new Produtos[12];

            p[0]  = new Produtos("7891025101604", "Leite            ", "03.00", 15, "l  ");
            p[1]  = new Produtos("7891000105016", "Barra Cereal     ", "03.40", 28, "lt ");
            p[2]  = new Produtos("7891000120101", "Creme de Leite   ", "03.70", 23, "cx "); 
            p[3]  = new Produtos("7891000100103", "Leite Condensado ", "04.50", 18, "und");
            p[4]  = new Produtos("7891999000528", "Iorgute          ", "01.98", 32, "gf ");
            p[5]  = new Produtos("7896051126041", "Leite Fermentado ", "02.12", 12, "cx ");
            p[6]  = new Produtos("7897236904805", "Água             ", "01.50", 48, "cp ");
            p[7]  = new Produtos("7622300830083", "Biscoito Recheado", "01.80", 35, "pct");
            p[8]  = new Produtos("7891150036567", "Caldo de galinha ", "01.90", 16, "cx ");
            p[9]  = new Produtos("4005900036728", "desodorante      ", "11.10", 25, "und");
            p[10] = new Produtos("7896185989819", "Vitamina C       ", "35.20", 26, "und");
            p[11] = new Produtos("7898113811452", "Lanche           ", "09.50", 37, "und");

            Console.Write("Quantos cupons você deseja inserir?: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Cupom[] c = new Cupom[x];

            int v = 0;

            for(int s = 0; s < x; s++)
            {
                
                Console.Write("Digite o código do grupo: ");
                string codCup = Console.ReadLine();
                i = 0;
                do
                {
                    i++;
     
                } while(codCup != p[i].Codigo );
                Console.Write("Digite a quantidade: "); 
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o seu cpf: "); 
                string z = Console.ReadLine();

                c[v] = new Cupom(codCup, z);
                Console.WriteLine(c[v]._numeroCupom + ", " + c[v]._cpfCliente);
            } 



            Console.WriteLine("|----------------------------------------------------------------------------|");
            Console.WriteLine("|    Código    |    Descrição     |  Preço |   Quant.Estoque  | Valor.estoque|");
            Console.WriteLine("|----------------------------------------------------------------------------|");
            foreach(Produtos produto in p)
            {
                Console.WriteLine("| " + produto.Codigo + "| " + produto.Descricao + "| R$" + produto.Preco + "| " + produto.Estoque + "               |" + produto.QntEstoque + "           |");
            }
        }
    }
}