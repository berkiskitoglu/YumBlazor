using Microsoft.JSInterop;

namespace YumBlazor.Extensions
{
    public static class JsRuntimeExtensions
    {
        public static async Task ToastrSuccess(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("ShowToastr", "success", message);
        }
        public static async Task ToastrWarning(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("ShowToastr", "warning", message);
        }

    }

}
