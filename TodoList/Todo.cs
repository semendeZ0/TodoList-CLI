namespace TodoList;
using System.IO;

public class Todo
{
    private string _caminho = "list.txt";
    private string[] _content; 

    public Todo()
    {
        _content = File.ReadAllLines(_caminho);
    }

    public string[] MostrarTarefas()
    {
        return _content;
    }

    public void AddTarefa(string tarefa)
    {
        File.AppendAllText(_caminho, $"[ ] - {tarefa}\n");
    }
    
    
    
}