using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VPCT.Core.Models.MainModels.TaskModel.Enums;
using static VPCT.Core.Models.MainModels.DepartmentModel.CoQuanQuanLy;
using static VPCT.Core.Models.MainModels.ExpertModel.KinhNghiem;

namespace VPCTWebsiteAPI.Controllers.EnumsPop
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumsController : ControllerBase
    {
        private string GetEnumDisplayName(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var displayAttribute = fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault() as DisplayAttribute;
            return displayAttribute?.Name ?? value.ToString();
        }

        [HttpGet("LoaiQuanLyOptions")]
        public IActionResult GetLoaiQuanLyOptions()
        {
            var options = Enum.GetValues(typeof(LoaiQuanLy))
                            .Cast<LoaiQuanLy>()
                            .Select(e => new { Value = e, Label = GetEnumDisplayName(e) });
            return Ok(options);
        }

        [HttpGet("LoaiKinhNghiemOptions")]
        public IActionResult GetLoaiKinhNghiemOptions()
        {
            var options = Enum.GetValues(typeof(LoaiKinhNghiem))
                            .Cast<LoaiKinhNghiem>()
                            .Select(e => new { Value = e, Label = GetEnumDisplayName(e) });
            return Ok(options);
        }

        [HttpGet("CapDaoTaoOptions")]
        public IActionResult GetCapDaoTaoOptions()
        {
            var options = Enum.GetValues(typeof(CapDaoTao))
                            .Cast<CapDaoTao>()
                            .Select(e => new { Value = e, Label = GetEnumDisplayName(e) });
            return Ok(options);
        }

        [HttpGet("ChucDanhHoiDongOptions")]
        public IActionResult GetChucDanhHoiDongOptions()
        {
            var options = Enum.GetValues(typeof(ChucDanhHoiDong))
                            .Cast<ChucDanhHoiDong>()
                            .Select(e => new { Value = e, Label = GetEnumDisplayName(e) });
            return Ok(options);
        }

        [HttpGet("KetQuaOptions")]
        public IActionResult GetKetQuaOptions()
        {
            var options = Enum.GetValues(typeof(KetQua))
                            .Cast<KetQua>()
                            .Select(e => new { Value = e, Label = GetEnumDisplayName(e) });
            return Ok(options);
        }

        [HttpGet("LoaiHoiDongOptions")]
        public IActionResult GetLoaiHoiDongOptions()
        {
            var options = Enum.GetValues(typeof(LoaiHoiDong))
                            .Cast<LoaiHoiDong>()
                            .Select(e => new { Value = e, Label = GetEnumDisplayName(e) });
            return Ok(options);
        }

        [HttpGet("LoaiHoSoOptions")]
        public IActionResult GetLoaiHoSoOptions()
        {
            var options = Enum.GetValues(typeof(LoaiHoSo))
                            .Cast<LoaiHoSo>()
                            .Select(e => new { Value = e, Label = GetEnumDisplayName(e) });
            return Ok(options);
        }

        [HttpGet("LoaiNhiemVuOptions")]
        public IActionResult GetLoaiNhiemVuOptions()
        {
            var options = Enum.GetValues(typeof(LoaiNhiemVu))
                .Cast<LoaiNhiemVu>()
                .Select(e => new { Value = e, Label = GetEnumDisplayName(e) });
            return Ok(options);
        }

        [HttpGet("TrangThaiNhiemVuOptions")]
        public IActionResult GetTrangThaiNhiemVuOptions()
        {
            var options = Enum.GetValues(typeof(TrangThaiNhiemVu))
                .Cast<TrangThaiNhiemVu>()
                .Select(e => new { Value = e, Label = GetEnumDisplayName(e) });
            return Ok(options);
        }
    }
}
