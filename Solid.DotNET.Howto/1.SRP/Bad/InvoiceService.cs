using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DotNET.Howto._1.SRP.Bad;

/// <summary>
/// 
/// </summary>
public sealed class InvoiceService
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    /// <exception cref="ArgumentException"></exception>
    public void CreateInvoice(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Invalid invoice amount");

        SaveToDatabase(amount);
        LogToFile($"Invoice created with amount: {amount}");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    private void SaveToDatabase(decimal amount)
    {
        // Simulate saving to a database
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    private void LogToFile(string message)
    {
        // Simulate logging to a file
    }
}
