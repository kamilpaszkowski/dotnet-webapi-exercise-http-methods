using Euvic.WebAPI.HttpMethods.Controllers.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Euvic.WebAPI.HttpMethods.Controllers
{
    [Route("api/trainings")]
    [ApiController]
    public class TrainingsController : ControllerBase
    {
        //
        // w każdym endpoincie zamień Route() na odpowiednia metodę http: HttpGet, HttpPost, HttpPut, HttpPatch, HttpDelete
        //
        // ----------------------------------------------------------------------------------------------------------------

        // ten endpoint jest juz gotowy i zostalo tu zamienione Route("") na HttpGet("")
        [HttpGet("")]
        public IActionResult GetTrainings() => Ok();

        [Route("{id}/attendees")]
        public IActionResult GetTrainingAttendees() => Ok();

        [Route("")]
        public IActionResult CreateTraining() => Ok();

        [Route("{id}")]
        public IActionResult DeleteTraining([FromRoute] int id) => Ok();

        [Route("{id}/attendee")]
        public IActionResult DeleteAttendee([FromRoute] int id) => Ok();

        [Route("{id}")]
        public IActionResult UpdateTraining([FromRoute] int id, [FromBody] UpdateTrainingRequest request) => Ok();

        [Route("{id}/duration")]
        public IActionResult ChangeTrainingDuration([FromRoute] int id, [FromBody] int durationInMinutes) => Ok();
    }
}
