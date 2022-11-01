using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using LoggerService;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
=======
using System;
>>>>>>> lab4
using System.Collections.Generic;

namespace CompanyEmployees.Controllers
{
<<<<<<< HEAD
    [Route("api/[controller]")]
=======
    [Route("api/order")]
>>>>>>> lab4
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public OrderController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetOrder()
        {
            var orders = _repository.Order.GetAllOrder(trackChanges: false);
            var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);
            return Ok(ordersDto);
        }
<<<<<<< HEAD
=======

        [HttpGet("{id}")]
        public IActionResult GetOrder(Guid id)
        {
            var order = _repository.Order.GetOrder(id, trackChanges: false);
            if (order == null)
            {
                _logger.LogInfo($"Order with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var orderDto = _mapper.Map<OrderDto>(order);
                return Ok(orderDto);
            }
        }
>>>>>>> lab4
    }
}
