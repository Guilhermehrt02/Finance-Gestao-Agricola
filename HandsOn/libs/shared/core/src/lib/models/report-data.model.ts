export interface ReportData {
  totalRevenues: number;
  totalExpenses: number;
  totalBalance: number;
  expenses?: { category: string; amount: number; }[];
  revenues?: { source: string; amount: number; }[];
  revenueAndExpenseByPeriod?: { type: string; amount: number; period: string }[];
}
