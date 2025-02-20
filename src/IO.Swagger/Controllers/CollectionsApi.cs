/*
 * Index Card API
 *
 * This is a simple server for loading and saving index cards
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class CollectionsApiController : ControllerBase
    { 
        /// <summary>
        /// delete the selected collection
        /// </summary>
        /// <param name="collectionId"></param>
        /// <response code="204">successfully deleted collection</response>
        /// <response code="404">collection not found</response>
        /// <response code="500">internal server error</response>
        [HttpDelete]
        [Route("/v1/collections/{collectionId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CollectionsCollectionIdDelete")]
        public virtual IActionResult CollectionsCollectionIdDelete([FromRoute][Required]Guid? collectionId)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all collections of user
        /// </summary>
        /// <param name="userId"></param>
        /// <response code="200">Successfully pulled all collections</response>
        /// <response code="500">internal server error</response>
        [HttpGet]
        [Route("/v1/collections/{userId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CollectionsUserIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Collections>), description: "Successfully pulled all collections")]
        public virtual IActionResult CollectionsUserIdGet([FromRoute][Required]Guid? userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Collections>));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);
            string exampleJson = null;
            exampleJson = "[ {\n  \"numberOfCards\" : 20,\n  \"collectionId\" : \"9666e8bf-6f37-44d1-aab4-f2faaf6da243\",\n  \"userId\" : \"9666e8bf-6f37-44d1-aab4-f2faaf6da243\",\n  \"collectionName\" : \"Geography\"\n}, {\n  \"numberOfCards\" : 20,\n  \"collectionId\" : \"9666e8bf-6f37-44d1-aab4-f2faaf6da243\",\n  \"userId\" : \"9666e8bf-6f37-44d1-aab4-f2faaf6da243\",\n  \"collectionName\" : \"Geography\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Collections>>(exampleJson)
                        : default(List<Collections>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create a new collection
        /// </summary>
        /// <param name="body">the new collection</param>
        /// <param name="userId"></param>
        /// <response code="200">Successfully created new collection</response>
        /// <response code="500">Internal server error</response>
        [HttpPost]
        [Route("/v1/collections/{userId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CollectionsUserIdPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse200), description: "Successfully created new collection")]
        public virtual IActionResult CollectionsUserIdPost([FromBody]Collections body, [FromRoute][Required]Guid? userId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse200));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);
            string exampleJson = null;
            exampleJson = "{\n  \"collectionName\" : \"Geography\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponse200>(exampleJson)
                        : default(InlineResponse200);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
