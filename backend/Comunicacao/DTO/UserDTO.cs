namespace Comunicacao.DTO
{
    public class UserDTO
    {
        public string gender { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public NameDTO? name { get; set; }
        public string cell { get; set; } = string.Empty;
    }

    public class NameDTO
    {
        public string first { get; set; } = string.Empty;
        public string last { get; set; } = string.Empty;
    }

    public class APIResponse
    {
        public List<UserDTO>? results { get; set; }
    }
}
