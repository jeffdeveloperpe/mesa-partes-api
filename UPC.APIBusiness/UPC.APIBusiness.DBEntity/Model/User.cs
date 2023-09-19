namespace DBEntity;

public class User
{
  public string usuario { get; set; }
  public string password { get; set; }
  public string dni { get; set; }
  public string codigo_verificador { get; set; }
  public string telefono { get; set; }
  public string correo { get; set; }
  public int  rol { get; set; }
}