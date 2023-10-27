using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Models;
using Web.Models;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThreadsController : ControllerBase
    {
        private readonly IThreadContentService _threadContentService;
        private readonly IForumThreadService _threadService;

        public ThreadsController(IThreadContentService threadContentService, IForumThreadService threadService)
        {
            _threadContentService = threadContentService;
            _threadService = threadService;
        }

        [HttpGet]
        public async Task<List<FullThread>> Get()
        {
            var threadsMetadata = await _threadService.GetAll();
            var threadsContent = (await _threadContentService.GetAsync()).ToDictionary(x => x.Id, x => x.Content);

            var fullInfo = threadsMetadata.Select(x => new FullThread { Id = x.Id, Author = x.Author, Created = x.Created, Title = x.Title, Content = threadsContent[x.DocumentKey] });

            return fullInfo.ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ThreadContent>> Get(string id)
        {
            var ForumThread = await _threadContentService.GetAsync(id);

            if (ForumThread is null)
            {
                return NotFound();
            }

            return ForumThread;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ThreadContent newForumThread)
        {
            await _threadContentService.CreateAsync(newForumThread);

            return CreatedAtAction(nameof(Get), new { id = newForumThread.Id }, newForumThread);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, ThreadContent updatedForumThread)
        {
            var ForumThread = await _threadContentService.GetAsync(id);

            if (ForumThread is null)
            {
                return NotFound();
            }

            updatedForumThread.Id = ForumThread.Id;

            await _threadContentService.UpdateAsync(id, updatedForumThread);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var ForumThread = await _threadContentService.GetAsync(id);

            if (ForumThread is null)
            {
                return NotFound();
            }

            await _threadContentService.RemoveAsync(id);

            return NoContent();
        }
    }
}
