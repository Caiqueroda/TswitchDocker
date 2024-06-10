namespace DockerSampleAPI.Models
{
    public class Msg
    {
        public int Id { get; set; }
        public int Refnum { get; set; }
        public int Trace { get; set; }
        public int Pan { get; set; }
        public decimal TranAmount { get; set; }
        public DateOnly TranDate { get; set; }
        public TimeSpan TranTime { get; set; }
        public DateOnly LocalDate { get; set; }
        public TimeSpan LocalTime { get; set; }
        public int MCC { get; set; }
        public int RespCode { get; set; }
    }
}
