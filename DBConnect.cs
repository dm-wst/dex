SqlConnection con = new SqlConnection();
con.ConnectionString = @"Data Source=SERVER;Initial Catalog=DATABASE;User id=USER;Password=PASSWORD";
string     sql = "";
SqlCommand cmd = new SqlCommand(sql, con);

con.Open();
using (con)
{
	using (SqlDataReader dr = cmd.ExecuteReader())
	{
		if (dr.HasRows)
		{
			while (dr.Read())
			{
				//DoStuff
			}
		}
	}
}
