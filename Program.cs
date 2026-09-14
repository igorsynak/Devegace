using Discord;
using Discord.WebSocket;
using DotNetEnv;

namespace devegace;

class Program {
    private static DiscordSocketClient klient; // chyba nie musi mieć takie nazwy ale lepiej już dam xD, wgl kto wymyślił nazwy zmiennych na końcu jakby wth
    static string token;
    public static async Task Main(String[] argumenty)  { // async oznacza że mogę użyć await ( czekania/wznawiania ) a Task że mogę zwracać future, trch jak w rust
        Env.Load();
        token = Environment.GetEnvironmentVariable("TOKEN");
        Console.WriteLine("witajjj");
        klient = new DiscordSocketClient();
        klient.Log += Dziennik; // += oznacza że jak uruchomi się Log to wykona to co jest po, czyli Dziennik
    }
    private static Task Dziennik(LogMessage wiadomość) { // przyjmuję loga i go printuję, chb prote ale potem dodam zapisy w pliku, wraziewu ( ewoluuje język lol )
        Console.WriteLine(wiadomość.ToString());
        return Task.CompletedTask; // imo "Task.CompleteTask" lepsze jest od "return Task.CompleteTask;", rust better xD
    }
}
