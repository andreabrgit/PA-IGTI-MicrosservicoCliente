using System;

namespace PA_IGTI_ClienteService
{
  public class Cliente
  {
    public string CodCliente { get; set; }

    public string DescCliente { get; set; }

    public string NmFantasia { get; set; }

    public string CNPJ { get; set; }

    public DateTime DataCadastro { get; set; }

    public DateTime DataAtualizacao { get; set; }
  }
}
