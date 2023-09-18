using DBContext;
using DBEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NSwag.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UPC.APIBusiness.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [Route("api/apartment")]
    public class ApartmentController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IApartmentRepository _apartmentRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apartmentRepository"></param>
        public ApartmentController(IApartmentRepository apartmentRepository)
        {
            _apartmentRepository=apartmentRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetApartment(int id)
        {
            var rest = _apartmentRepository.GetApartments(id);
            return Json(rest);
        }
    }
}
