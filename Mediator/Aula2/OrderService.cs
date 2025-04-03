namespace CSharpGeral.Mediator.Aula2
{
    public class OrderService
    {
        private readonly IMediator _mediator;

        public OrderService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<string> PlaceOrderAsync(decimal amount, string address)
        {
            var paymentResult = await _mediator.NotifyAsync(this, "processPayment", amount);
            var shippingResult = await _mediator.NotifyAsync(this, "arrangeShipping", address);
            return $"{paymentResult}\n{shippingResult}";
        }
    }
}
