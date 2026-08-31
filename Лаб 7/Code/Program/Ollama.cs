



using System.Text;
using System.Text.Json;



/// <summary> Класс для работы с AI моделью </summary>
class ModelAI{
    public static async Task<string?> Run(string message){
        using var http = new HttpClient();

        var requestBody = new {
            model = "gemma3:1b",
            prompt = $""" Ответь на данное сообщение: {message}. """,
            
            stream = false,
            options = new{ num_predict = 200} // ~1000 символов
        };

        var content = new StringContent(
            JsonSerializer.Serialize(requestBody),
            Encoding.UTF8,
            "application/json"
        );

        var response = await http.PostAsync("http://host.docker.internal:11434/api/generate", content);
        response.EnsureSuccessStatusCode();

        string resultJson = await response.Content.ReadAsStringAsync();

        using var doc = JsonDocument.Parse(resultJson);
        string? output = doc.RootElement.GetProperty("response").GetString();

        return output; 
    }
}