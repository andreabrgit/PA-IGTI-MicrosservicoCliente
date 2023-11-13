using System;
using System.Collections.Generic;
using System.Data;

namespace PA_IGTI_ClienteService
{
  public class ClienteMoc
  {
    #region Dados Fake
    private static List<string> listaClientesString = new List<string>
    {
      "1,Fake S.A.,Fake,89390483534951,Feb 13 2023 12:00AM,Oct  6 2023 12:00AM",
      "2,Iola S.A.,Iola,90700869234965,Mar 11 2023 12:00AM,Jan  3 2022 12:00AM",
      "3,Yoshio S.A.,Yoshio,42683737056082,Jan 17 2022 12:00AM,Jun 11 2022 12:00AM",
      "4,Cole S.A.,Cole,57327712686406,Aug 30 2022 12:00AM,May 10 2022 12:00AM",
      "5,Burton S.A.,Burton,59716348692148,May 28 2023 12:00AM,Mar 10 2022 12:00AM",
      "6,Maia S.A.,Maia,10743797645584,Dec  3 2021 12:00AM,Jan  6 2023 12:00AM",
      "7,Camden S.A.,Camden,33606396119048,Sep 19 2022 12:00AM,Oct 16 2023 12:00AM",
      "8,Ishmael S.A.,Ishmael,92964895090716,Jun  4 2023 12:00AM,Dec 19 2022 12:00AM",
      "9,Amir S.A.,Amir,69075596850608,Sep 11 2022 12:00AM,Jan  3 2022 12:00AM",
      "10,Norman S.A.,Norman,78611309271673,Aug 16 2023 12:00AM,Jul 14 2023 12:00AM",
      "11,Sarah S.A.,Sarah,6580047737889,Jul 12 2023 12:00AM,Feb 10 2022 12:00AM",
      "12,Myles S.A.,Myles,75802184451308,May 11 2023 12:00AM,Dec 11 2022 12:00AM",
      "13,Vivian S.A.,Vivian,47427841077992,May 17 2023 12:00AM,Jun 18 2023 12:00AM",
      "14,Buffy S.A.,Buffy,39630030006132,Jan 25 2022 12:00AM,Feb  2 2023 12:00AM",
      "15,Fletcher S.A.,Fletcher,56211824156222,Nov 13 2022 12:00AM,Feb  2 2023 12:00AM",
      "16,Zena S.A.,Zena,64989582299849,Oct 27 2023 12:00AM,Oct 12 2022 12:00AM",
      "17,Yasir S.A.,Yasir,58137485265164,Jun 30 2023 12:00AM,Apr  7 2022 12:00AM",
      "18,Aaron S.A.,Aaron,7025875312509,Aug 11 2023 12:00AM,Feb  2 2022 12:00AM",
      "19,Debra S.A.,Debra,3301495935631,Feb 21 2022 12:00AM,Jun 29 2023 12:00AM",
      "20,Geoffrey S.A.,Geoffrey,40804939809130,Apr 29 2022 12:00AM,Jun 30 2022 12:00AM",
      "21,Nicholas S.A.,Nicholas,70675537964345,Oct 28 2023 12:00AM,Aug 21 2023 12:00AM",
      "22,Kameko S.A.,Kameko,6230471442423,Dec 15 2022 12:00AM,May 21 2023 12:00AM",
      "23,Kermit S.A.,Kermit,33387028351353,Jun 16 2023 12:00AM,Jul 10 2022 12:00AM",
      "24,Irene S.A.,Irene,66563581718310,Feb 25 2022 12:00AM,Feb  6 2022 12:00AM",
      "25,Breanna S.A.,Breanna,78388812751476,Jul  3 2023 12:00AM,Oct 19 2023 12:00AM",
      "26,Rajah S.A.,Rajah,97184569854504,Dec 23 2021 12:00AM,May 24 2023 12:00AM",
      "27,Herrod S.A.,Herrod,30553430240504,Mar  1 2023 12:00AM,Jan 22 2023 12:00AM",
      "28,Harding S.A.,Harding,57017602354388,Aug 14 2023 12:00AM,Jul 11 2022 12:00AM",
      "29,Zenaida S.A.,Zenaida,97055878104325,Apr 22 2023 12:00AM,Jul 13 2022 12:00AM",
      "30,Jack S.A.,Jack,67280206351541,May 25 2022 12:00AM,Feb 26 2022 12:00AM",
      "31,Catherine S.A.,Catherine,79049201220879,Aug 24 2023 12:00AM,Mar 29 2022 12:00AM",
      "32,Alea S.A.,Alea,14032331367599,Aug  4 2022 12:00AM,Dec  4 2022 12:00AM",
      "33,Chase S.A.,Chase,94326914511468,Oct  4 2022 12:00AM,Jan 14 2023 12:00AM",
      "34,Mari S.A.,Mari,86401963962658,Dec 13 2022 12:00AM,Aug 11 2023 12:00AM",
      "35,Kirestin S.A.,Kirestin,64580065435681,May  3 2023 12:00AM,Jul 19 2022 12:00AM",
      "36,Margaret S.A.,Margaret,18090812404369,May  1 2023 12:00AM,Feb  2 2022 12:00AM",
      "37,Nissim S.A.,Nissim,25004920881420,Feb 17 2022 12:00AM,Oct 14 2023 12:00AM",
      "38,Macy S.A.,Macy,47196484665301,Oct 12 2022 12:00AM,Jun 13 2022 12:00AM",
      "39,Sarah S.A.,Sarah,64491291240954,Feb 28 2023 12:00AM,Oct 11 2022 12:00AM",
      "40,Addison S.A.,Addison,15806757925884,Mar 11 2022 12:00AM,Jul 20 2022 12:00AM",
      "41,Denton S.A.,Denton,74058475390607,Mar 25 2022 12:00AM,Aug 18 2022 12:00AM",
      "42,Bevis S.A.,Bevis,87675886860760,Apr 19 2023 12:00AM,Sep  6 2022 12:00AM",
      "43,Walter S.A.,Walter,91601845221466,Oct 24 2023 12:00AM,Nov 27 2021 12:00AM",
      "44,Anthony S.A.,Anthony,3199839720471,Jan 26 2023 12:00AM,May 21 2022 12:00AM",
      "45,Ferdinand S.A.,Ferdinand,94377792773999,Sep 30 2023 12:00AM,May 19 2023 12:00AM",
      "46,Hilary S.A.,Hilary,26492878537148,Jan  3 2022 12:00AM,Aug  7 2023 12:00AM",
      "47,Caleb S.A.,Caleb,49224898791987,Jan  8 2023 12:00AM,Feb  2 2023 12:00AM",
      "48,Wanda S.A.,Wanda,44205371150048,Jun 14 2023 12:00AM,Dec 24 2021 12:00AM",
      "49,Noelani S.A.,Noelani,37480203102569,Sep  3 2023 12:00AM,Nov 13 2022 12:00AM",
      "50,Vivien S.A.,Vivien,81330585429839,Sep 16 2022 12:00AM,Oct 10 2022 12:00AM",
      "51,Irene S.A.,Irene,3919488462114,Oct 11 2022 12:00AM,Feb 17 2022 12:00AM",
      "52,Dacey S.A.,Dacey,22090457505189,Nov 24 2022 12:00AM,Jan  7 2022 12:00AM",
      "53,Carlos S.A.,Carlos,35742371204396,Apr  4 2023 12:00AM,Aug 12 2022 12:00AM",
      "54,Colt S.A.,Colt,57259153648970,Mar 22 2022 12:00AM,Oct 19 2023 12:00AM",
      "55,Madaline S.A.,Madaline,26351470238400,Jul 17 2022 12:00AM,Jul  8 2022 12:00AM",
      "56,Amela S.A.,Amela,94334639637899,Apr  3 2022 12:00AM,Feb  7 2023 12:00AM",
      "57,Nathan S.A.,Nathan,8700986406719,Mar  6 2022 12:00AM,Jan 13 2022 12:00AM",
      "58,Noelle S.A.,Noelle,45790214184672,Jun 22 2022 12:00AM,Feb  3 2022 12:00AM",
      "59,Aristotle S.A.,Aristotle,19841758241110,Oct 31 2022 12:00AM,Sep 23 2023 12:00AM",
      "60,Rafael S.A.,Rafael,65566872068240,Feb 22 2022 12:00AM,Apr 14 2022 12:00AM",
      "61,Craig S.A.,Craig,7440072582039,Nov 10 2023 12:00AM,Feb 24 2022 12:00AM",
      "62,Jolie S.A.,Jolie,73330796482379,Aug 25 2023 12:00AM,May 13 2022 12:00AM",
      "63,Ivor S.A.,Ivor,59544827829613,Nov  8 2023 12:00AM,Sep 17 2022 12:00AM",
      "64,Linda S.A.,Linda,60576912424381,May 16 2022 12:00AM,Nov  9 2022 12:00AM",
      "65,Walter S.A.,Walter,93499039928529,Jul 21 2023 12:00AM,Apr  2 2023 12:00AM",
      "66,Frances S.A.,Frances,47202593981280,Feb 16 2022 12:00AM,Nov  2 2023 12:00AM",
      "67,Quinlan S.A.,Quinlan,33661148027993,Jul 30 2022 12:00AM,Jun 13 2023 12:00AM",
      "68,Stone S.A.,Stone,51844259084130,Mar 17 2023 12:00AM,Aug 15 2022 12:00AM",
      "69,Lillith S.A.,Lillith,91091361439117,Sep  6 2023 12:00AM,Nov 24 2021 12:00AM",
      "70,Salvador S.A.,Salvador,68103584824972,Sep 24 2023 12:00AM,Nov 28 2021 12:00AM",
      "71,Travis S.A.,Travis,57179484750845,Sep  5 2022 12:00AM,Aug 16 2022 12:00AM",
      "72,Flavia S.A.,Flavia,6551840016020,Aug 26 2022 12:00AM,May 26 2023 12:00AM",
      "73,Imani S.A.,Imani,63082362890620,Apr 22 2023 12:00AM,Jun  9 2023 12:00AM",
      "74,Rebecca S.A.,Rebecca,34130893966384,Jun  5 2023 12:00AM,Nov 26 2021 12:00AM",
      "75,Baxter S.A.,Baxter,15130303085264,Mar 12 2022 12:00AM,Nov  9 2022 12:00AM",
      "76,Lillith S.A.,Lillith,56749855010345,Dec 23 2022 12:00AM,Sep 19 2022 12:00AM",
      "77,Arden S.A.,Arden,30839395199815,Sep 18 2022 12:00AM,Mar 14 2022 12:00AM",
      "78,Bethany S.A.,Bethany,62356939916051,Jul 19 2023 12:00AM,Nov 17 2023 12:00AM",
      "79,Luke S.A.,Luke,93329289543357,Mar 18 2023 12:00AM,Jan 12 2022 12:00AM",
      "80,Carly S.A.,Carly,75902208080704,Nov 18 2023 12:00AM,Feb 28 2022 12:00AM",
      "81,Raymond S.A.,Raymond,53846927242196,Aug 29 2023 12:00AM,Dec 19 2021 12:00AM",
      "82,Rhoda S.A.,Rhoda,44429984417341,Dec 14 2022 12:00AM,Mar 26 2022 12:00AM",
      "83,Jesse S.A.,Jesse,51271301282015,May 28 2023 12:00AM,Jun 28 2023 12:00AM",
      "84,Abra S.A.,Abra,18354545347420,Jun  9 2022 12:00AM,Jun 29 2023 12:00AM",
      "85,Uma S.A.,Uma,61976387495351,Jan 29 2023 12:00AM,Mar  6 2022 12:00AM",
      "86,Isabelle S.A.,Isabelle,40018365818510,Nov 26 2021 12:00AM,Jan 24 2022 12:00AM",
      "87,Merritt S.A.,Merritt,81197931944765,Apr  4 2022 12:00AM,Oct  7 2022 12:00AM",
      "88,Amery S.A.,Amery,12795633516797,Mar 20 2022 12:00AM,Jul 23 2023 12:00AM",
      "89,Howard S.A.,Howard,81082047547856,Nov  7 2022 12:00AM,Feb 21 2023 12:00AM",
      "90,Nichole S.A.,Nichole,18320152243255,Mar 15 2023 12:00AM,Mar 20 2022 12:00AM",
      "91,Beck S.A.,Beck,36139556670194,May  7 2022 12:00AM,Oct 26 2022 12:00AM",
      "92,Myra S.A.,Myra,37126066415096,Jul 22 2022 12:00AM,Sep 13 2022 12:00AM",
      "93,Moses S.A.,Moses,55871862756377,Feb 21 2023 12:00AM,Mar 12 2023 12:00AM",
      "94,Neil S.A.,Neil,56227819619335,May 18 2023 12:00AM,Feb 28 2022 12:00AM",
      "95,Amery S.A.,Amery,73279556416881,Jul 29 2023 12:00AM,Jul  8 2023 12:00AM",
      "96,Idola S.A.,Idola,79361438716908,May 17 2022 12:00AM,Jan 13 2023 12:00AM",
      "97,Mercedes S.A.,Mercedes,86974724292994,Jul  9 2022 12:00AM,Jan 10 2022 12:00AM",
      "98,Colleen S.A.,Colleen,59479886935373,Jul  2 2022 12:00AM,Feb 22 2023 12:00AM",
      "99,Reed S.A.,Reed,39178075020187,Aug 15 2023 12:00AM,Jun 29 2022 12:00AM",
      "100,Derek S.A.,Derek,73076263401207,Dec  9 2022 12:00AM,Jun 28 2022 12:00AM"
    };
    #endregion

    public static List<Cliente> ObterListaClientes()
    {
      DataTable dataTable = new DataTable();
      dataTable.Columns.Add("CodCliente");
      dataTable.Columns.Add("DescCliente");
      dataTable.Columns.Add("NmFantasia");
      dataTable.Columns.Add("CNPJ");
      dataTable.Columns.Add("DataCadastro");
      dataTable.Columns.Add("DataAtualizacao");

      foreach (var clienteString in listaClientesString)
      {
        var clienteArray = clienteString.Split(",");

        DataRow dataRow = dataTable.NewRow();
        dataRow["CodCliente"] = clienteArray[0];
        dataRow["DescCliente"] = clienteArray[1];
        dataRow["NmFantasia"] = clienteArray[2];
        dataRow["CNPJ"] = clienteArray[3];
        dataRow["DataCadastro"] = clienteArray[4];
        dataRow["DataAtualizacao"] = clienteArray[5];

        dataTable.Rows.Add(dataRow);
      }

      try
      {
        Cliente cliente;
        List<Cliente> clientes = new List<Cliente>();

        foreach (DataRow row in dataTable.Rows)
        {
          cliente = new Cliente();
          cliente.CodCliente = row ["CodCliente"].ToString();
          cliente.DescCliente = row["DescCliente"].ToString();
          cliente.NmFantasia = row["NmFantasia"].ToString();
          cliente.CNPJ = row["CNPJ"].ToString();
          cliente.DataCadastro = DateTime.Parse(row["DataCadastro"].ToString());
          cliente.DataAtualizacao = DateTime.Parse(row["DataAtualizacao"].ToString());
          clientes.Add(cliente);
        }

        return clientes;
      }
      catch (Exception ex)
      {
        throw new Exception($"Erro ao retornar lista de clientes: {ex.Message}");
      }
    }
  }
}
