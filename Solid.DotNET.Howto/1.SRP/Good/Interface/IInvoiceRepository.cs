namespace Solid.DotNET.Howto._1.SRP.Good.Interface;

/// <summary>
/// 
/// </summary>
public interface IInvoiceRepository
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    void Save(decimal amount);
}
