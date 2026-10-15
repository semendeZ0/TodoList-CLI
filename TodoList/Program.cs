using TodoList;
public static class Program
{
    public static void Main()
    {
        Todo lista = new();
        string[] conteudo = lista.MostrarTarefas();
        
        lista.AddTarefa("Teste testoso foda pra krl pprt kkkkkkkk");

        foreach (var _tarefa in conteudo)
        {
            Console.WriteLine(_tarefa);
        }
        
    }
}