namespace CPU.Application.LowLevelCommands;

public class GtCommand : BaseBinaryCommand
{
    public GtCommand(int registerNumberForResult) 
        : base(registerNumberForResult, "gt") { }

    protected override int ExecuteBinaryCommand(int left, int right) => Convert.ToInt32(left > right);
}