export enum PaymentMethod {
    Cash = 'Cash',
    CreditCard = 'CreditCard',
    DebitCard = 'DebitCard',
    Pix = 'Pix',
    Boleto = 'Boleto',
}

export const PaymentMethodLabels: Record<PaymentMethod, string> = {
    [PaymentMethod.Cash]: 'Dinheiro',
    [PaymentMethod.CreditCard]: 'Cartão de Crédito',
    [PaymentMethod.DebitCard]: 'Cartão de Débito',
    [PaymentMethod.Pix]: 'Pix',
    [PaymentMethod.Boleto]: 'Boleto',
};