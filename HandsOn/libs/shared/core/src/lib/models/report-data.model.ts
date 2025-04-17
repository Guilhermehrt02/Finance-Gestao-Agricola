export interface ReportData {
  totalRevenues: number;
  totalExpenses: number;
  totalBalance: number;
  expenses?: { category: string; amount: number; date: Date }[];
  revenues?: { source: string; amount: number; date: Date }[];
  revenueAndExpenseByPeriod?: { type: string; amount: number; period: string }[];
}
