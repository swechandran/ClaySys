using Microsoft.AspNetCore.Mvc;
using System.Data;
using RegisterPage.Models;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Configuration;


[Route("api/[controller]")]
[ApiController]
public class RegisteredUsersController : ControllerBase
{
    private readonly string _connectionString;
    //private string ConnectionString;

    public RegisteredUsersController(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("myConnectionString");

        if (string.IsNullOrEmpty(_connectionString))
        {
            throw new InvalidOperationException("Connection string 'myConnectionString' is not configured.");
        }
    }
    //https://localhost:44317/api/RegisteredUsers/register
    [HttpPost("register")]
    public async Task<IActionResult> RegisterUser([FromBody] RegisterModel model)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();
            using (var command = new SqlCommand("dbo.SPI_RegisteredUsers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", model.UserID);
                command.Parameters.AddWithValue("@FirstName", model.FirstName);
                command.Parameters.AddWithValue("@LastName", model.LastName);
                command.Parameters.AddWithValue("@DateOfBirth", model.DateOfBirth);
                command.Parameters.AddWithValue("@Gender", model.Gender);
                command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                command.Parameters.AddWithValue("@EmailAddress", model.EmailAddress);
                command.Parameters.AddWithValue("@Address", model.Address);
                command.Parameters.AddWithValue("@Username", model.Username);
                command.Parameters.AddWithValue("@Password", model.Password);

                await command.ExecuteNonQueryAsync();
            }
        }
        return CreatedAtAction(nameof(GetUserById), new { id = model.Username }, model); 
    }

    //https://localhost:44317/api/RegisteredUsers/GetAllUsers
    [HttpGet]
    [Route("GetAllUsers")]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = new List<RegisterModel>();

        using (var connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();
            using (var command = new SqlCommand("SPR_GetAllRegisteredUsers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        users.Add(new RegisterModel
                        {
                            UserID = (int)reader["UserID"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                            Gender = (string)reader["Gender"],
                            PhoneNumber = (string)reader["PhoneNumber"],
                            EmailAddress = (string)reader["EmailAddress"],
                            Address = (string)reader["Address"],
                            Username = (string)reader["Username"],
                            Password = (string)reader["Password"],
                        });
                    }
                }
            }
        }
        return Ok(users);
    }

    //https://localhost:44317/api/RegisteredUsers/2
    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        RegisterModel? user = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();
            using (var command = new SqlCommand("SPR_GetRegisteredUsersbyId", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        user = new RegisterModel
                        {
                            UserID = (int)reader["UserID"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                            Gender = (string)reader["Gender"],
                            PhoneNumber = (string)reader["PhoneNumber"],
                            EmailAddress = (string)reader["EmailAddress"],
                            Address = (string)reader["Address"],
                            Username = (string)reader["Username"],
                            Password = (string)reader["Password"],
                        };
                    }
                }
            }
        }

        if (user == null)
            return NotFound();

        return Ok(user);
    }
    //https://localhost:44317/api/RegisteredUsers/EditUser/4
    [HttpPut("EditUser/{id}")]
    public async Task<IActionResult> EditUser(int id, [FromBody] RegisterModel model)
    {
        if (id != model.UserID)
        {
            return BadRequest("User ID mismatch.");
        }

        using (var connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();
            using (var command = new SqlCommand("SPU_EditRegisteredUsers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", model.UserID);
                command.Parameters.AddWithValue("@FirstName", model.FirstName);
                command.Parameters.AddWithValue("@LastName", model.LastName);
                command.Parameters.AddWithValue("@DateOfBirth", model.DateOfBirth);
                command.Parameters.AddWithValue("@Gender", model.Gender);
                command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                command.Parameters.AddWithValue("@EmailAddress", model.EmailAddress);
                command.Parameters.AddWithValue("@Address", model.Address);
                command.Parameters.AddWithValue("@Username", model.Username);
                command.Parameters.AddWithValue("@Password", model.Password);

                await command.ExecuteNonQueryAsync();
            }
        }
        return NoContent();
    }



//https://localhost:44317/api/RegisteredUsers/2
[HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();
            using (var command = new SqlCommand("SPD_DeleteRegisteredUsers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", id);
                await command.ExecuteNonQueryAsync();
            }
        }
        return NoContent();
    }
}
