# LeadSoft® Brasil Api Integration Adapter
## [LeadSoft.Adapter.BrasilAPI](https://www.nuget.org/packages/LeadSoft.Adapter.BrasilAPI)


Adapter .NET para integrar com serviços públicos da BrasilAPI (https://brasilapi.com.br/).
Fornece uma camada simples e testável para consumir endpoints públicos da BrasilAPI (ex.: Bancos, CNPJ, Feriados, etc.), encapsulando chamadas HTTP, mapeamento de modelos e tratamento de erros de forma consistente para aplicações .NET 9.

> Este pacote é um tributo independente e não é afiliado oficialmente à [BrasilAPI](https://brasilapi.com.br/).
> Somos gratos pela iniciativa de disponibilizar dados públicos de forma aberta. Conheça o projeto oficial e utilizando este pacote, você concorda automaticamente com os [termos de uso da BrasilAPI](https://brasilapi.com.br/#termos-de-uso).

#### [Nuget.Org: LeadSoft.Adapter.BrasilAPI](https://www.nuget.org/packages/LeadSoft.Adapter.BrasilAPI)
#### [GitHub Repo: leadsoft-adapter-brasilapi](https://github.com/LeadSoft-Solucoes-Web/leadsoft-adapter-brasilapi)

## Principais características
- Compatível com .NET 9.0.
- Chamadas assíncronas com `async`/`await`.
- Integração simples com _Dependency Injection_ (DI) do .NET.
- Projetado para ser testável (injeção de `HttpClient`, separação de responsabilidades).
- Tratamento centralizado de erros e respostas HTTP.
- Extensível para políticas de resiliência (ex.: Polly).
- Open Source (MIT License).

## Métodos disponíveis
- `Task<DTOBrasilApiCnpjResponse> GetCnpjInfoAsync(string aCNPJ)`
    - Consulta dados de empresa pela string CNPJ.
- `Task<IList<DTOBrasilApiBankResponse>> GetBanksInfoAsync()`
    - Recupera a lista de bancos que operam no Brasil conhecida pela BrasilAPI.
- `Task<IList<DTOBrasilApiHolidayResponse>> GetHolidaysInfoAsync(int aYear)`
    - Retorna os feriados do Brasil para o ano informado.

## Instalação
Pelo CLI do .NET:

```bash
dotnet add package LeadSoft.Adapter.BrasilAPI
```

Ou via NuGet Package Manager no Visual Studio (pesquise por `LeadSoft.Adapter.BrasilAPI`).

## Uso básico (exemplo)
Abaixo um exemplo genérico de como registrar e usar o adapter em uma aplicação ASP.NET Core / Console com DI e `IHttpClientFactory`.

```csharp
// Program.cs (exemplo)
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LeadSoft.Adapter.BrasilAPI;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//...
builder.Logging.AddBrasilApi(); //builder.Logging.AddBrasilApi(true); para injeção em singleton
//...

WebApplication app = builder.Build();
app.Run();
```

Exemplo de chamada (pseudocódigo; adapte para os tipos reais do pacote):

```csharp
string cnpj = "38.0443.762/0001-48";
DTOBrasilApiCnpjResponse dto = await new BrasilApi().GetCnpjInfoAsync(cnpj);
```

## Configuração recomendada
- Use `IHttpClientFactory` (ex.: `services.AddHttpClient(...)`) para gerenciar instâncias de `HttpClient` de forma segura.
- Configure timeouts e cabeçalhos (User-Agent) apropriados.
- Adicione políticas de resiliência com Polly (retries exponenciais, circuit-breaker) para lidar com intermitências da rede.
- Logue chamadas importantes e erros com `ILogger<T>` para facilitar diagnóstico.

## Boas práticas de integração
- Nunca crie instâncias estáticas de `HttpClient` sem usar `IHttpClientFactory`.
- Propague `CancellationToken` nas chamadas assíncronas.
- Valide entradas (ex.: comprimentos de CNPJ) antes de chamar o adapter para evitar chamadas desnecessárias.
- Centralize conversão/mapeamento de modelos se precisar adaptar respostas para seu domínio.
- Trate status HTTP não 2xx de forma explícita — o adapter deve expor erro detalhado para logging e retries.

## Testes
- Ao escrever testes unitários, injete um `HttpMessageHandler` falso no `HttpClient` para simular respostas da BrasilAPI.
- Teste cenários de sucesso, 404/422 e falhas de rede/timeouts.
- Utilize fixtures para dados conhecidos (ex.: consultas de CNPJ válidos).

## Versionamento e compatibilidade
- Projeto direcionado para .NET 9.0. Verifique a compatibilidade do pacote com sua aplicação.
- Seguir práticas de versionamento semântico: breaking changes → major, novas features → minor, correções → patch.

## Licença
Consulte o arquivo de licença no repositório para detalhes sobre uso e redistribuição.

---

LeadSoft.Adapter.BrasilAPI — adapter leve e testável para facilitar a integração com serviços públicos da BrasilAPI em aplicações .NET 9.

###  Development  
Desenvolvido pelo time da LeadSoft® Soluções Web.
* Lucas Resende Tavares
* Frederico Ferreira Bitencourt
* Pedro Foresti Leão
  
#### Nossa empresa
LeadSoft Soluções Web Ltda
CNPJ 38.043.762/0001-48

#### Como nos encontrar:
- [Nosso Site](https://www.leadsoft.inf.br)
- [GitHub](https://github.com/LeadSoft-Solucoes-Web)
- [LinkedIn](https://www.linkedin.com/company/leadsoft-solucoes-web)
- [Behance](https://www.behance.net/leadsofsolue)
- [YouTube](https://www.youtube.com/@LeadsoftSolucoesWeb)
- [Instagram](https://www.instagram.com/leadsoft.inf/)
- [Facebook](https://www.facebook.com/leadsoft.inf.br)

#### INFORMAÇÕES DE CONTATO  Se você tiver alguma dúvida sobre estes Termos ou Serviços, entre em contato conosco em
[developers@leadsoft.inf.br](mailto:developers@leadsoft.inf.br).