﻿namespace HighLoadDevelopment.Contracts.Requests
{
    public record ChangePasswordRequest(string OldPassword, string NewPassword);
}