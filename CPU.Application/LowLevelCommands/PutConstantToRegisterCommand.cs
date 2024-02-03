namespace CPU.Application.LowLevelCommands;

class PutConstantToRegisterCommand : ICommand
{
    private readonly int _registerNumberToWrite, _constant;
    public PutConstantToRegisterCommand(int registerNumberToWrite, int constant)
    {
        _registerNumberToWrite = registerNumberToWrite;
        _constant = constant;
    }
    public void Execute(int[] registers)
    {
        registers[_registerNumberToWrite] = _constant;
    }

    public void Dump()
    {
        Console.Write($"put r{_registerNumberToWrite} {_constant}");
    }
}