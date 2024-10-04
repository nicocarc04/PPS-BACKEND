﻿using Application.Interfaces;
using Application.Models.Requests;
using Application.Models;
using Application.Services;
using Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipController : ControllerBase
    {
        private readonly IMembershipService _membershipService;
        public MembershipController(IMembershipService membershipService)
        {
            _membershipService = membershipService;
        }

        [HttpGet("[action]")]

        public ActionResult<List<MembershipDto>> Get()
        {
           

            var user = _membershipService.Get();

            return Ok(user);
        }


        [HttpPost("[action]")]
        public ActionResult<MembershipDto> Add([FromBody] MembershipRequest membershipRequest)
        {
            var membershipDto = _membershipService.AddMembership(membershipRequest);
            return Ok(membershipDto);
        }

        
        [HttpPut("[action]")]
        public ActionResult Update(string typeMembership, [FromBody] MembershipRequest membershipRequest)
        {
            _membershipService.Update(typeMembership, membershipRequest);
            return NoContent();
        }

        public IActionResult Delete(string typeMembership)
        {
            try
            {
                _membershipService.Delete(typeMembership);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}
