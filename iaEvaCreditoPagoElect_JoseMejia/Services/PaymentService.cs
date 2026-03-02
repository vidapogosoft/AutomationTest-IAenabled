namespace EvaluacionCredito.Services
{
    public class PaymentService
    {
        /// <summary>
        /// Processes a card payment and returns the registration result.
        /// </summary>
        /// <param name="card">Name of the card.</param>
        /// <param name="issuerAuthorized">true if the issuer approved the transaction.</param>
        /// <param name="receiptIssued">out flag indicating whether a receipt should be printed.</param>
        /// <returns>"aprobado" or "no aprobado"</returns>
        public string Process(string card, bool issuerAuthorized, out bool receiptIssued)
        {
            receiptIssued = issuerAuthorized;
            return issuerAuthorized ? "aprobado" : "no aprobado";
        }
    }
}