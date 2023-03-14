﻿using DomainService.Models;
using DomainService.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Anket.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnswerController : Controller
    {
        private readonly IAnswerRepository _answerRepository;
        public AnswerController(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }

        [Route("GetAnswers")]
        [HttpGet]
        public async Task<IActionResult> GetAnswers()
        {
            return Ok(await _answerRepository.Get().ToListAsync());
        }

        [Route("GetAnswerById")]
        [HttpGet]
        public async Task<IActionResult> GetAnswerById(int id)
        {
            var answer = await _answerRepository.FindById(id);
            if (answer == null)
                return NotFound();

            return Ok(answer);
        }

        [Route("CreateAnswer")]
        [HttpPost]
        public async Task<ActionResult<Answer>> CreateAnswer(Answer answer)
        {
            await _answerRepository.Create(answer);
            return Ok();
        }

        [Route("EditAnswer")]
        [HttpPut]
        public async Task<ActionResult<Answer>> EditAnswer(Answer answer)
        {
            await _answerRepository.Create(answer);
            return Ok();
        }

        [Route("DeleteAnswer")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAnswer(int id)
        {
            await _answerRepository.Remove(id);
            return Ok();
        }
    }
}
