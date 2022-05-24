﻿using ClinicaNuevoRosario.Application.Features.Doctors.Commands.AddDoctor;
using ClinicaNuevoRosario.Application.Features.Doctors.Commands.DeleteDoctor;
using ClinicaNuevoRosario.Application.Features.Doctors.Commands.UpdateDoctor;
using ClinicaNuevoRosario.Application.Features.Doctors.Queries.GetAllDoctors;
using ClinicaNuevoRosario.Application.Features.Doctors.Queries.SearchDoctors;
using ClinicaNuevoRosario.Application.Models.Doctors;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ClinicaNuevoRosario.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class DoctorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DoctorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "AllDoctors")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<DoctorViewModel>>> GetAllDoctors()
        {
            var query = new GetAllDoctorsQuery();
            return await _mediator.Send(query);
        }

        [HttpPost(Name = "SearchDoctor")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<DoctorViewModel>>> SearchDoctor(string text)
        {
            var query = new SearchDoctorsQuery() { Text = text};
            return await _mediator.Send(query);
        }

        [HttpPost(Name = "AddDoctor")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> AddDoctor([FromBody] AddDoctorCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut(Name = "UpdateDoctor")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateDoctor([FromBody] UpdateDoctorCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpDelete(Name = "DeleteDoctor")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> DeleteDoctor([FromBody] DeleteDoctorCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}