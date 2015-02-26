﻿using System.Windows.Input;

namespace GitHub.ViewModels
{
    public interface ITwoFactorViewModel : IViewModel
    {
        ICommand OkCmd { get; }
        ICommand CancelCmd { get; }
        ICommand ShowHelpCmd { get; }
        ICommand ResendCodeCmd { get; }

        bool IsShowing { get; }
        bool IsSms { get; }
        bool IsAuthenticationCodeSent { get; }
        string Description { get; }
        string AuthenticationCode { get; set; }
    }
}