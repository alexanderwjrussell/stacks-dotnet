﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using xxAMIDOxx.xxSTACKSxx.API.Models.Requests;

namespace xxAMIDOxx.xxSTACKSxx.API.Controllers
{
    /// <summary>
    /// Menu related operations
    /// </summary>
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiExplorerSettings(GroupName = "Menu")]
    [ApiController]
    public class UpdateMenuController : ApiControllerBase
    {
        public UpdateMenuController()
        {
        }


        /// <summary>
        /// Update a menu
        /// </summary>
        /// <remarks>Update a menu with new information</remarks>
        /// <param name="id">menu id</param>
        /// <param name="body">Menu being updated</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Resource not found</response>
        [HttpPut("/v1/menu/{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateMenu([FromRoute][Required] Guid id, [FromBody] UpdateMenuRequest body)
        {
            // NOTE: Please ensure the API returns the response codes annotated above

            await Task.CompletedTask; // Your async code will be here

            return StatusCode(204);
        }
    }
}
