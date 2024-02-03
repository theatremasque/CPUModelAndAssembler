namespace CPU.Application.LowLevelCommands;

public class AddCommand : BaseBinaryCommand
{
    public AddCommand(int registerNumberForResult) 
        : base(registerNumberForResult, "add") { }

    protected override int ExecuteBinaryCommand(int left, int right) => left + right;
}