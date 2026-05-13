using BookStoreApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BookStoreApp.DAL
{
    public class BookDAL
    {
        private readonly string connectionString;

        public BookDAL(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // Get All Books using SqlDataReader
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Books";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book();

                    book.Id = Convert.ToInt32(reader["Id"]);
                    book.Title = reader["Title"].ToString();
                    book.Author = reader["Author"].ToString();
                    book.Price = Convert.ToDecimal(reader["Price"]);
                    book.Quantity = Convert.ToInt32(reader["Quantity"]);

                    books.Add(book);
                }

                con.Close();
            }

            return books;
        }

        // Add Book using Stored Procedure
        public void AddBook(Book book)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_AddBook", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Price", book.Price);
                cmd.Parameters.AddWithValue("@Quantity", book.Quantity);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
            }
        }

        // Get Book By Id
        public Book GetBookById(int id)
        {
            Book book = new Book();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Books WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    book.Id = Convert.ToInt32(reader["Id"]);
                    book.Title = reader["Title"].ToString();
                    book.Author = reader["Author"].ToString();
                    book.Price = Convert.ToDecimal(reader["Price"]);
                    book.Quantity = Convert.ToInt32(reader["Quantity"]);
                }

                con.Close();
            }

            return book;
        }

        // Update Book using Stored Procedure
        public void UpdateBook(Book book)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateBook", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", book.Id);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Price", book.Price);
                cmd.Parameters.AddWithValue("@Quantity", book.Quantity);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
            }
        }

        // Delete Book using Stored Procedure
        public void DeleteBook(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteBook", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
            }
        }

        // DataSet and DataTable
        public DataSet GetBooksDataSet()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Books";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Books");

                return ds;
            }
        }
    }
}