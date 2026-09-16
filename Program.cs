using Discord;
using Discord.WebSocket;
using DotNetEnv;

namespace Devegace;

class Program {
    private static DiscordSocketClient klient = new(); // chyba nie musi mieć takie nazwy ale lepiej już dam xD, wgl kto wymyślił nazwy zmiennych na końcu jakby wth. New niepotrzebne ale nei chce błędów lol
    public static async Task Main(String[] argumenty) { // async oznacza że mogę użyć await ( czekania/wznawiania ) a Task że mogę zwracać future, trch jak w rust
        Env.Load(); // idk pewnie ładuje plik .env do pamięci albo cuś
        string token = Environment.GetEnvironmentVariable("TOKEN"); // hmmm ciekawe co to robi nwm
        Console.WriteLine("Witaj");
        klient = new DiscordSocketClient(); // tworzę klienta
        klient.Log += Dziennik; // += oznacza że jak uruchomi się Log to wykona to co jest po, czyli Dziennik
        await klient.LoginAsync(TokenType.Bot, token);
        await klient.StartAsync();
        await Task.Delay(-1);
    }
    private static Task Dziennik(LogMessage wiadomość) { // przyjmuję loga i go printuję, chb prote ale potem dodam zapisy w pliku, wraziewu ( ewoluuje język lol )
        Console.WriteLine(wiadomość.ToString());
        return Task.CompletedTask; // imo "Task.CompleteTask" lepsze jest od "return Task.CompleteTask;", rust better xD
    }
}
