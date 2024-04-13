
using System.Data;
using System.Data.SqlClient;
using TSMNDotNetCore.ConsoleApp;

Console.WriteLine("Hello, World!");

//SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
//stringBuilder.DataSource = "DESKTOP-LEMEQ9U";// server name
//stringBuilder.InitialCatalog = "TSMNDotNetCore";  //database
//stringBuilder.UserID = "sa";
//stringBuilder.Password = "sa@123";
//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
//connection.Open();
//Console.WriteLine("Connection Open.");

//string query = "select * from tbl_blog";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();//after select * from tablename show result with table
//sqlDataAdapter.Fill(dt);


//connection.Close();
//Console.WriteLine("Connection Close");

//dataset=>datatable
//datable=>datarow
//datarow=>datacolum

//foreach (DataRow dr in dt.Rows)
//{
//Console.WriteLine("Blog Id=>" + dr["BlogId"]);
//Console.WriteLine("Blog Title=>" + dr["BlogTitle"]);
//.WriteLine("Blog Author=>" + dr["BlogAuthor"]);
//Console.WriteLine("Blog Content=>" + dr["BlogContent"]);
//.WriteLine("----------------------------------");
//
AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");
//adoDotNetExample.Update(18, "test title", "test author", "test content");
//adoDotNetExample.Delete(18);
adoDotNetExample.Edit(18);
adoDotNetExample.Edit(1);
//Console.ReadKey();