using System;

namespace WeHeMo.DTO
{
    public class DTO_Test
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public int? Code { get; set; }
        public string Status { get; set; }
        public bool? Succeed { get; set; }
        public DateTime? Date { get; set; }
    }
}
