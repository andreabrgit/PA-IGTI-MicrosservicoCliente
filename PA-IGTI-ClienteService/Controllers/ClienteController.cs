using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PA_IGTI_ClienteService.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ClienteController : ControllerBase
  {
    public ClienteController()
    {

    }

    [HttpGet]
    public IActionResult Get()
    {
      string connectionString =
        "Server=fabricabh-sql-srv.database.windows.net;Database=ClientesDB;User Id=fabrica; Password=Pa55@5qL";

      string queryString =
          "SELECT * FROM Cliente";

      //int paramValue = 5;

      using (SqlConnection connection =
          new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(queryString, connection);
        //command.Parameters.AddWithValue("@pricePoint", paramValue);

        try
        {
          Cliente cliente;
          List<Cliente> clientes = new List<Cliente>();

          connection.Open();
          SqlDataReader reader = command.ExecuteReader();
          while (reader.Read())
          {
            cliente = new Cliente();
            cliente.CodCliente = reader["CodCliente"].ToString();
            cliente.DescCliente = reader["DescCliente"].ToString();
            cliente.NmFantasia = reader["NmFantasia"].ToString();
            cliente.CNPJ = reader["CNPJ"].ToString();
            cliente.DataCadastro = DateTime.Parse(reader["DataCadastro"].ToString());
            cliente.DataAtualizacao = DateTime.Parse(reader["DataAtualizacao"].ToString());
            clientes.Add(cliente);
          }
          reader.Close();

          return Ok(clientes);
        }
        catch (Exception ex)
        {
          return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao retornar clientes");
        }
      }
    }

    [HttpPost]
    public IActionResult Post(Cliente cliente)
    {
      return Ok(cliente);
    }

    [HttpPut]
    public IActionResult Put(Cliente cliente)
    {
      return Ok(cliente);
    }

    [HttpDelete]
    public IActionResult Delete(Cliente cliente)
    {
      return Ok("Cliente excluído com sucesso");
    }
  }
}
