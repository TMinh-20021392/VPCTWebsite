using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.DocAndFileTypes;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.DocAndFileTypes
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileTypesController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/FileTypes
        [HttpGet]
        public ActionResult<IEnumerable<FileType>> GetFileTypes()
        {
            return context.FileTypeRepository.GetAll().ToList();
        }

        // GET: api/FileTypes/5
        [HttpGet("{id}")]
        public ActionResult<FileType> GetFileType(int id)
        {
            var fileType = context.FileTypeRepository.Find(id);

            if (fileType == null)
            {
                return NotFound();
            }

            return fileType;
        }

        // PUT: api/FileTypes/5
        [HttpPut("{id}")]
        public IActionResult PutFileType(int id, FileType fileType)
        {
            if (id != fileType.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.FileTypeRepository.Update(fileType);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FileTypeExists(fileType.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/FileTypes
        [HttpPost]
        public ActionResult<FileType> PostFileType(FileType fileType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.FileTypeRepository.Create(fileType);
            context.SaveChanges();

            return CreatedAtAction("GetFileType", new { id = fileType.Id }, fileType);
        }

        // DELETE: api/FileTypes/5
        [HttpDelete("{id}")]
        public IActionResult DeleteFileType(int id)
        {
            var fileType = context.FileTypeRepository.Find(id);
            if (fileType == null)
            {
                return NotFound();
            }

            context.FileTypeRepository.Delete(fileType);
            context.SaveChanges();

            return NoContent();
        }

        private bool FileTypeExists(int id)
        {
            return (context.FileTypeRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
