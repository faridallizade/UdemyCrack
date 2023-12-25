using System.Reflection.Metadata.Ecma335;

namespace UdemyCrack.DTOs.BaseDto
{
    public class BaseAuditableEntityDto:BaseEntityDto
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
