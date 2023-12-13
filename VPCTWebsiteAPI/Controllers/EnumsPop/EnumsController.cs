using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;
using VPCT.Core.Models.MainModels.TaskModel.Enums;
using static VPCT.Core.Models.MainModels.DepartmentModel.CoQuanQuanLy;
using static VPCT.Core.Models.MainModels.ExpertModel.KinhNghiem;

namespace VPCTWebsiteAPI.Controllers.EnumsPop
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumsController : ControllerBase
    {
        [HttpGet("LoaiQuanLyOptions")]
        public IActionResult GetLoaiQuanLyOptions()
        {
            var options = Enum.GetNames(typeof(LoaiQuanLy)).Select(e => new { Value = e, Label = ((LoaiQuanLy)Enum.Parse(typeof(LoaiQuanLy), e)).GetDisplayName() });
            return Ok(options);
        }

        [HttpGet("LoaiKinhNghiemOptions")]
        public IActionResult GetLoaiKinhNghiemOptions()
        {
            var options = Enum.GetNames(typeof(LoaiKinhNghiem)).Select(e => new { Value = e, Label = ((LoaiKinhNghiem)Enum.Parse(typeof(LoaiKinhNghiem), e)).GetDisplayName() });
            return Ok(options);
        }

        [HttpGet("CapDaoTaoOptions")]
        public IActionResult GetCapDaoTaoOptions()
        {
            var options = Enum.GetNames(typeof(CapDaoTao)).Select(e => new { Value = e, Label = ((CapDaoTao)Enum.Parse(typeof(CapDaoTao), e)).GetDisplayName() });
            return Ok(options);
        }

        [HttpGet("ChucDanhHoiDongOptions")]
        public IActionResult GetChucDanhHoiDongOptions()
        {
            var options = Enum.GetNames(typeof(ChucDanhHoiDong)).Select(e => new { Value = e, Label = ((ChucDanhHoiDong)Enum.Parse(typeof(ChucDanhHoiDong), e)).GetDisplayName() });
            return Ok(options);
        }

        [HttpGet("KetQuaOptions")]
        public IActionResult GetKetQuaOptions()
        {
            var options = Enum.GetNames(typeof(KetQua)).Select(e => new { Value = e, Label = ((KetQua)Enum.Parse(typeof(KetQua), e)).GetDisplayName() });
            return Ok(options);
        }

        [HttpGet("LoaiHoiDongOptions")]
        public IActionResult GetLoaiHoiDongOptions()
        {
            var options = Enum.GetNames(typeof(LoaiHoiDong)).Select(e => new { Value = e, Label = ((LoaiHoiDong)Enum.Parse(typeof(LoaiHoiDong), e)).GetDisplayName() });
            return Ok(options);
        }

        [HttpGet("LoaiHoSoOptions")]
        public IActionResult GetLoaiHoSoOptions()
        {
            var options = Enum.GetNames(typeof(LoaiHoSo)).Select(e => new { Value = e, Label = ((LoaiHoSo)Enum.Parse(typeof(LoaiHoSo), e)).GetDisplayName() });
            return Ok(options);
        }

        [HttpGet("LoaiNhiemVuOptions")]
        public IActionResult GetLoaiNhiemVuOptions()
        {
            var options = Enum.GetNames(typeof(LoaiNhiemVu)).Select(e => new { Value = e, Label = ((LoaiNhiemVu)Enum.Parse(typeof(LoaiNhiemVu), e)).GetDisplayName() });
            return Ok(options);
        }

        [HttpGet("TrangThaiNhiemVuOptions")]
        public IActionResult GetTrangThaiNhiemVuOptions()
        {
            var options = Enum.GetNames(typeof(TrangThaiNhiemVu)).Select(e => new { Value = e, Label = ((TrangThaiNhiemVu)Enum.Parse(typeof(TrangThaiNhiemVu), e)).GetDisplayName() });
            return Ok(options);
        }
    }
}
