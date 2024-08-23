using DataAccess.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace DataAccess
{
    public class clsDataAccess
    {
        // CRUD Option
        public static bool CreateOption(Option option)
        {
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            INSERT INTO options (
                                name,
                                phone,
                                email,
                                address,
                                logo,
                                receipt_line_1,
                                receipt_line_2,
                                printer
                            ) VALUES (
                                @name,
                                @phone,
                                @email,
                                @address,
                                @logo,
                                @receipt_line_1,
                                @receipt_line_2,
                                @printer,
                            );
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@name", option.Name);
            command.Parameters.AddWithValue("@phone", option.Phone);
            command.Parameters.AddWithValue("@email", option.Email);
            command.Parameters.AddWithValue("@address", option.Address);
            command.Parameters.AddWithValue("@logo", clsImageByte.ImageToByte(option.Logo));
            command.Parameters.AddWithValue("@receipt_line_1", option.ReceiptLine1);
            command.Parameters.AddWithValue("@receipt_line_2", option.ReceiptLine2);

            if (string.IsNullOrWhiteSpace(option.Printer))
                command.Parameters.AddWithValue("@printer", DBNull.Value);
            else
                command.Parameters.AddWithValue("@printer", option.Printer);

            bool isCreated = false;
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isCreated = rowsAffected > 0;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isCreated;
        }

        public static Option ReadOption(int optionID)
        {
            Option option = new Option();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT * FROM options WHERE id = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", optionID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    option.ID = Convert.ToInt32(reader["id"]);
                    option.Name = reader["name"].ToString();
                    option.Phone = reader["phone"].ToString();
                    option.Email = reader["email"].ToString();
                    option.Address = reader["address"].ToString();
                    option.Logo = clsImageByte.ByteToImage((byte[])reader["logo"]);
                    option.ReceiptLine1 = reader["receipt_line_1"].ToString();
                    option.ReceiptLine2 = reader["receipt_line_2"].ToString();
                    option.Printer = reader["printer"].ToString();

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return option;
        }

        public static bool UpdateOption(Option option)
        {
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            UPDATE options SET
                                name = @name,
                                phone = @phone,
                                email = @email,
                                address = @address,
                                logo = @logo,
                                receipt_line_1 = @receipt_line_1,
                                receipt_line_2 = @receipt_line_2,
                                printer = @printer
                            WHERE
                                id = @id;
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@name", option.Name);
            command.Parameters.AddWithValue("@phone", option.Phone);
            command.Parameters.AddWithValue("@email", option.Email);
            command.Parameters.AddWithValue("@address", option.Address);
            command.Parameters.AddWithValue("@logo", clsImageByte.ImageToByte(option.Logo));
            command.Parameters.AddWithValue("@receipt_line_1", option.ReceiptLine1);
            command.Parameters.AddWithValue("@receipt_line_2", option.ReceiptLine2);

            if (string.IsNullOrWhiteSpace(option.Printer))
                command.Parameters.AddWithValue("@printer", DBNull.Value);
            else
                command.Parameters.AddWithValue("@printer", option.Printer);

            command.Parameters.AddWithValue("@id", option.ID);

            bool isUpdated = false;
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isUpdated = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isUpdated;
        }

        // CRUD User
        public static bool CreateUser(User user)
        {
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            INSERT INTO users (
                                username,
                                password,
                                email,
                                phone,
                                address,
                                job_title,
                                salary,
                                personal_picture,
                                permission
                            ) VALUES (
                                @username,
                                @password,
                                @email,
                                @phone,
                                @address,
                                @job_title,
                                @salary,
                                @personal_picture,
                                @permission
                            );
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@phone", user.Phone);
            command.Parameters.AddWithValue("@address", user.Address);
            command.Parameters.AddWithValue("@job_title", user.JobTitle);

            if (user.Salary == 0)
                command.Parameters.AddWithValue("@salary", DBNull.Value);
            else
                command.Parameters.AddWithValue("@salary", user.Salary);

            command.Parameters.AddWithValue("@personal_picture", 
                clsImageByte.ImageToByte(user.PersonalPicture));

            command.Parameters.AddWithValue("@permission", user.Permission);

            bool isCreated = false;
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isCreated = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isCreated;
        }

        public static User ReadUser(int userID)
        {
            User user = new User();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT * FROM users WHERE id = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", userID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user.ID = Convert.ToInt32(reader["id"]);
                    user.Username = reader["username"].ToString();
                    user.Password = reader["password"].ToString();
                    user.Email = reader["email"].ToString();
                    user.Phone = reader["phone"].ToString();
                    user.Address = reader["address"].ToString();
                    user.JobTitle = reader["job_title"].ToString();

                    if (reader["salary"] == DBNull.Value)
                        user.Salary = Convert.ToDecimal("0");
                    else
                        user.Salary = Convert.ToDecimal(reader["salary"]);

                    user.PersonalPicture = clsImageByte.ByteToImage((byte[])reader["personal_picture"]);
                    user.Permission = Convert.ToInt32(reader["permission"]);

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return user;
        }
        public static User ReadUser(string username)
        {
            User user = new User();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT * FROM users WHERE username = @username;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user.ID = Convert.ToInt32(reader["id"]);
                    user.Username = reader["username"].ToString();
                    user.Password = reader["password"].ToString();
                    user.Email = reader["email"].ToString();
                    user.Phone = reader["phone"].ToString();
                    user.Address = reader["address"].ToString();
                    user.JobTitle = reader["job_title"].ToString();

                    if (reader["salary"] == DBNull.Value)
                        user.Salary = Convert.ToDecimal("0");
                    else
                        user.Salary = Convert.ToDecimal(reader["salary"]);

                    user.PersonalPicture = clsImageByte.ByteToImage((byte[])reader["personal_picture"]);
                    user.Permission = Convert.ToInt32(reader["permission"]);

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return user;
        }
        public static User GetLastUser()
        {
            User user = new User();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT TOP 1 * FROM users ORDER BY id DESC;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user.ID = Convert.ToInt32(reader["id"]);
                    user.Username = reader["username"].ToString();
                    user.Password = reader["password"].ToString();
                    user.Email = reader["email"].ToString();
                    user.Phone = reader["phone"].ToString();
                    user.Address = reader["address"].ToString();
                    user.JobTitle = reader["job_title"].ToString();

                    if (reader["salary"] == DBNull.Value)
                        user.Salary = Convert.ToDecimal("0");
                    else
                        user.Salary = Convert.ToDecimal(reader["salary"]);

                    user.PersonalPicture = clsImageByte.ByteToImage((byte[])reader["personal_picture"]);
                    user.Permission = Convert.ToInt32(reader["permission"]);

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return user;
        }
        public static DataTable GetUsersDataTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            SELECT 
                                id AS ID,
                                username AS Username,
                                password AS Password,
                                email AS Email,
                                phone AS Phone,
                                address AS Address,
                                job_title AS ""Job Title"",
                                salary AS Salary
                            FROM 
                                users
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }
        public static bool IsUserExist(string username, string password)
        {
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                connection.Open();
                int userCount = (int)command.ExecuteScalar();
                return userCount > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateUser(User user)
        {
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            UPDATE users SET
                                username = @username,
                                password = @password,
                                email = @email,
                                phone = @phone,
                                address = @address,
                                job_title = @job_title,
                                salary = @salary,
                                personal_picture = @personal_picture,
                                permission = @permission
                            WHERE
                                id = @id;
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@phone", user.Phone);
            command.Parameters.AddWithValue("@address", user.Address);
            command.Parameters.AddWithValue("@job_title", user.JobTitle);

            if (user.Salary == 0)
                command.Parameters.AddWithValue("@salary", DBNull.Value);
            else
                command.Parameters.AddWithValue("@salary", user.Salary);

            command.Parameters.AddWithValue("@personal_picture",
                clsImageByte.ImageToByte(user.PersonalPicture));

            command.Parameters.AddWithValue("@permission", user.Permission);

            command.Parameters.AddWithValue("@id", user.ID);

            bool isUpdated = false;
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isUpdated = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isUpdated;
        }

        // CRUD Category
        public static bool CreateCategory(Category category)
        {
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            INSERT INTO categories (
                                name,
                                img
                            ) VALUES (
                                @name,
                                @img
                            );
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@name", category.Name);
            command.Parameters.AddWithValue("@img", clsImageByte.ImageToByte(category.Img));

            bool isCreated = false;
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isCreated = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isCreated;
        }

        public static Category ReadCategory(int categoryID)
        {
            Category category = new Category();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT * FROM categories WHERE id = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", categoryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    category.ID = Convert.ToInt32(reader["id"]);
                    category.Name = reader["name"].ToString();
                    category.Img = clsImageByte.ByteToImage((byte[])reader["img"]);

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return category;
        }
        public static Category ReadCategory(string categoryName)
        {
            Category category = new Category();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT * FROM categories WHERE name = @name;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", categoryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    category.ID = Convert.ToInt32(reader["id"]);
                    category.Name = reader["name"].ToString();
                    category.Img = clsImageByte.ByteToImage((byte[])reader["img"]);

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return category;
        }
        public static Category GetLastCategory()
        {
            Category category = new Category();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT TOP 1 * FROM categories ORDER BY id DESC;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    category.ID = Convert.ToInt32(reader["id"]);
                    category.Name = reader["name"].ToString();
                    category.Img = clsImageByte.ByteToImage((byte[])reader["img"]);

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return category;
        }
        public static List<Category> GetListOfCategories()
        {
            List<Category> listOfCategories = new List<Category>();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT * FROM categories;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Category category = new Category();

                    category.ID = Convert.ToInt32(reader["id"]);
                    category.Name = reader["name"].ToString();
                    category.Img = clsImageByte.ByteToImage((byte[])reader["img"]);

                    listOfCategories.Add(category);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return listOfCategories;
        }
        public static DataTable GetCategoriesDataTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            SELECT 
                                id AS ID,
                                name AS ""Category Name""
                            FROM 
                                categories
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }
        public static List<int> GetListOfCategoryIds()
        {
            List<int> ids = new List<int>();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT id FROM categories;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ids.Add(Convert.ToInt32(reader["id"]));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return ids;
        }
        public static List<string> GetListOfCategoryNames()
        {
            List<string> names = new List<string>();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT name FROM categories;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    names.Add(reader["name"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return names;
        }

        public static bool UpdateCategory(Category category)
        {
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            UPDATE categories SET
                                name = @name,
                                img = @img
                            WHERE
                                id = @id;
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@name", category.Name);
            command.Parameters.AddWithValue("@img", clsImageByte.ImageToByte(category.Img));

            command.Parameters.AddWithValue("@id", category.ID);

            bool isUpdated = false;
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isUpdated = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isUpdated;
        }

        // CRUD Items
        public static bool CreateItem(Item item)
        {
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            INSERT INTO items (
                                name,
                                description,
                                price,
                                img,
                                category_id
                            ) VALUES (
                                @name,
                                @description,
                                @price,
                                @img,
                                @category_id
                            );
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@description", item.Description);
            command.Parameters.AddWithValue("@price", item.Price);
            command.Parameters.AddWithValue("@img", clsImageByte.ImageToByte(item.Img));
            command.Parameters.AddWithValue("@category_id", item.Category.ID);

            bool isCreated = false;
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isCreated = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isCreated;
        }

        public static Item ReadItem(int itemID)
        {
            Item item = new Item();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT * FROM items WHERE id = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", itemID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    item.ID = Convert.ToInt32(reader["id"]);
                    item.Name = reader["name"].ToString();
                    item.Description = reader["description"].ToString();
                    item.Price = Convert.ToDecimal(reader["price"]);
                    item.Img = clsImageByte.ByteToImage((byte[])reader["img"]);
                    item.Category = ReadCategory(Convert.ToInt32(reader["category_id"]));

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return item;
        }
        public static Item GetLastItem()
        {
            Item item = new Item();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT TOP 1 * FROM items ORDER BY id DESC;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    item.ID = Convert.ToInt32(reader["id"]);
                    item.Name = reader["name"].ToString();
                    item.Description = reader["description"].ToString();
                    item.Price = Convert.ToDecimal(reader["price"]);
                    item.Img = clsImageByte.ByteToImage((byte[])reader["img"]);
                    item.Category = ReadCategory(Convert.ToInt32(reader["category_id"]));

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return item;
        }
        public static List<Item> GetListOfItems(int categoryID)
        {
            List<Item> items = new List<Item>();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT * FROM items WHERE category_id = @category_id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@category_id", categoryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Item item = new Item();

                    item.ID = Convert.ToInt32(reader["id"]);
                    item.Name = reader["name"].ToString();
                    item.Description = reader["description"].ToString();
                    item.Price = Convert.ToDecimal(reader["price"]);
                    item.Img = clsImageByte.ByteToImage(reader["img"]);
                    item.Category = ReadCategory(Convert.ToInt32(reader["category_id"]));

                    items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return items;
        }
        public static List<int> GetListOfItemIds()
        {
            List<int> ids = new List<int>();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT id FROM items;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ids.Add(Convert.ToInt32(reader["id"]));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return ids;
        }
        public static DataTable GetItemsDataTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            SELECT 
                                i.id AS ID,
                                i.name AS ""Item Name"",
                                i.description AS Description,
                                i.price AS Price,
                                c.name AS Category
                            FROM 
                                items i
                            INNER JOIN 
                                categories c
                            ON 
                                i.category_id = c.id 
                            ;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

        public static bool UpdateItem(Item item)
        {
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            UPDATE items SET
                                name = @name,
                                description = @description,
                                price = @price,
                                img = @img,
                                category_id = @category_id
                            WHERE
                                id = @id
                            ;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@description", item.Description);
            command.Parameters.AddWithValue("@price", item.Price);
            command.Parameters.AddWithValue("@img", clsImageByte.ImageToByte(item.Img));
            command.Parameters.AddWithValue("@category_id", item.Category.ID);

            command.Parameters.AddWithValue("@id", item.ID);

            bool isUpdated = false;
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isUpdated = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isUpdated;
        }

        // CRUD Payment Method
        public static PaymentMethod ReadPaymentMethod(int paymentMethodID)
        {
            PaymentMethod paymentMethod = new PaymentMethod();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT * FROM payment_methods WHERE id = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", paymentMethodID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    paymentMethod.ID = Convert.ToInt32(reader["id"]);
                    paymentMethod.Name = reader["name"].ToString();

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return paymentMethod;
        }
        public static PaymentMethod ReadPaymentMethod(string paymentMethodName)
        {
            PaymentMethod paymentMethod = new PaymentMethod();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT * FROM payment_methods WHERE name = @name;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", paymentMethodName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    paymentMethod.ID = Convert.ToInt32(reader["id"]);
                    paymentMethod.Name = reader["name"].ToString();

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return paymentMethod;
        }
        public static List<string> GetListOfPaymentMethodNames()
        {
            List<string> names = new List<string>();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT name FROM payment_methods;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    names.Add(reader["name"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return names;
        }

        // CRUD Payment Status
        public static PaymentStatus ReadPaymentStatus(int paymentStatusID)
        {
            PaymentStatus paymentStatus = new PaymentStatus();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT * FROM payment_statuses WHERE id = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", paymentStatusID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    paymentStatus.ID = Convert.ToInt32(reader["id"]);
                    paymentStatus.Name = reader["name"].ToString();

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return paymentStatus;
        }
        public static PaymentStatus ReadPaymentStatus(string paymentStatusName)
        {
            PaymentStatus paymentStatus = new PaymentStatus();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT * FROM payment_statuses WHERE name = @name;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", paymentStatusName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    paymentStatus.ID = Convert.ToInt32(reader["id"]);
                    paymentStatus.Name = reader["name"].ToString();

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return paymentStatus;
        }
        public static List<string> GetListOfPaymentStatusNames()
        {
            List<string> names = new List<string>();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT name FROM payment_statuses;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    names.Add(reader["name"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return names;
        }

        // CRUD Payment
        public static bool CreatePayment(Payment payment)
        {
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            INSERT INTO payments (
                                method_id,
                                date_and_time,
                                amount_to_be_paid,
                                paid_cash,
                                change,
                                status_id
                            ) VALUES (
                                @method_id,
                                @date_and_time,
                                @amount_to_be_paid,
                                @paid_cash,
                                @change,
                                @status_id
                            );
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@method_id", payment.Method.ID);
            command.Parameters.AddWithValue("@date_and_time", payment.DateAndTime);
            command.Parameters.AddWithValue("@amount_to_be_paid", payment.AmountToBePaid);
            
            if (payment.PaidCash == 0)
            {
                command.Parameters.AddWithValue("@paid_cash", DBNull.Value);
                command.Parameters.AddWithValue("@change", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@paid_cash", payment.PaidCash);
                command.Parameters.AddWithValue("@change", payment.Change);
            }

            command.Parameters.AddWithValue("@status_id", payment.Status.ID);

            bool isCreated = false;
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isCreated = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isCreated;
        }

        public static Payment ReadPayment(int paymentID)
        {
            Payment payment = new Payment();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT * FROM payments WHERE id = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", paymentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    payment.ID = Convert.ToInt32(reader["id"]);
                    payment.Method = ReadPaymentMethod(Convert.ToInt32(reader["method_id"]));
                    payment.DateAndTime = Convert.ToDateTime(reader["date_and_time"]);
                    payment.AmountToBePaid = Convert.ToDecimal(reader["amount_to_be_paid"]);

                    if (reader["paid_cash"] == DBNull.Value)
                    {
                        payment.PaidCash = 0;
                        payment.Change = 0;
                    }
                    else
                    {
                        payment.PaidCash = Convert.ToDecimal(reader["paid_cash"]);
                        payment.Change = Convert.ToDecimal(reader["change"]);
                    }

                    payment.Status = ReadPaymentStatus(Convert.ToInt32(reader["status_id"]));

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return payment;
        }
        public static Payment GetLastPayment()
        {
            Payment payment = new Payment();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT TOP 1 * FROM payments ORDER BY id DESC;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    payment.ID = Convert.ToInt32(reader["id"]);
                    payment.Method = ReadPaymentMethod(Convert.ToInt32(reader["method_id"]));
                    payment.DateAndTime = Convert.ToDateTime(reader["date_and_time"]);
                    payment.AmountToBePaid = Convert.ToDecimal(reader["amount_to_be_paid"]);

                    if (reader["paid_cash"] == DBNull.Value)
                    {
                        payment.PaidCash = 0;
                        payment.Change = 0;
                    }
                    else
                    {
                        payment.PaidCash = Convert.ToDecimal(reader["paid_cash"]);
                        payment.Change = Convert.ToDecimal(reader["change"]);
                    }

                    payment.Status = ReadPaymentStatus(Convert.ToInt32(reader["status_id"]));

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return payment;
        }
        public static DataTable GetPaymentsDataTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            SELECT 
                                p.id AS ID,
                                m.name AS Method,
                                p.date_and_time AS ""Date And Time"",
                                p.amount_to_be_paid AS Amount,
                                p.paid_cash AS Paid,
                                p.change AS Change,
                                s.name AS Status
                            FROM 
                                payments p
                            INNER JOIN 
                                payment_methods m
                            ON 
                                p.method_id = m.id
                            INNER JOIN 
                                payment_statuses s
                            ON 
                                p.status_id = s.id
                            ;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }
        public static List<int> GetListOfPaymentIDs()
        {
            List<int> ids = new List<int>();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT id FROM payments;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ids.Add(Convert.ToInt32(reader["id"]));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return ids;
        }

        public static bool UpdatePayment(Payment payment)
        {
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            UPDATE payments SET
                                method_id = @method_id,
                                date_and_time = @date_and_time,
                                amount_to_be_paid = @amount_to_be_paid,
                                paid_cash = @paid_cash,
                                change = @change,
                                status_id = @status_id
                            WHERE
                                id = @id
                            ;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@method_id", payment.Method.ID);
            command.Parameters.AddWithValue("@date_and_time", payment.DateAndTime);
            command.Parameters.AddWithValue("@amount_to_be_paid", payment.AmountToBePaid);

            if (payment.PaidCash == 0)
            {
                command.Parameters.AddWithValue("@paid_cash", DBNull.Value);
                command.Parameters.AddWithValue("@change", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@paid_cash", payment.PaidCash);
                command.Parameters.AddWithValue("@change", payment.Change);
            }

            command.Parameters.AddWithValue("@status_id", payment.Status.ID);

            command.Parameters.AddWithValue("@id", payment.ID);

            bool isUpdated = false;
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isUpdated = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isUpdated;
        }

        // CRUD Payment Item
        public static bool CreatePaymentItem(PaymentItem paymentItem)
        {
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"
                            INSERT INTO payment_items (
                                payment_id,
                                user_id,
                                item_id,
                                qty,
                                price
                            ) VALUES (
                                @payment_id,
                                @user_id,
                                @item_id,
                                @qty,
                                @price
                            );
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@payment_id", GetLastPayment().ID);
            command.Parameters.AddWithValue("@user_id", paymentItem.User.ID);
            command.Parameters.AddWithValue("@item_id", paymentItem.Item.ID);
            command.Parameters.AddWithValue("@qty", paymentItem.Qty);
            command.Parameters.AddWithValue("@price", paymentItem.Price);

            bool isCreated = false;
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isCreated = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isCreated;
        }

        // CRUD Check
        public static DataTable GetCheckDataTable(int paymentID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string query = @"SELECT * FROM view_checks WHERE id = @id;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", paymentID);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }
        public static int GetLastCheckID()
        {
            int id = 0;
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);
            string query = "SELECT TOP 1 id FROM view_checks ORDER BY date_and_time DESC;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return id;
        }

        // CRUD Sales Report
        public static DataTable GetSalesReportDataTableBetweenFromAndTo(DateTime from, DateTime to)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string sFrom = from.ToString("yyyy-MM-dd");
            string sTo = to.ToString("yyyy-MM-dd");
            
            string query = @"
                            SELECT * FROM view_sales_report 
                            WHERE date_and_time BETWEEN @sFrom AND @sTo;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@sFrom", sFrom);
            command.Parameters.AddWithValue("@sTo", sTo);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

        // CRUD Sales Report Detailed
        public static DataTable GetSalesReportDetailedDataTableBetweenFromAndTo(DateTime from, DateTime to)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionParameters.connectionString);

            string sFrom = from.ToString("yyyy-MM-dd");
            string sTo = to.ToString("yyyy-MM-dd");

            string query = @"
                            SELECT * FROM view_sales_report_detailed 
                            WHERE date_and_time BETWEEN @sFrom AND @sTo;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@sFrom", sFrom);
            command.Parameters.AddWithValue("@sTo", sTo);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }
    }
}
