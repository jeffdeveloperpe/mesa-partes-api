using System;

namespace UPC.APIBusiness.DBEntity.Model;

public class Registro
{
  public int id { get; set; }
  public int usuario { get; set; }
  public string tipo_persona { get; set; }
  public string tipo_documento { get; set; }
  public string numero_documento { get; set; }
  public string razon_social { get; set; }
  public string ruc { get; set; }
  public string apellido_paterno { get; set; }
  public string apellido_materno { get; set; }
  public string nombres { get; set; }
  public string telefono { get; set; }
  public string correo { get; set; }
  public string direccion { get; set; }
  public DateTime fecha_creacion { get; set; }
  public int usuario_creacion { get; set; }
  public DateTime fecha_actualizacion { get; set; }
  public int usuario_actualizacion { get; set; }
  public string estado { get; set; }
  public string numero_expediente { get; set; }
}