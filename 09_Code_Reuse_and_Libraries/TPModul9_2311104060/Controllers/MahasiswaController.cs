using Microsoft.AspNetCore.Mvc;
using TPModul9_2311104060.Models;

namespace TPModul9_2311104060.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Aulia Jasifa", Nim = "2311104060" },
            new Mahasiswa { Nama = "Reyner Atira", Nim = "2311104057" },
            new Mahasiswa { Nama = "Ilham Lii", Nim = "2311104068" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return mahasiswaList;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound();
            return mahasiswaList[index];
        }

        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa mhs)
        {
            mahasiswaList.Add(mhs);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound();

            mahasiswaList.RemoveAt(index);
            return Ok();
        }
    }
}
