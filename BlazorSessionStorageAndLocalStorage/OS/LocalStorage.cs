namespace BlazorSessionStorageAndLocalStorage.OS
{
    using BlazorSessionStorageAndLocalStorage.Enum;
    using BlazorSessionStorageAndLocalStorage.Helpers;
    using BlazorSessionStorageAndLocalStorage.OS.Interfaces;
    using Microsoft.AspNetCore.Components;
    using Microsoft.JSInterop;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class LocalStorage : ILocalStorage
    {
        [Inject]
        private JSRuntime JSRuntime { get; set; }
        private  readonly string tipoDeAlmacenamiento = "sessionStorage.";
        public async Task ClearAll()
        {
            await JSRuntime.InvokeVoidAsync($"{tipoDeAlmacenamiento}clear").ConfigureAwait(false);
        }

        public async Task<T> GetValue<T>(ValuesKeys key)
        {
            string data = await JSRuntime.InvokeAsync<string>($"{tipoDeAlmacenamiento}getItem", key.ToString()).ConfigureAwait(false);
            return IsDataNull.Check<T>(data);
        }

        public async Task RemoveItem(ValuesKeys key)
        {
            await JSRuntime.InvokeVoidAsync($"{tipoDeAlmacenamiento}removeItem", key.ToString()).ConfigureAwait(false);
        }

        public async Task SetValue<T>(ValuesKeys key, T value)
        {
            await JSRuntime.InvokeVoidAsync($"{tipoDeAlmacenamiento}setItem", key.ToString(), JsonSerializer.Serialize(value)).ConfigureAwait(false);
        }
    }
}
