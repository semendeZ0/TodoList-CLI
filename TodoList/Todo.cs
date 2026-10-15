namespace TodoList;
using System.IO;

public class Todo
{
    private string _arquivo = "list.txt";
    private string _content; 

    public Todo()
    {
        _content = File.ReadAllText(_arquivo);
    }

    public string MostrarTarefas()
    {
        return _content;
    }
    
    
    
}