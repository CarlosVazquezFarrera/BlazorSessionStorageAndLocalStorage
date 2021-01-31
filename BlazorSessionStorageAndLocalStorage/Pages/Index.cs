namespace BlazorSessionStorageAndLocalStorage.Pages
{
    using BlazorSessionStorageAndLocalStorage.Enum;
    using BlazorSessionStorageAndLocalStorage.OS.Interfaces;
    using Microsoft.AspNetCore.Components;
    public partial class Index
    {
        [Inject]
        private ILocalStorage LocalStorage { get; set; }

        public string ValorSencillo { get; set; }
        private void Guardar()
        {
            LocalStorage.SetValue<string>(ValuesKeys.DatoSimple, ValorSencillo);
        }
    }
}
