namespace Math;
public class SimpleMath
{
    public static int Add (int p1, int p2) => p1 + p2;
    public static int Sub (int p1, int p2) => p1 - p2;
    public static int Divide (int p1, int p2) => p1 / p2;
    public static Task<int> DivideAsync (int p1, int p2)
    {
        return Task.FromResult(p1 / p2);
    }
}
