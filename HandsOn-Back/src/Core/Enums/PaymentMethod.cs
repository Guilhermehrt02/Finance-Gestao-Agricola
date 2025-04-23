namespace Core.Enums
{
    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        DebitCard,
        Pix,
        Boleto
    }

    public static class PaymentMethodExtension
    {
        public static string ToFriendlyString(this PaymentMethod paymentMethod)
        {
            return paymentMethod switch
            {
                PaymentMethod.Cash => "Cash",
                PaymentMethod.CreditCard => "CreditCard",
                PaymentMethod.DebitCard => "DebitCard",
                PaymentMethod.Pix => "Pix",
                PaymentMethod.Boleto => "Boleto",
                _ => "Unknown",
            };
        }

        public static PaymentMethod ToPaymentMethod(this string paymentMethod)
        {
            return paymentMethod.Replace(" ", "") switch
            {
                "Cash" => PaymentMethod.Cash,
                "CreditCard" => PaymentMethod.CreditCard,
                "DebitCard" => PaymentMethod.DebitCard,
                "Pix" => PaymentMethod.Pix,
                "Boleto" => PaymentMethod.Boleto,
                _ => PaymentMethod.Cash,
            };
        }

        public static PaymentMethod[] GetValues()
        {
            return [PaymentMethod.Cash, PaymentMethod.CreditCard, PaymentMethod.DebitCard, PaymentMethod.Pix, PaymentMethod.Boleto];
        }
    }
}