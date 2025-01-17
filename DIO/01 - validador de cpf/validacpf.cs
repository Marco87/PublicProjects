using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;

namespace cpffunction
{
    public static class fnvalidacpf
    {
        [FunctionName("validacpf")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Iniciando a validação do CPF.");

            //string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            if(data == null)
            {
                return new BadRequestObjectResult("Por favor, informe o CPF.");
            }
            string cpf = data?.cpf;

            if(ValidaCPF(cpf) == false)
            return new BadRequestObjectResult("CPF Inválido");
            string responseMessage = "CPF Válido";

            return new OkObjectResult(responseMessage);
        }

        public static bool ValidaCPF(string cpf){
            if(string.IsNullOrEmpty(cpf))
            return false;

            // Remove caracteres não numéricos
        cpf = new string(cpf.Where(char.IsDigit).ToArray());

        // Verifica se o CPF tem 11 dígitos
        if (cpf.Length != 11)
            return false;

        // Verifica se todos os dígitos são iguais (ex.: "111.111.111-11" é inválido)
        if (cpf.Distinct().Count() == 1)
            return false;

        // Calcula o primeiro dígito verificador
        int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int soma1 = 0;
        for (int i = 0; i < multiplicadores1.Length; i++)
            soma1 += (cpf[i] - '0') * multiplicadores1[i];
        
        int digito1 = soma1 % 11 < 2 ? 0 : 11 - (soma1 % 11);

        // Calcula o segundo dígito verificador
        int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int soma2 = 0;
        for (int i = 0; i < multiplicadores2.Length; i++)
            soma2 += (cpf[i] - '0') * multiplicadores2[i];

        int digito2 = soma2 % 11 < 2 ? 0 : 11 - (soma2 % 11);

        // Verifica se os dígitos verificadores estão corretos
        return cpf[9] - '0' == digito1 && cpf[10] - '0' == digito2;
        }
    }
}
