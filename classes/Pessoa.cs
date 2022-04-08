using PFS_UC12___EncontroRemoto2.interfaces;

namespace PFS_UC12___EncontroRemoto2.classes
{
    public abstract class Pessoa :  IPessoa
    {
    
        public string? Nome { get; set; }

        public float rendimento { get; set; }

        public Endereco? Endereco { get; set; }

        public abstract float PagarImposto(float rendimento);
    }
}
