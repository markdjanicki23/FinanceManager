﻿using FinanceManager.Server.Storage;
using FinanceManager.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EarningsController : ControllerBase
    {
        private readonly IRepository<Earning> _earningRepository;

        public EarningsController(IRepository<Earning> earningRepository)
        {
            _earningRepository = earningRepository;
        }

        [HttpGet]
        public IEnumerable<Earning> Get()
        {
            return _earningRepository.GetAll()
                .OrderBy(earning => earning.Date);
        }

        [HttpPost]
        public void Post(Earning earning)
        {
            _earningRepository.Add(earning);
        }

        [HttpDelete("{id?}")]
        public void Delete(Guid id)
        {
            var entity = _earningRepository.GetAll()
                .Single(item => item.Id == id);
            _earningRepository.Remove(entity);
        }
    }
}