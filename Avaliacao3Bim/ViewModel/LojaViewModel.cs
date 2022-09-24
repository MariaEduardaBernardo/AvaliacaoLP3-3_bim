namespace Avaliacao3Bim.ViewModels;

public class LojaViewModel
{
    public int Id { get; set; }
    public String Piso { get; set; }
    public String Nome { get; set; }
    public String Desc { get; set; }
    public String Tipo { get; set; }
    public String Email { get; set; }

    public LojaViewModel(int id, string piso, string nome, string desc, string tipo, string email)
    {
        Id = id;
        Piso = piso;
        Nome = nome;
        Desc = desc;
        Tipo = tipo;
        Email = email;
    }
}