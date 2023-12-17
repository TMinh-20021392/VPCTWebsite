using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.TaskModel;
using VPCT.Repositories.Infrastructure;
using VPCTWebsiteAPI.Service;

namespace VPCTWebsiteAPI.Controllers.MainModels.TaskModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileDinhKemsController(IUnitOfWork context, IFileService fileService) : ControllerBase
    {

        // GET: api/FileDinhKems
        [HttpGet]
        public ActionResult<IEnumerable<FileDinhKem>> GetFileDinhKem()
        {
            return context.FileDinhKemRepository.GetAll().ToList();
        }

        // GET: api/FileDinhKems/5
        [HttpGet("{id}")]
        public ActionResult<FileDinhKem> GetFileDinhKem(int id)
        {
            var fileDinhKem = context.FileDinhKemRepository.Find(id);

            if (fileDinhKem == null)
            {
                return NotFound();
            }
            return fileDinhKem;
        }

        // PUT: api/FileDinhKems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFileDinhKemAsync(int id, FileDinhKem fileDinhKem)
        {
            if (id != fileDinhKem.Id)
            {
                return BadRequest();
            }

            fileService.DeleteFile(fileDinhKem.FileName);
            fileDinhKem.FileName = await fileService.SaveFile(fileDinhKem.File);

            if (ModelState.IsValid)
            {
                try
                {
                    context.FileDinhKemRepository.Update(fileDinhKem);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FileDinhKemExists(fileDinhKem.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/FileDinhKems
        [HttpPost]
        public async Task<ActionResult<FileDinhKem>> PostFileDinhKemAsync(FileDinhKem fileDinhKem)
        {
            fileDinhKem.FileName = await fileService.SaveFile(fileDinhKem.File);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.FileDinhKemRepository.Create(fileDinhKem);
            context.SaveChanges();

            return CreatedAtAction("GetFileDinhKem", new { id = fileDinhKem.Id }, fileDinhKem);
        }

        // DELETE: api/FileDinhKems/5
        [HttpDelete("{id}")]
        public IActionResult DeleteFileDinhKem(int id)
        {
            var fileDinhKem = context.FileDinhKemRepository.Find(id);
            if (fileDinhKem == null)
            {
                return NotFound();
            }
            fileService.DeleteFile(fileDinhKem.FileName);
            context.FileDinhKemRepository.Delete(fileDinhKem);
            context.SaveChanges();

            return NoContent();
        }

        private bool FileDinhKemExists(int id)
        {
            return (context.FileDinhKemRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpGet]
        [Route("DownloadFile")]
        public async Task<IActionResult> DownloadFile(string filename)
        {
            var x = await fileService.DownloadFile(filename);
            return File(x.Item1, x.Item2, x.Item3);
        }
    }
}
