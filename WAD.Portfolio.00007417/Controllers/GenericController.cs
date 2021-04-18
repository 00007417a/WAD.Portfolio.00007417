using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio._00007417.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.Portfolio._00007417.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    // the abstract class will be inherited by product and category controllers
    // this method is used to apply SRP
    public abstract class GenericController<T> : ControllerBase where T : class
    {
        // Generic repository that will accept a model class
        protected readonly IRepository<T> _repository;

        protected GenericController(IRepository<T> repository)
        {
            _repository = repository;
        }
    }
}
