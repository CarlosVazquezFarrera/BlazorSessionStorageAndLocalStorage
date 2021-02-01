using BlazorSessionStorageAndLocalStorage.Enum;
using BlazorSessionStorageAndLocalStorage.Modelos;
using BlazorSessionStorageAndLocalStorage.OS.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorSessionStorageAndLocalStorage.Pages
{
    public partial class VerDatosGuardados
    {
        [Inject]
        private ILocalStorage LocalStorage { get; set; }
        public string DatoSimple = string.Empty;

        public Persona Persona = new Persona();

        protected async override Task OnInitializedAsync()
        {
            DatoSimple = await LocalStorage.GetValue<string>(ValuesKeys.DatoSimple);
            Persona = await LocalStorage.GetValue<Persona>(ValuesKeys.Persona);
        }
      
    }
}
