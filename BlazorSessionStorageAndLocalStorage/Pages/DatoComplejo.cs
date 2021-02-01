namespace BlazorSessionStorageAndLocalStorage.Pages
{
    using BlazorSessionStorageAndLocalStorage.Enum;
    using BlazorSessionStorageAndLocalStorage.Modelos;
    using BlazorSessionStorageAndLocalStorage.OS.Interfaces;
    using Microsoft.AspNetCore.Components;
    public partial class DatoComplejo
    {
        [Inject]
        private ILocalStorage LocalStorage { get; set; }

        public Persona Persona = new Persona();
        public void GuardarObjeto()
        {
            LocalStorage.SetValue<Persona>(ValuesKeys.Persona, Persona);
        }
    }
}
