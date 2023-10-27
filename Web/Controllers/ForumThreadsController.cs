using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Models;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ForumThreadsController : ControllerBase
    {
        private readonly IForumThreadsService _forumThreadsService;

        public ForumThreadsController(IForumThreadsService ForumThreadsService)
        {
            _forumThreadsService = ForumThreadsService;
        }

        [HttpGet]
        public async Task<List<ForumThread>> Get()
        {
            await Task.Delay(2000);
            return await _forumThreadsService.GetAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ForumThread>> Get(string id)
        {
            var ForumThread = await _forumThreadsService.GetAsync(id);

            if (ForumThread is null)
            {
                return NotFound();
            }

            return ForumThread;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ForumThread newForumThread)
        {
            await _forumThreadsService.CreateAsync(newForumThread);

            return CreatedAtAction(nameof(Get), new { id = newForumThread.Id }, newForumThread);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, ForumThread updatedForumThread)
        {
            var ForumThread = await _forumThreadsService.GetAsync(id);

            if (ForumThread is null)
            {
                return NotFound();
            }

            updatedForumThread.Id = ForumThread.Id;

            await _forumThreadsService.UpdateAsync(id, updatedForumThread);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var ForumThread = await _forumThreadsService.GetAsync(id);

            if (ForumThread is null)
            {
                return NotFound();
            }

            await _forumThreadsService.RemoveAsync(id);

            return NoContent();
        }
    }
}
