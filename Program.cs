
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

class ProjetoForlogicSQL
{   

    
    static void Main()
    {
        Console.WriteLine("Buscando Conexao ...");
        string connString = @"Data Source=GAMER\SQLSAMPAIO;Initial Catalog=ProjetoForlogic;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connString); // CRIANDO A INSTANCIA DO BD
        

        try
        {
            
            string pergunta;
            do
            {
                Console.WriteLine("Selecione uma das opcoes\n1.Consultas\n2.Inserir\n3.Atualizar\n4.Deletar\n5.Log de registros");
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:

                        // Imprimi todos os Colaboradores Registrados
                        Console.WriteLine("Selecione uma das opcoes\n1.Tudo\n2.10 Ultimos\n3.Por nome\n4.Por data-inicial-final\n5.30 dias\n6.Totais");
                        int escolha2 = int.Parse(Console.ReadLine());
                        switch (escolha2)
                        {
                            case 1:
                                // Imprimi todos os Colaboradores Registrados
                                conn.Open();
                                Console.WriteLine("Banco Conectado com sucesso");
                                string consultaSQL = "SELECT * FROM Colaboradores";
                                SqlCommand display = new SqlCommand(consultaSQL, conn);
                                SqlDataReader dataReader = display.ExecuteReader();
                                while (dataReader.Read())
                                {
                                    Console.WriteLine("-----------------------------------------------------------");
                                    Console.WriteLine("ID_Colaborador......:" + dataReader.GetValue(0).ToString());
                                    Console.WriteLine("ID_User.............:" + dataReader.GetValue(1).ToString());
                                    Console.WriteLine("Nome................:" + dataReader.GetValue(2).ToString());
                                    Console.WriteLine("E-Mail..............:" + dataReader.GetValue(3).ToString());
                                    Console.WriteLine("Data de Nascimento..:" + dataReader.GetValue(4).ToString());
                                    Console.WriteLine("Endereco............:" + dataReader.GetValue(5).ToString());
                                    Console.WriteLine("Outros..............:" + dataReader.GetValue(6).ToString());
                                    Console.WriteLine("Interesses..........:" + dataReader.GetValue(7).ToString());
                                    Console.WriteLine("Sentimentos.........:" + dataReader.GetValue(8).ToString());
                                    Console.WriteLine("Valores.............:" + dataReader.GetValue(9).ToString());
                                    Console.WriteLine("Status..............:" + dataReader.GetValue(10).ToString());
                                    Console.WriteLine("Data do registro....:" + dataReader.GetValue(11).ToString());
                                    Console.WriteLine("-----------------------------------------------------------");
                                }

                                Console.WriteLine("Consulta efetuada com sucesso");
                                conn.Close();
                                break;
                            case 2:
                                //Consultar os 10 ultimos colaboradores cadastrados
                                conn.Open();
                                Console.WriteLine("Banco Conectado com sucesso");
                                string consultaSQL2 = "SELECT TOP 10 * FROM Colaboradores ORDER BY ID_col DESC";
                                SqlCommand display2 = new SqlCommand(consultaSQL2, conn);
                                SqlDataReader dataReader2 = display2.ExecuteReader();
                                while (dataReader2.Read())
                                {
                                    Console.WriteLine("-----------------------------------------------------------");
                                    Console.WriteLine("ID_Colaborador......:" + dataReader2.GetValue(0).ToString());
                                    Console.WriteLine("ID_User.............:" + dataReader2.GetValue(1).ToString());
                                    Console.WriteLine("Nome................:" + dataReader2.GetValue(2).ToString());
                                    Console.WriteLine("E-Mail..............:" + dataReader2.GetValue(3).ToString());
                                    Console.WriteLine("Data de Nascimento..:" + dataReader2.GetValue(4).ToString());
                                    Console.WriteLine("Endereco............:" + dataReader2.GetValue(5).ToString());
                                    Console.WriteLine("Outros..............:" + dataReader2.GetValue(6).ToString());
                                    Console.WriteLine("Interesses..........:" + dataReader2.GetValue(7).ToString());
                                    Console.WriteLine("Sentimentos.........:" + dataReader2.GetValue(8).ToString());
                                    Console.WriteLine("Valores.............:" + dataReader2.GetValue(9).ToString());
                                    Console.WriteLine("Status..............:" + dataReader2.GetValue(10).ToString());
                                    Console.WriteLine("Data do registro....:" + dataReader2.GetValue(11).ToString());
                                    Console.WriteLine("-----------------------------------------------------------");
                                }
                                Console.WriteLine("Consulta efetuada com sucesso");
                                conn.Close();
                                break;
                            case 3:
                                //Consultar colaborador pelo nome
                                conn.Open();
                                Console.WriteLine("Banco Conectado com sucesso");
                                Console.WriteLine("Digite o nome do colaborador que deseja buscar");
                                string nomeBusca = Console.ReadLine();
                                string consultaSQL3 = "SELECT * FROM Colaboradores WHERE nome = '" + nomeBusca + "'";
                                SqlCommand display3 = new SqlCommand(consultaSQL3, conn);
                                SqlDataReader dataReader3 = display3.ExecuteReader();
                                while (dataReader3.Read())
                                {
                                    Console.WriteLine("-----------------------------------------------------------");
                                    Console.WriteLine("ID_Colaborador......:" + dataReader3.GetValue(0).ToString());
                                    Console.WriteLine("ID_User.............:" + dataReader3.GetValue(1).ToString());
                                    Console.WriteLine("Nome................:" + dataReader3.GetValue(2).ToString());
                                    Console.WriteLine("E-Mail..............:" + dataReader3.GetValue(3).ToString());
                                    Console.WriteLine("Data de Nascimento..:" + dataReader3.GetValue(4).ToString());
                                    Console.WriteLine("Endereco............:" + dataReader3.GetValue(5).ToString());
                                    Console.WriteLine("Outros..............:" + dataReader3.GetValue(6).ToString());
                                    Console.WriteLine("Interesses..........:" + dataReader3.GetValue(7).ToString());
                                    Console.WriteLine("Sentimentos.........:" + dataReader3.GetValue(8).ToString());
                                    Console.WriteLine("Valores.............:" + dataReader3.GetValue(9).ToString());
                                    Console.WriteLine("Status..............:" + dataReader3.GetValue(10).ToString());
                                    Console.WriteLine("Data do registro....:" + dataReader3.GetValue(11).ToString());
                                    Console.WriteLine("-----------------------------------------------------------");
                                }
                                Console.WriteLine("Consulta efetuada com sucesso");
                                conn.Close();
                                break;
                            case 4:
                                //CONSULTANDO OS COLABORADORES POR DATA INICIAL E FINAL DE CADASTRO
                                conn.Open();
                                Console.WriteLine("Banco Conectado com sucesso");
                                string consultaSQL4 = "SELECT * FROM Colaboradores WHERE data_registro BETWEEN '11.20.2022' AND '11.21.2022'";
                                SqlCommand display4 = new SqlCommand(consultaSQL4, conn);
                                SqlDataReader dataReader4 = display4.ExecuteReader();
                                while (dataReader4.Read())
                                {
                                    Console.WriteLine("-----------------------------------------------------------");
                                    Console.WriteLine("ID_Colaborador......:" + dataReader4.GetValue(0).ToString());
                                    Console.WriteLine("ID_User.............:" + dataReader4.GetValue(1).ToString());
                                    Console.WriteLine("Nome................:" + dataReader4.GetValue(2).ToString());
                                    Console.WriteLine("E-Mail..............:" + dataReader4.GetValue(3).ToString());
                                    Console.WriteLine("Data de Nascimento..:" + dataReader4.GetValue(4).ToString());
                                    Console.WriteLine("Endereco............:" + dataReader4.GetValue(5).ToString());
                                    Console.WriteLine("Outros..............:" + dataReader4.GetValue(6).ToString());
                                    Console.WriteLine("Interesses..........:" + dataReader4.GetValue(7).ToString());
                                    Console.WriteLine("Sentimentos.........:" + dataReader4.GetValue(8).ToString());
                                    Console.WriteLine("Valores.............:" + dataReader4.GetValue(9).ToString());
                                    Console.WriteLine("Status..............:" + dataReader4.GetValue(10).ToString());
                                    Console.WriteLine("Data do registro....:" + dataReader4.GetValue(11).ToString());
                                    Console.WriteLine("-----------------------------------------------------------");
                                }
                                Console.WriteLine("Consulta efetuada com sucesso");
                                conn.Close();
                                break;
                            case 5:
                                //CONSULTANDO O TOTAL DE COLABORADORES CADASTRADOS NOS ULTIMOS 30 DIAS
                                conn.Open();
                                Console.WriteLine("Banco Conectado com sucesso");
                                string consultaSQL5 = "SELECT COUNT(*) AS Total_cadastrados FROM Colaboradores WHERE CAST(data_registro AS DATE) BETWEEN CAST(DATEADD (DAY,-30, GETDATE()) AS DATE) AND CAST (GETDATE() AS DATE";
                                SqlCommand display5 = new SqlCommand(consultaSQL5, conn);
                                SqlDataReader dataReader5 = display5.ExecuteReader();
                                while (dataReader5.Read())
                                {
                                    Console.WriteLine("-----------------------------------------------------------");
                                    Console.WriteLine("Total de colaboradores cadastrados nos ultimos 30 dias......:" + dataReader5.GetValue(0).ToString());
                                    
                                    Console.WriteLine("-----------------------------------------------------------");
                                }
                                Console.WriteLine("Consulta efetuada com sucesso");
                                conn.Close();
                                break;
                            case 6:
                                //CONSULTANDO O TOTAL DE COLABORADORES CADASTRADOS
                                conn.Open();
                                Console.WriteLine("Banco Conectado com sucesso");
                                string consultaSQL6 = "SELECT COUNT(*) AS Total_cadastrados FROM Colaboradores";
                                SqlCommand display6 = new SqlCommand(consultaSQL6, conn);
                                SqlDataReader dataReader6 = display6.ExecuteReader();
                                while (dataReader6.Read())
                                {
                                    Console.WriteLine("-----------------------------------------------------------");
                                    Console.WriteLine("Total de colaboradores cadastrados......:" + dataReader6.GetValue(0).ToString());
                                    
                                    Console.WriteLine("-----------------------------------------------------------");
                                }
                                Console.WriteLine("Consulta efetuada com sucesso");
                                conn.Close();
                                break;
                            default:
                                Console.WriteLine("Entre com uma escolha valida");
                                break;


                        }
                                break;

                        
                        

                    case 2:

                        // Adicionando nome colaborador
                        conn.Open();
                        Console.WriteLine("Banco Conectado com sucesso");
                        Console.WriteLine("ID do ADM");
                        string id_user = Console.ReadLine();

                        Console.WriteLine("Nome");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Email");
                        string email = Console.ReadLine();

                        Console.WriteLine("Data Nascimento");
                        string data_nasc = Console.ReadLine();

                        Console.WriteLine("Endereco");
                        string endereco = Console.ReadLine();

                        /*  Console.WriteLine("Outras");
                          string outras = Console.ReadLine();

                          Console.WriteLine("Interesses");
                          string interesses = Console.ReadLine();

                          Console.WriteLine("Sentimentos");
                          string sentimentos = Console.ReadLine();

                          Console.WriteLine("Valores");
                          string valores = Console.ReadLine();
                        */
                        Console.WriteLine("Status");
                        string status = Console.ReadLine();

                        string incluiSQL = @"INSERT INTO Colaboradores (ID_user, nome, email, data_nasc, endereco, status, data_registro) VALUES ('" + id_user + "','" + nome + "', '" + email + "','" + data_nasc + "','" + endereco + "','" + status + "', GETDATE())";
                        SqlCommand insert = new SqlCommand(incluiSQL, conn);
                        insert.ExecuteNonQuery();
                        Console.WriteLine("Colaborador cadastrado com sucesso ...");
                        conn.Close();

                        break;
                    case 3:

                        // Atualizando nome do Colaborador pelo ID 
                        conn.Open();
                        Console.WriteLine("Banco Conectado com sucesso");
                        Console.WriteLine("Banco Conectado com sucesso");
                        Console.WriteLine("Digite o ID do colaborador que deseja alterar");
                        string idUpdate = Console.ReadLine();
                        Console.WriteLine("Digite o campo que deseja alterar");
                        string campoUpdate = Console.ReadLine();
                        Console.WriteLine("Digite o novo campo");
                        string mudancaUpdate = Console.ReadLine();
                        string atualizaSQL = @"update Colaboradores set " + campoUpdate + " = '" + mudancaUpdate + "'  where ID_col = " + idUpdate + "";
                        SqlCommand uptdate = new SqlCommand(atualizaSQL, conn);
                        uptdate.ExecuteNonQuery();
                        Console.WriteLine("Colaborador atualizado com sucesso ...");
                        conn.Close();

                        break;
                    case 4:
                        // Excluindo colaborador pelo ID
                        conn.Open();
                        Console.WriteLine("Banco Conectado com sucesso");
                        Console.WriteLine("Digite o ID do colaborador que deseja excluir");
                        string idDelete = Console.ReadLine();
                        string idDeleteCon = idDelete;
                        Convert.ToInt32(idDeleteCon);
                        string excluiSQL = @"delete from Colaboradores where "+ idDeleteCon + "";
                        SqlCommand delete = new SqlCommand(excluiSQL, conn);
                        delete.CommandText = excluiSQL;
                        delete.ExecuteNonQuery();
                        Console.WriteLine("Colaborador deletado com sucesso ...");
                        conn.Close();

                        break;  
                    case 5:
                        //CONSULTANDO O LOG DE REGISTROS
                        conn.Open();
                        Console.WriteLine("Banco Conectado com sucesso");
                        string consultaSQL7 = "SELECT * FROM Historico";
                        SqlCommand display7 = new SqlCommand(consultaSQL7, conn);
                        SqlDataReader dataReader7 = display7.ExecuteReader();
                        while (dataReader7.Read())
                        {
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.WriteLine("ID................:" + dataReader7.GetValue(0).ToString());
                            Console.WriteLine("Data da Operacao..:" + dataReader7.GetValue(1).ToString());
                            Console.WriteLine("Tipo de Operacao..:" + dataReader7.GetValue(2).ToString());
                            Console.WriteLine("ID_user...........:" + dataReader7.GetValue(3).ToString());
                            Console.WriteLine("ID_col............:" + dataReader7.GetValue(4).ToString());
                            Console.WriteLine("nome..............:" + dataReader7.GetValue(5).ToString());
                            
                            Console.WriteLine("-----------------------------------------------------------");
                        }
                        Console.WriteLine("Consulta efetuada com sucesso");
                        conn.Close();
                        break;


                    default:
                        Console.WriteLine("Entre com uma escolha valida");
                        break;

                }
                Console.WriteLine("Voce quer continuar? Tecla qualquer tecla para continuar, ou Digite: Nao para sair");
                pergunta = Console.ReadLine();
            } while (pergunta != "Nao");
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
    }
}