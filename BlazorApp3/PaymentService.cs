namespace BlazorApp3
{
    public class PaymentService
    {
        private PaymentSelections currentSelections = new PaymentSelections();

        public PaymentSelections CurrentSelections { get => currentSelections; set => currentSelections = value; }

        public void ResetSelections()
        {
            CurrentSelections = new PaymentSelections();
        }

    }
}