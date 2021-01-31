namespace BlazorSessionStorageAndLocalStorage.OS.Interfaces
{
    using BlazorSessionStorageAndLocalStorage.Enum;
    using System.Threading.Tasks;
    interface ILocalStorage
    {
        /// <summary>
        /// Guarda en memoria un valor del tipo de datos que le indicamos en el generic
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<T> GetValue<T>(ValuesKeys key);
        /// <summary>
        /// Retorna un valor en específico dependiendo del Enum que enviemos com parametro
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        Task SetValue<T>(ValuesKeys key, T value);
        /// <summary>
        /// Elimina de memória el item que le indiquemos a través del Enum
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task RemoveItem(ValuesKeys key);
        /// <summary>
        /// Limpia todo lo que hay en memoria
        /// </summary>
        /// <returns></returns>
        Task ClearAll();
    }
}
