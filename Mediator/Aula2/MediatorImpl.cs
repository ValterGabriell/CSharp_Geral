namespace CSharpGeral.Mediator.Aula2
{
    public class PaymentService
    {
        public async Task<string> ProcessPaymentAsync(decimal amount)
        {
            await Task.Delay(500); // Simulando chamada a API externa
            return $"Pagamento de {amount:C} processado com sucesso.";
        }
    }

    public class ShippingService
    {
        public async Task<string> ArrangeShippingAsync(string address)
        {
            await Task.Delay(500); // Simulando chamada a API externa
            return $"Envio para {address} agendado com sucesso.";
        }
    }





    public class MediatorImpl : IMediator
    {
        private readonly PaymentService _paymentService;
        private readonly ShippingService _shippingService;

        public MediatorImpl(PaymentService paymentService, ShippingService shippingService)
        {
            _paymentService = paymentService;
            _shippingService = shippingService;
        }

        public async Task<string> NotifyAsync(object sender, string eventType, object data)
        {
            switch (eventType)
            {
                case "processPayment":
                    return await _paymentService.ProcessPaymentAsync((decimal)data);
                case "arrangeShipping":
                    return await _shippingService.ArrangeShippingAsync((string)data);
                default:
                    return "Evento desconhecido.";
            }
        }
    }
}
