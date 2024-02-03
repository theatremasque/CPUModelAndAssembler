namespace CPU.Application.LowLevelCommands;

public abstract class BaseBinaryCommand : ICommand
{
    private readonly int _registerNumberForResult;
    private readonly string _command;
    public BaseBinaryCommand(int registerNumberForResult, string command)
    {
        _registerNumberForResult = registerNumberForResult;
        _command = command;
    }

    public void Execute(int[] registers)
    {
        registers[_registerNumberForResult] = ExecuteBinaryCommand(registers[0], registers[1]);
    }

    public void Dump()
    {
        Console.Write($"{_command} r{_registerNumberForResult}");
    }

    protected abstract int ExecuteBinaryCommand(int left, int right);
}