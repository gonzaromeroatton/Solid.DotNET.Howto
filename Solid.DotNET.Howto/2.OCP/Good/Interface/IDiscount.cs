namespace Solid.DotNET.Howto._2.OCP.Good.Interface;

/// <summary>
/// 
/// </summary>
public interface IDiscount
{
    bool IsMatch(string type);
    decimal CalculateDiscount(decimal amount);
}
