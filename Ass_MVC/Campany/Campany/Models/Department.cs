using System.ComponentModel.DataAnnotations;

namespace Campany.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? DepartmentCode { get; set; }
        public string? Address { get; set; }
        public int RoomNumber { get; set; }
    }
}
