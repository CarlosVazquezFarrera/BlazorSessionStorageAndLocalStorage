using System.Text.Json;

namespace BlazorSessionStorageAndLocalStorage.Helpers
{
    public class IsDataNull
    {
        public static T Check<T>(string data)
        {
            if (data == null)
                return default;
            return JsonSerializer.Deserialize<T>(data);
        }
    }
}
