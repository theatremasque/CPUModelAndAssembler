using CPU.Application.LowLevelCommands;

namespace CPU.Application;

class Program
{
    static void Main(string[] args)
    {
        int[] registers = new int[2];
        // 20 + 30
        // 20 > 30
        
        var commands = new ICommand[]
        {
            new PutConstantToRegisterCommand(0, 20),
            new PutConstantToRegisterCommand(1, 30),
            new AddCommand(0),
            new PutConstantToRegisterCommand(0, 20),
            new GtCommand(0)
        }; 

        for (int i = 0; i < commands.Length; i++)
        {
            var currentCommand = commands[i];
            currentCommand.Dump();
            currentCommand.Execute(registers);
            Console.CursorLeft = 20;
            registers.Dump();
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

public static class Memory
{
    private static readonly Dictionary<string, int> _ram = new();

    public static int Read(string address) => _ram[address];

    public static void Write(string address, int value) => _ram[address] = value;
}

public class ReadCommand : ICommand
{
    private readonly int _registerNumberToSaveReadValue;
    private readonly string _address;

    public ReadCommand(int registerNumberToSaveReadValue, string address)
    {
        _registerNumberToSaveReadValue = registerNumberToSaveReadValue;
        _address = address;
    }

    public void Execute(int[] registers)
    {
        registers[_registerNumberToSaveReadValue] = Memory.Read(_address);
    }

    public void Dump()
    {
        Console.Write($"r{_registerNumberToSaveReadValue} = {Memory.Read(_address)} {_address}");
    }
}

public class WriteCommand : ICommand
{
    private readonly int _regNumberToWriteFrom;
    private readonly string _address;

    public WriteCommand(int regNumberToWriteFrom, string address)
    {
        _regNumberToWriteFrom = regNumberToWriteFrom;
        _address = address;
    }

    public void Execute(int[] registers)
    {
        Memory.Write(_address, registers[_regNumberToWriteFrom]);
    }

    public void Dump()
    {
        Console.Write($"{_address} = r{_regNumberToWriteFrom}");
    }
}