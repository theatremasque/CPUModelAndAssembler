namespace CPU.Application.LowLevelCommands;

public class SubtractCommand : BaseBinaryCommand
{
    public SubtractCommand(int registerNumberForResult) 
        : base(registerNumberForResult, "sub") { }

    protected override int ExecuteBinaryCommand(int left, int right) => left - right;
}