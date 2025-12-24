using System.Collections.Generic;
using UnityEngine;

public class CS_CInvoker : MonoBehaviour
{
    private Stack<CS_ICommand> _commandHistory = new Stack<CS_ICommand>();

    public void ExecuteCommand(CS_ICommand command)
    {
        command.Execute();
        _commandHistory.Push(command);
    }

    public void UndoLastCommand()
    {
        if (_commandHistory.Count > 0)
        {
            CS_ICommand lastCommand = _commandHistory.Pop();
            lastCommand.Undo();
        }
    }
}