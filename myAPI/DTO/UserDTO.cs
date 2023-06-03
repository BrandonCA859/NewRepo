namespace myAPI.DTO
{
    public record UserDTO(string Name, string PhoneNumber, string Email, string Password, string Address, DateTime birthdate)
    {
    }
}
