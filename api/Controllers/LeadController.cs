using api.Models.Enums;
using api.ViewModels;
using api.ViewModels.LeadViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    public class LeadController : Controller
    {
        [Route("/v1/lead/register")]
        [HttpPost]
        public ResultViewModel Add([FromBody]CreateLeadViewModel model)
        {
            if (model.Invalid)
            {
                return new ResultViewModel
                {
                    Success = false,
                    Data = model.Notifications
                };
            }

            var consorcio = (ConsorcioEnum)model.Consorcio;        

            return new ResultViewModel
            {
                Success = true,
                Data = "Cliente adicionado com sucesso!"
            };
        }

        [Route("v1/leads")]
        [HttpGet]
        public ResultViewModel GetLeads()
        {
            return new ResultViewModel
            {
                Success = true,
                Data = "Lead 1"
            };
        }
    }
}