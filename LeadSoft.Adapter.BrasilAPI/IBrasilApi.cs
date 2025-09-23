using LeadSoft.Adapter.BrasilAPI.DTOs.Banks;
using LeadSoft.Adapter.BrasilAPI.DTOs.CNPJs;
using LeadSoft.Adapter.BrasilAPI.DTOs.Holidays;

namespace LeadSoft.Adapter.BrasilAPI
{
    /// <summary>
    /// Brasil API integration interface
    /// </summary>
    public interface IBrasilApi : IDisposable
    {
        /// <summary>
        /// Method exposed to get Company information by cnpj
        /// </summary>
        /// <param name="aCNPJ">CNPJ</param>
        /// <returns>DTOBrasilApiCnpjResponse</returns>
        Task<DTOBrasilApiCnpjResponse> GetCnpjInfoAsync(string aCNPJ);

        /// <summary>
        /// Method exposed to get Banks Information
        /// </summary>
        /// <returns>DTOBrasilApiBanksResponse</returns>
        Task<IList<DTOBrasilApiBankResponse>> GetBanksInfoAsync();

        /// <summary>
        /// Method exposed to get Holidays dates
        /// </summary>
        /// <param name="aYear">Year</param>
        /// <returns>DTOBrasilApiHolidaysResponse</returns>
        Task<IList<DTOBrasilApiHolidayResponse>> GetHolidaysInfoAsync(int aYear);
    }
}

