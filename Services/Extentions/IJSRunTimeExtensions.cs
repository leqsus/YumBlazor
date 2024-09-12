﻿using Microsoft.JSInterop;

namespace YumBlazor.Services.Extentions
{
    public static class IJSRunTimeExtensions
    {
        public static async Task ToastrSuccess(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("ShowToastr","success", message);
        }

        public static async Task ToastrError(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("ShowToastr","error", message);
        }
    }
}
