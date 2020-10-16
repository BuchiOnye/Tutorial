using AssessmentTest.Data;
using AssessmentTest.Dto;
using AssessmentTest.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace AssessmentTest.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockRepo _repository;
        private readonly IMapper _mapper;

        public StockController(IStockRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Stock>> GetAllCommands()
        {
            //var commands = _repository.GetAppCommands();
            return Ok();//commands);
        }

        [HttpGet("{id}/{marchantId}")]
        public ActionResult <Dto.StockReadDto> GetSpecificCommand(string id, string marchantId)
        {
            if(string.IsNullOrEmpty(id) || string.IsNullOrEmpty(marchantId) ){
                return BadRequest(new Dto.StockReadDto("Missing parameters", null));
            }

            Guid userId = new Guid(id);
            if(userId == null){
                return BadRequest(new Dto.StockReadDto("Invalid id", null));
            }

            var item = _repository.GetCommandByUserIdAndMarchantId(userId, marchantId);
            if(item == null){
                return Ok(new Dto.StockReadDto("No Stock processor exists with the stated query params", null));
            }
            return Ok(new Dto.StockReadDto("Success", item));
        }

        
    }
}