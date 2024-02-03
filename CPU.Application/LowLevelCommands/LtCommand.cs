namespace CPU.Application.LowLevelCommands;

public class LtCommand : BaseBinaryCommand
{
    public LtCommand(int registerNumberForResult) 
        : base(registerNumberForResult, "lt") { }

    protected override int ExecuteBinaryCommand(int left, int right) => Convert.ToInt32(left < right);
}