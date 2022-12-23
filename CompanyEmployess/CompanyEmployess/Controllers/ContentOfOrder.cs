using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using LoggerService;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CompanyEmployees.Controllers
{
    [Route("api/Order/{orderId}/contentOfOrder")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v2")]
    public class ContentOfOrder : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public ContentOfOrder(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Получает список всего контента заказа
        /// </summary>
        /// <returns> Список контента</returns>.
        [HttpGet("{id}")]
        public IActionResult GetContentOfOrderFoOrder(Guid orderId, Guid id)
        {
            var company = _repository.Order.GetOrder(orderId, trackChanges: false);
            if (company == null)
            {
                _logger.LogInfo($"Order with id: {orderId} doesn't exist in the database.");
                return NotFound();
            }
            var employeeDb = _repository.ContentOfOrder.GetContentOfOrder(orderId, id, trackChanges: false);
            if (employeeDb == null)
            {
                _logger.LogInfo($"Content of Order with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            var employee = _mapper.Map<EmployeeDto>(employeeDb);
            return Ok(employee);
        }
    }
    
}
