using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using LoggerService;
using Microsoft.AspNetCore.Mvc;
using System;
using Entities.Models;
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.JsonPatch;
>>>>>>> lab6

namespace CompanyEmployees.Controllers
{
    [Route("api/Order/{orderId}/contentOfOrder")]
    [ApiController]
    public class ContentOfOrderController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public ContentOfOrderController(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}", Name = "GetContentOfOrderDto")]
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

        [HttpPost]
        public IActionResult CreateConentOfOrder([FromBody] ContentOfOrderForCreationDto contetnForCreation)
        {
            if (contetnForCreation == null)
            {
                _logger.LogError("ContentForCreation object sent from client is null.");
            return BadRequest("ContentForCreation object is null");
            }
            var contetnOfOrderEntity = _mapper.Map<ContentOfOrder>(contetnForCreation);
            _repository.ContentOfOrder.CreateContentOfOrder(contetnOfOrderEntity);
            _repository.Save();
            var contentOfOrderToReturn = _mapper.Map<OrderDto>(contetnOfOrderEntity);
            return CreatedAtRoute("ContentOfOrderDto", new { id = contentOfOrderToReturn.Id }, contentOfOrderToReturn);
        }

        [HttpPost]
        public IActionResult CreateContentOfOrderForOrder(Guid orderId, [FromBody] ContentOfOrderForCreationDto contentOfOrder)
        {
            if (contentOfOrder == null)
            {
                _logger.LogError("contentOfOrder object sent from client is null.");
                return BadRequest("contentOfOrder object is null");
            }
            var order = _repository.Order.GetOrder(orderId, trackChanges: false);
            if (order == null)
            {
                _logger.LogInfo($"order with id: {orderId} doesn't exist in the database.");
                return NotFound();
            }
            var contentOfOrderEntity = _mapper.Map<ContentOfOrder>(contentOfOrder);
            _repository.ContentOfOrder.CreateContentForOrder(orderId, contentOfOrderEntity);
            _repository.Save();
            var contentOfOrderToReturn = _mapper.Map<ContentOfOrderDto>(contentOfOrderEntity);
            return CreatedAtRoute("GetContentOfOrderDto", new
            {
                orderId,
                id = contentOfOrderToReturn.OrderId
            }, contentOfOrderToReturn);
        }
<<<<<<< HEAD
=======

        [HttpPut("{id}")]
        public IActionResult UpdateContentOfOrderForOrder(Guid orderyId, Guid id, [FromBody] ContentOfOrderForUpdateDto contentOfOrder)
        {
            if (contentOfOrder == null)
            {
                _logger.LogError("contentOfOrder object sent from client is null.");
            return BadRequest("contentOfOrder object is null");
            }
            var order = _repository.Order.GetOrder(orderyId, trackChanges: false);
            if (order == null)
            {
                _logger.LogInfo($"order with id: {orderyId} doesn't exist in the database.");
            return NotFound();
            }
            var contentOfOrderEntity = _repository.ContentOfOrder.GetContentOfOrder(orderyId, id, trackChanges:
            true);
            if (contentOfOrderEntity == null)
            {
                _logger.LogInfo($"Content Of Order with id: {id} doesn't exist in the database.");
            return NotFound();
            }
            _mapper.Map(order, contentOfOrderEntity);
            _repository.Save();
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PartiallyUpdateContentOfOrderForOrder(Guid orderId, Guid id, [FromBody] JsonPatchDocument<ContentOfOrderForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from client is null.");
                return BadRequest("patchDoc object is null");
            }
            var order = _repository.Order.GetOrder(orderId, trackChanges: false);
            if (order == null)
            {
                _logger.LogInfo($"order with id: {orderId} doesn't exist in the database.");
                return NotFound();
            }
            var contentOfOrderEntity = _repository.ContentOfOrder.GetContentOfOrder(orderId, id,trackChanges: true);
            if (contentOfOrderEntity == null)
            {
                _logger.LogInfo($"contentOfOrder with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            var contentOfOrderToPatch = _mapper.Map<ContentOfOrderForUpdateDto>(contentOfOrderEntity);
            patchDoc.ApplyTo(contentOfOrderToPatch);
            _mapper.Map(contentOfOrderToPatch, contentOfOrderEntity);
            _repository.Save();
            return NoContent();
        }
>>>>>>> lab6
    }
    
}
