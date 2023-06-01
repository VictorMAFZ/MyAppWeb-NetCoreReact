public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int PerfilId { get; set; }
    public Perfil Perfil { get; set; }
}

public class Perfil
{
    public int Id { get; set; }
    public string NombrePerfil { get; set; }
}
