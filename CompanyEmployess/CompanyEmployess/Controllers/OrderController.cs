using AutoMapper;
using CompanyEmployees.ModelBinders;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;


namespace CompanyEmployees.Controllers
{
    /// <summary>
    /// Контроллер отвечающий за взаимодействие с таблицей Order.
    /// В ней он создаёт,добавляет,обновляет записи.
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/order")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
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

        /// <summary>
        /// Получает список всех заказов
        /// </summary>
        /// <returns> Список заказов</returns>.
        [HttpGet]
        [HttpGet(Name = "GetOrders"), Authorize(Roles = "Manager")]
        public IActionResult GetOrders()
        {
            var orders = _repository.Order.GetAllOrder(trackChanges: false);
            var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);
            return Ok(ordersDto);
        }

        [HttpGet("{id}", Name = "OrderById")]
        [HttpGet(Name = "GetOrder"), Authorize(Roles = "Manager")]
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

        /// <summary>
        /// Создает вновь созданный заказ
        /// </summary>
        /// <param name="order"></param>.
        /// <returns>Вновь созданный заказ</returns>.
        /// <response code="201"> Возвращает только что созданный элемент</response>.
        /// <response code="400"> Если элемент равен null</response>.
        /// <код ответа="422"> Если модель недействительна</ответ>.
        [HttpPost]
        [HttpPost(Name = "CreateOrder"), Authorize(Roles = "Manager")]
        public IActionResult CreateOrder([FromBody] OrderForCreationDto orderForCreation)
        {
            if (orderForCreation == null)
            {
                _logger.LogError("OrderForCreation object sent from client is null.");
                return BadRequest("OrderForCreation object is null");
            }
            var orderEntity = _mapper.Map<Order>(orderForCreation);
            _repository.Order.CreateOrder(orderEntity);
            _repository.Save();
            var orderToReturn = _mapper.Map<OrderDto>(orderEntity);
            return CreatedAtRoute("Order Dto", new { id = orderToReturn.Id }, orderToReturn);
        }

        [HttpGet("collection/({ids})", Name = "OrderCollection")]
        [HttpGet(Name = "GetCompanyColleciton"), Authorize(Roles = "Manager")]
        public IActionResult GetCompanyCollection([ModelBinder(BinderType =typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
        {
            if (ids == null)
            {
                _logger.LogError("Parameter ids is null");
                return BadRequest("Parameter ids is null");
            }
            var orderEntities = _repository.Order.GetByIds(ids, trackChanges: false);
            if (ids.Count() != orderEntities.Count())
            {
                _logger.LogError("Some ids are not valid in a collection");
                return NotFound();
            }
            var orderToReturn = _mapper.Map<IEnumerable<OrderDto>>(orderEntities);
            return Ok(orderToReturn);
        }

        [HttpPost("collection")]
        [HttpPost(Name = "CreateOrderCollection"), Authorize(Roles = "Manager")]
        public IActionResult CreateOrderCollection([FromBody] IEnumerable<OrderForCreationDto> orderCollection)
        {
            if (orderCollection == null)
            {
                _logger.LogError("Order collection sent from client is null.");
                return BadRequest("Order collection is null");
            }
            var orderEntities = _mapper.Map<IEnumerable<Order>>(orderCollection);
            foreach (var orderz in orderEntities)
            {
                _repository.Order.CreateOrder(orderz);
            }
            _repository.Save();
            var orderCollectionToReturn = _mapper.Map<IEnumerable<OrderDto>>(orderEntities);
            var ids = string.Join(",", orderCollectionToReturn.Select(c => c.Id));
            return CreatedAtRoute("OrderCollection", new { ids },
            orderCollectionToReturn);
        }

        [HttpPut("{id}")]
        [HttpPut(Name = "UpdateOrder"), Authorize(Roles = "Manager")]
        public IActionResult UpdateOrder(Guid id, [FromBody] OrderForUpdateDto order)
        {
            if (order == null)
            {
                
            _logger.LogError("OrderForUpdateDto object sent from client is null.");
                return BadRequest("OrderForUpdateDto object is null");
            }
            var orderEntity = _repository.Order.GetOrder(id, trackChanges: true);
            if (orderEntity == null)
            {
                _logger.LogInfo($"Order with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            _mapper.Map(order, orderEntity);
            _repository.Save();
            return NoContent();
        }
    }
}
