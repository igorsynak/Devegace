using Discord;

namespace devegace;

class Program {
    static async Task Main(String[] argumenty)  { // async oznacza że mogę użyć await ( czekania/wznawiania ) a Task że mogę zwracać future, trch jak w rust
        Console.WriteLine("witajjj");
    }
    private static Task Log(LogMessage wiadomość) { // przyjmuję loga i go printuję, chb prote ale potem dodam zapisy w pliku, wraziewu ( ewoluuje język lol )
        Console.WriteLine(wiadomość.ToString());
        return Task.CompletedTask; // imo "Task.CompleteTask" lepsze jest od "return Task.CompleteTask;", rust better xD
    }
}
