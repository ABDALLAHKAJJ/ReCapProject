using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public short ModelYear { get; set; }
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}