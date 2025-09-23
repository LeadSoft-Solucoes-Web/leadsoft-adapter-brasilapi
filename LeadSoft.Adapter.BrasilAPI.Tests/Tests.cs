using LeadSoft.Adapter.BrasilAPI.DTOs.CNPJs;

namespace LeadSoft.Adapter.BrasilAPI.Tests
{
    public class Tests
    {
        [Fact]
        public async Task BrasilAPI_CNPJ()
        {
            DTOBrasilApiCnpjResponse dto = await new BrasilApi().GetCnpjInfoAsync("38043762000148");

            Assert.True(dto is not null);
        }
    }
}
