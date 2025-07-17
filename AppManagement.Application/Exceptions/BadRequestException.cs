using System.ComponentModel.DataAnnotations;

namespace AppManagement.Application.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException(string message)
        : base(message) { }
}
