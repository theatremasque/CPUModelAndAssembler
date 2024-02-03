namespace CPU.Application;

public static class RegisterExtensions
{
    public static void Dump(this int[] registers)
    {
        foreach (var register in registers)
        {
            Console.Write($"{register, 3}");
        }
    }
}