export interface Expense {
    id: string;
    description?: string;
    category: string;
    amount: number;
    date: Date;
    userId: string;
    createdAt: Date;
    updatedAt: Date;
    paymentMethod?: string;
    receiptUrl?: string;
}