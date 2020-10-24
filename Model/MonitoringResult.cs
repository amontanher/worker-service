namespace worker_service.Model
{
    public class MonitoringResult
    {
        public string Horario { get; set; }
        public string Host { get; set; }
        public string Status { get; set; }
        public object Exception { get; set; }
    }
}