using LeadSoft.Adapter.BrasilAPI.DTOs.Banks;
using LeadSoft.Adapter.BrasilAPI.DTOs.CNPJs;
using LeadSoft.Adapter.BrasilAPI.DTOs.Holidays;
using LeadSoft.Common.Library;
using LeadSoft.Common.Library.Exceptions;
using LeadSoft.Common.Library.Extensions;
using System.Net;
using static LeadSoft.Common.Library.HttpCall;

namespace LeadSoft.Adapter.BrasilAPI
{
    /// <summary>
    /// Brasil API integration
    /// </summary>
    public partial class BrasilApi : IBrasilApi
    {
        /// <summary>
        /// Method exposed to get Company information by cnpj
        /// </summary>
        /// <param name="aCNPJ">CNPJ</param>
        /// <returns>DTOBrasilApiCnpjResponse</returns>
        public async Task<DTOBrasilApiCnpjResponse> GetCnpjInfoAsync(string aCNPJ)
        {
            try
            {
                return await _Client.SendAsync<DTOBrasilApiCnpjResponse>(HttpMethod.Get, string.Format(BrasilApi_EndPoint.Get_CNPJ_v1, aCNPJ.OnlyNumeric()));
            }
            catch (HttpRequestException e)
            {
                DTOCallErrorResponse dtoError = e.Message.JsonToObject<DTOCallErrorResponse>();

                if (dtoError.StatusCode == (int)HttpStatusCode.NotFound)
                    return null; // CNPJ not found, return null

                throw dtoError.StatusCode switch
                {
                    (int)HttpStatusCode.BadRequest => new BadRequestAppException($"CNPJ inválido: {aCNPJ} | {dtoError.StatusCode} | {dtoError.Reason} -> '{dtoError.Content}'"),
                    //(int)HttpStatusCode.NotFound => new NotFoundAppException($"CNPJ não encontrado: {aCNPJ} | {dtoError.StatusCode} | {dtoError.Reason} -> '{dtoError.Content}'"),
                    (int)HttpStatusCode.TooManyRequests => new AppException($"Limite de requisições atingido: {aCNPJ} | {dtoError.StatusCode} | {dtoError.Reason} -> '{dtoError.Content}'"),
                    _ => throw new AppException($"{dtoError.StatusCode} | {dtoError.Reason} -> '{dtoError.Content}'"),
                };
            }
            catch (Exception)
            {
                throw;
            }
        }



        /// <summary>
        /// Method exposed to get Banks Information
        /// </summary>
        /// <returns>DTOBrasilApiBanksResponse</returns>
        public async Task<IList<DTOBrasilApiBankResponse>> GetBanksInfoAsync()
        {
            try
            {
                return await _Client.SendAsync<IList<DTOBrasilApiBankResponse>>(HttpMethod.Get, BrasilApi_EndPoint.Get_Banks_v1);
            }
            catch (HttpRequestException e)
            {
                DTOCallErrorResponse dtoError = e.Message.JsonToObject<DTOCallErrorResponse>();

                throw dtoError.StatusCode switch
                {
                    (int)HttpStatusCode.TooManyRequests => new AppException($"Limite de requisições atingido: {dtoError.StatusCode} | {dtoError.Reason} -> '{dtoError.Content}'"),
                    _ => throw new AppException($"{dtoError.StatusCode} | {dtoError.Reason} -> '{dtoError.Content}'"),
                };
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Method exposed to get Holidays dates
        /// </summary>
        /// <param name="aYear">Year</param>
        /// <returns>DTOBrasilApiHolidaysResponse</returns>
        public async Task<IList<DTOBrasilApiHolidayResponse>> GetHolidaysInfoAsync(int aYear)
        {
            try
            {
                return await _Client.SendAsync<IList<DTOBrasilApiHolidayResponse>>(HttpMethod.Get, BrasilApi_EndPoint.Get_Holidays_v1.Fill(aYear));
            }
            catch (HttpRequestException e)
            {
                DTOCallErrorResponse dtoError = e.Message.JsonToObject<DTOCallErrorResponse>();

                throw dtoError.StatusCode switch
                {
                    (int)HttpStatusCode.BadRequest => new BadRequestAppException($"Ano inválido: {aYear} | {dtoError.StatusCode} | {dtoError.Reason} -> '{dtoError.Content}'"),
                    (int)HttpStatusCode.NotFound => new NotFoundAppException($"Ano não encontrado: {aYear} | {dtoError.StatusCode} | {dtoError.Reason} -> '{dtoError.Content}'"),
                    (int)HttpStatusCode.TooManyRequests => new AppException($"Limite de requisições atingido: {aYear} | {dtoError.StatusCode} | {dtoError.Reason} -> '{dtoError.Content}'"),
                    _ => throw new AppException($"{dtoError.StatusCode} | {dtoError.Reason} -> '{dtoError.Content}'"),
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

