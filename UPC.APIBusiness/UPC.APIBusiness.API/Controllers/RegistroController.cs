using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using UPC.APIBusiness.DBContext.Interface;

namespace UPC.APIBusiness.API.Controllers;

/// <summary>
/// 
/// </summary>
///
[Produces("application/json")]
[Route("api/registro")]
public class RegistroController : Controller
{

  private readonly IRegistroRepository repository;

  /// <summary>
  /// Constructor
  /// </summary>
  public RegistroController(IRegistroRepository _repository)
  {
    repository = _repository;
  }

  /// <summary>
  /// ListRegistro
  /// </summary>
  /// <returns></returns>
  [Produces("application/json")]
  [OpenApiOperation("ListRegistro")]
  [AllowAnonymous]
  [HttpGet]
  [Route("list")]
  public ActionResult List()
  {
    var result = repository.List();

    if (result == null)
      return StatusCode(400);

    return Json(result);
  }
  
  /// <summary>
  /// Get
  /// </summary>
  /// <param name="id"></param>
  /// <returns></returns>
  [Produces("application/json")]
  [OpenApiOperation("GetRegistro")]
  [AllowAnonymous]
  [HttpGet]
  [Route("get")]
  public ActionResult Get(int id)
  {
    var result = repository.Get(id);

    if (result == null)
      return StatusCode(400);

    return Json(result);
  }
}