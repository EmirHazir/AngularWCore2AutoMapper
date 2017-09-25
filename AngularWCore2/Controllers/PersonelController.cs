using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngularWCore2.ContextFiles;
using AngularWCore2.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using AngularWCore2.Models.Resources;

namespace AngularWCore2.Controllers
{
    [Produces("application/json")]
    [Route("api/Personel")]
    public class PersonelController : Controller
    {
        private AppDbContext _context { get; }
        private IMapper _mapper { get; }
        public PersonelController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        [HttpGet]
        public IEnumerable<PersonelResource> GetPersonel()
        {
            var result = _context.Personeller.ToList().Select(_mapper.Map<Personel, PersonelResource>);


            return result;
        }

    }
}