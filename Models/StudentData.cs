using System.ComponentModel.DataAnnotations;

namespace testdb.Models
{
    public class StudentData
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }

    }
}
