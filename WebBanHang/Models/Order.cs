using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập họ tên !!! ")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ !!! ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại !!! ")]
        public string Phone { get; set; }
        public double Total { get; set; }
        public string State { get; set; }
    }
}
