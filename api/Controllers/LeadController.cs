using System;
using System.IO;
using System.Linq;
using api.Data;
using api.Models.Enums;
using api.ViewModels;
using api.ViewModels.LeadViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace api.Controllers
{
    public class LeadController : Controller
    {
        private readonly AdonaiDataContext _context;

        public LeadController(AdonaiDataContext context)
        {
            _context = context;
        }

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

        public IConfiguration Configuration { get; set; }

        [Route("v1/leads")]
        [HttpGet]
        public ResultViewModel GetLeads()
        {
            try
            {
                var lead = _context.Lead.ToList();

                return new ResultViewModel
                {
                    Success = true,
                    Data = "Lead 1"
                };
            }
            catch (Exception ex)
            {
                return new ResultViewModel
                {
                    Success = false,
                    Data = ex.Message
                };
            }
        }
    }
}