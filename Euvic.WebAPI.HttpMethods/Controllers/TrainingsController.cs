using Euvic.WebAPI.HttpMethods.Controllers.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Euvic.WebAPI.HttpMethods.Controllers
{
    [Route("api/trainings")]
    [ApiController]
    public class TrainingsController : ControllerBase
    {
        //
        // w każdym endpoincie zamień [?]() na odpowiednia metodę http: HttpGet, HttpPost, HttpPut, HttpPatch, HttpDelete
        //
        // ----------------------------------------------------------------------------------------------------------------

        // ten endpoint jest juz gotowy i zostalo tu zamienione Route("") na HttpGet("")
        [HttpGet("")]
        public IActionResult GetTrainings() => Ok();

        // endpointy poniżej są do zrobienia
        // ----------------------------------------------------------------------------------------------------------------
        [[?] ("{id}/attendees")]
        public IActionResult GetTrainingAttendees() => Ok();

        [[?] ("")]
        public IActionResult CreateTraining() => Ok();

        [[?] ("{id}")]
        public IActionResult DeleteTraining([FromRoute] int id) => Ok();

        [[?] ("{id}/attendee")]
        public IActionResult DeleteAttendee([FromRoute] int id) => Ok();

        [[?] ("{id}")]
        public IActionResult UpdateTraining([FromRoute] int id, [FromBody] UpdateTrainingRequest request) => Ok();

        [[?] ("{id}/duration")]
        public IActionResult ChangeTrainingDuration([FromRoute] int id, [FromBody] int durationInMinutes) => Ok();
    }
}
