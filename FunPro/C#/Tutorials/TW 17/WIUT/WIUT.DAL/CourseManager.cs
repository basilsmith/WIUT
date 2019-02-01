using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;

namespace WIUT.DAL
{
    public class CourseManager : DbManager
    {
        public void Create(Course c)
        {
            var connection = Connection;
            try
            {
                var sql = $"INSERT INTO Course (Name) VALUES ('{c.Name}')";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }

        }

        public void Update(Course c)
        {
            var connection = Connection;
            try
            {
                var sql = $"UPDATE Course SET Name = '{c.Name}' WHERE Id = {c.Id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"DELETE FROM Course WHERE Id = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public Course GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"SELECT Id, Name FROM Course WHERE Id = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var c = new Course
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1))
                    };
                    return c;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }

            // if we are here - something went wrong
            return null;
        }

        public List<Course> GetAll()
        {
            var connection = Connection;
            var result = new List<Course>();
            try
            {
                var sql = "SELECT Id, Name FROM Course";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var c = new Course {Id = Convert.ToInt32(reader.GetValue(0)), Name = Convert.ToString(reader.GetValue(1))};
                    result.Add(c);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }

            return result;
        }
    }
}