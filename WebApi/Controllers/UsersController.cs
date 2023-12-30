﻿using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add")]
        public IActionResult Add(AuthDto authDto )
        {
            _userService.Add(authDto);
            return Ok("Kullanıcı Kaydı başarılı");
        }

        [HttpGet("getList")]
        public IActionResult GetList()
        {
             
            return Ok(_userService.GetList());
        }
    }
}
