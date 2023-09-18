using DBContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;

namespace UPC.APIBusiness.API.Controllers;

/// <summary>
/// 
/// </summary>
[Produces("application/json")]
[Route("api/rol")]
public class RolController : Controller
{
  private readonly IRolRepository _repository;

  /// <summary>
  /// 
  /// </summary>
  /// <param name="repository"></param>
  public RolController(IRolRepository repository)
  {
    _repository = repository;
  }

  /// <summary>
  /// List Rol
  /// </summary>
  /// <returns></returns>
  [Produces("application/json")]
  [OpenApiOperation("List")]
  [AllowAnonymous]
  [HttpGet]
  [Route("list")]
  public ActionResult List()
  {
    var result = _repository.List();

    if (result == null)
    {
      return StatusCode(400);
    }

    return Json(result);
  }
}