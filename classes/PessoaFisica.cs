using PFS_UC12___EncontroRemoto2.interfaces;

namespace PFS_UC12___EncontroRemoto2.classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {
        public string? Cpf { get; set; }

        public string? dataNasc { get; set; }

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento < 3500)
            {
                return (rendimento / 100) * 2;
            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                return (rendimento / 100) * 3.5f;
            }
            else
            {
                return (rendimento / 100) * 5;
            }
        }

        public bool ValidarDataNasc(DateTime DataNasc)
        {
            DateTime dataAtual = DateTime.Today;

             double anos = (dataAtual - DataNasc).TotalDays / 365 ;

             if(anos >= 18)
             {
                 return true;
             }
            
                 return false;
             
        }

        public bool ValidarDataNasc(string dataNasc){

            DateTime dataConvertida;

            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;

             double anos = (dataAtual - dataConvertida).TotalDays / 365 ;

             if(anos >= 18)
             {
                 return true;
             }
            
                 return false;
            }

            return false;
        }
    }
}