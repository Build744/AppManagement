﻿namespace AppManagement.Application.Abstractions.Identity;

public record RegistrationRequest(
    string FirstName,
    string LastName,
    string Email,
    string UserName,
    string Password
);
