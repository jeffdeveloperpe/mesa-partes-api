using DBContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;

namespace UPC.APIBusiness.API.Controllers;

/// <summary>
/// 
/// </summary>
[Produces("application/json")]
[Route("api/user")]
public class UserController : Controller
{

  /// <summary>
  /// Constructor
  /// </summary>
  private readonly IUserRepository repository;


  /// <summary>
  /// 
  /// </summary>
  /// <param name="_repository"></param>
  public UserController(IUserRepository _repository)
  {
    repository = _repository;
  }

  /// <summary>
  /// ListUser
  /// </summary>
  /// <returns></returns>
  [Produces("application/json")]
  [OpenApiOperation("ListUser")]
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
  [OpenApiOperation("GetUser")]
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