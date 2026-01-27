using Solid.DotNET.Howto._1.SRP.Good.Interface;

namespace Solid.DotNET.Howto._1.SRP.Good;

/// <summary>
/// 
/// </summary>
public sealed class InvoiceService
{
    private readonly IInvoiceRepository _repository;
    private readonly ILogger _logger;

    public InvoiceService(IInvoiceRepository repository, ILogger logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public void CreateInvoice(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Invalid invoice amount");

        _repository.Save(amount);
        _logger.Log($"Invoice created with amount: {amount}");
    }
}
