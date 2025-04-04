export interface Expense {
    id: string;
    description?: string;
    category: string | number;
    amount: number;
    date: Date;
    userId: string;
    createdAt: Date;
    updatedAt: Date;
    paymentMethod?: string | number;
    receiptUrl?: string;
}