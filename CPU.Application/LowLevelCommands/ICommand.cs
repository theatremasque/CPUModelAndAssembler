namespace CPU.Application.LowLevelCommands;

public interface ICommand
{
    void Execute(int[] registers);

    void Dump();
}