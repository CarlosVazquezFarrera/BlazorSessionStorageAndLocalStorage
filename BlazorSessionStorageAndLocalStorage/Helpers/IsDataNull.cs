using System.Text.Json;

namespace BlazorSessionStorageAndLocalStorage.Helpers
{
    public class IsDataNull
    {
       
        public static T Check<T>(string data) 
        {
            return data == null ? default: JsonSerializer.Deserialize<T>(data); ;
        }
    }
}
