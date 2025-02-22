using Comunicacao.DTO;

namespace Comunicacao.Request
{
    public class RequestUserJson
    {
        public int Id { get; set; }
        public string gender { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string cell { get; set; } = string.Empty;
    }
}
