﻿using Microsoft.AspNetCore.Identity.UI.Services;

namespace BulkyWeb.Utility
{
    public class EmailSender:IEmailSender
    {
        public Task SendEmailAsync (string email,string subject,string htmlMessege)
        {
            return Task.CompletedTask;
        }
    }
}
