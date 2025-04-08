export interface Revenue {
    id: string;
    description?: string;
    source: string | number;
    amount: number;
    date: Date;
    userId: string;
    createdAt: Date;
    updatedAt: Date;
    receiptUrl?: string;
}