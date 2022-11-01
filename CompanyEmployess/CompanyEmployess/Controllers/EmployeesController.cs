using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using Entities.Models;
>>>>>>> lab5
using LoggerService;
using Microsoft.AspNetCore.Mvc;
using System;
=======
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft;
using Microsoft.AspNetCore.JsonPatch;
>>>>>>> lab6

namespace CompanyEmployees.Controllers
{
    [Route("api/companies/{companyId}/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public EmployeesController(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

<<<<<<< HEAD
<<<<<<< HEAD
        [HttpGet("{id}")]
=======
        [HttpGet("{id}", Name = "GetEmployeeForCompany")]
>>>>>>> lab5
=======
        [HttpGet("{id}", Name = "GetEmployeeForCompany")]
>>>>>>> lab6
        public IActionResult GetEmployeeForCompany(Guid companyId, Guid id)
        {
            var company = _repository.Company.GetCompany(companyId, trackChanges: false);
            if (company == null)
            {
                _logger.LogInfo($"Company with id: {companyId} doesn't exist in the database.");
                return NotFound();
            }
            var employeeDb = _repository.Employee.GetEmployee(companyId, id, trackChanges: false);
            if (employeeDb == null)
            {
                _logger.LogInfo($"Employee with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            var employee = _mapper.Map<EmployeeDto>(employeeDb);
            return Ok(employee);
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> lab6

        [HttpPost]
        public IActionResult CreateEmployeeForCompany(Guid companyId, [FromBody] EmployeeForCreationDto employee)
        {
            if (employee == null)
            {
                _logger.LogError("EmployeeForCreationDto object sent from client is null.");
            return BadRequest("EmployeeForCreationDto object is null");
            }
            var company = _repository.Company.GetCompany(companyId, trackChanges: false);
            if (company == null)
            {
                _logger.LogInfo($"Company with id: {companyId} doesn't exist in the database.");
            return NotFound();
            }
            var employeeEntity = _mapper.Map<Employees>(employee);
            _repository.Employee.CreateEmployeeForCompany(companyId, employeeEntity);
            _repository.Save();
            var employeeToReturn = _mapper.Map<EmployeeDto>(employeeEntity);
            return CreatedAtRoute("GetEmployeeForCompany", new
            {
                companyId,id = employeeToReturn.Id}, employeeToReturn);
        }
<<<<<<< HEAD
>>>>>>> lab5
=======

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployeeForCompany(Guid companyId, Guid id)
        {
            var company = _repository.Company.GetCompany(companyId, trackChanges: false);
            if (company == null)
            {
                _logger.LogInfo($"Company with id: {companyId} doesn't exist in the database.");
            return NotFound();
            }
            var employeeForCompany = _repository.Employee.GetEmployee(companyId, id,
            trackChanges: false);
            if (employeeForCompany == null)
            {
                _logger.LogInfo($"Employee with id: {id} doesn't exist in the database.");
            return NotFound();
            }
            _repository.Employee.DeleteEmployee(employeeForCompany);
            _repository.Save();
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployeeForCompany(Guid companyId, Guid id, [FromBody] EmployeeForUpdateDto employee)
        {
            if (employee == null)
            {
                _logger.LogError("EmployeeForUpdateDto object sent from client i null.");
            return BadRequest("EmployeeForUpdateDto object is null");
            }
            var company = _repository.Company.GetCompany(companyId, trackChanges: false);
            if (company == null)
            {
                _logger.LogInfo($"Company with id: {companyId} doesn't exist in the database.");
            return NotFound();
            }
            var employeeEntity = _repository.Employee.GetEmployee(companyId, id,
           trackChanges:
            true);
            if (employeeEntity == null)
            {
                _logger.LogInfo($"Employee with id: {id} doesn't exist in the database.");
            return NotFound();
            }
            _mapper.Map(employee, employeeEntity);
            _repository.Save();
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PartiallyUpdateEmployeeForCompany(Guid companyId, Guid id,[FromBody] JsonPatchDocument<EmployeeForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from client is null.");
                return BadRequest("patchDoc object is null");
            }
            var company = _repository.Company.GetCompany(companyId, trackChanges: false);
            if (company == null)
            {
                _logger.LogInfo($"Company with id: {companyId} doesn't exist in the database.");
            return NotFound();
            }
            var employeeEntity = _repository.Employee.GetEmployee(companyId, id,
           trackChanges:
            true);
            if (employeeEntity == null)
            {
                _logger.LogInfo($"Employee with id: {id} doesn't exist in the database.");
            return NotFound();
            }
            var employeeToPatch = _mapper.Map<EmployeeForUpdateDto>(employeeEntity);
            patchDoc.ApplyTo(employeeToPatch);
            _mapper.Map(employeeToPatch, employeeEntity);
            _repository.Save();
            return NoContent();
        }
>>>>>>> lab6
    }
    
}
