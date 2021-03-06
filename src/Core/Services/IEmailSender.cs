﻿using System.Threading.Tasks;

namespace NoteIt.Core.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
