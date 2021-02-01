using BlazorSessionStorageAndLocalStorage.Enum;
using BlazorSessionStorageAndLocalStorage.OS.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorSessionStorageAndLocalStorage.Pages
{
    public partial class BorrarDatos
    {
        [Inject]
        private ILocalStorage LocalStorage { get; set; }
        private void BorrarDatoSencillo()
        {
            LocalStorage.RemoveItem(ValuesKeys.DatoSimple);
        }

        private void BorrarObjeto()
        {
            LocalStorage.RemoveItem(ValuesKeys.Persona);
        }

        private void BorrarTodo()
        {
            LocalStorage.ClearAll();

        }
    }
}
