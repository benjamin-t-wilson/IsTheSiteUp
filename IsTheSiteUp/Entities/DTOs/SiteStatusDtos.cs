namespace IsTheSiteUp.Entities.DTOs
{
    public class StatusCheckDto
    {
        public string Site { get; set; }
    }

    public class StatusCheckResponseDto : StatusCheckDto
    {
        public bool IsUp { get; set; }
    }
}