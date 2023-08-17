namespace BusinessLogic.Contracts
{
    public class ClientDto
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public IEnumerable<AccountDto> AccountDtos { get; set; }
    }
}