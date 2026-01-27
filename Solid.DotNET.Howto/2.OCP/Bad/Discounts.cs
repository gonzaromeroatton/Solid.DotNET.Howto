namespace Solid.DotNET.Howto._2.OCP.Bad;

/// <summary>
/// 
/// </summary>
public sealed class Discounts
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="type"></param>
    /// <param name="amount"></param>
    /// <returns></returns>
    public decimal CalculateDiscount(string type, decimal amount)
    {
        return type switch
        {
            "Regular" => amount * 0.05m,
            "Premium" => amount * 0.10m,
            "VIP" => amount * 0.15m,
            _ => 0m,
        };
    }
}
