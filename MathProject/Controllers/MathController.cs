using AutoMapper;
using MathProject.Data;
using MathProject.Dtos;
using MathProject.Interfaces;
using MathProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MathProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        
        private readonly IMathService _mathService;
        private readonly IMapper _mapper;

        public MathController(IMathService mathService, IMapper mapper)
        {
            _mathService = mathService;
            _mapper = mapper;
        }

        [HttpGet("{num}")]
        public ActionResult<NumberInfo> GetNumberInfo(int num)
        {
            return Ok(_mapper.Map<NumberToDisplayDto>(_mathService.GetNumber(num)));
            
        }

        private bool IsPrime(int n)
        {
            return _mathService.IsPrime(n);
        }

        private bool IsPerfect(int n)
        {
            return _mathService.IsPerfect(n); 
        }

        private bool IsArmstrong(int n)
        {
          return _mathService.IsArmstrong(n); 
        }

        private int GetDigitSum(int n)
        {
            return _mathService.GetDigitSum(n);
        }

        private string GetFunFact(int n)
        {
            return _mathService.GetFunFact(n);
        }

    }
}
