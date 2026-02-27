using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace API.DTOs;

public class LoginDto
{
    public string Email { get; set; }
    public string Password {get; set;}
}
