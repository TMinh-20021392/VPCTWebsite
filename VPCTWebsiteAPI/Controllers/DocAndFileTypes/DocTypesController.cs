using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.DocAndFileTypes;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.DocAndFileTypes
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocTypesController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/DocTypes
        [HttpGet]
        public ActionResult<IEnumerable<DocType>> GetDocTypes()
        {
            return context.DocTypeRepository.GetAll().ToList();
        }

        // GET: api/DocTypes/5
        [HttpGet("{id}")]
        public ActionResult<DocType> GetDocType(int id)
        {
            var docType = context.DocTypeRepository.Find(id);

            if (docType == null)
            {
                return NotFound();
            }

            return docType;
        }

        // PUT: api/DocTypes/5
        [HttpPut("{id}")]
        public IActionResult PutDocType(int id, DocType docType)
        {
            if (id != docType.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.DocTypeRepository.Update(docType);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocTypeExists(docType.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/DocTypes
        [HttpPost]
        public ActionResult<DocType> PostDocType(DocType docType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.DocTypeRepository.Create(docType);
            context.SaveChanges();

            return CreatedAtAction("GetDocType", new { id = docType.Id }, docType);
        }

        // DELETE: api/DocTypes/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDocType(int id)
        {
            var docType = context.DocTypeRepository.Find(id);
            if (docType == null)
            {
                return NotFound();
            }

            context.DocTypeRepository.Delete(docType);
            context.SaveChanges();

            return NoContent();
        }

        private bool DocTypeExists(int id)
        {
            return (context.DocTypeRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
