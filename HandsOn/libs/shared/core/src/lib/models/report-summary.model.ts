export interface ReportSummary {
    totalRevenue: number;
    totalExpenses: number;
    netBalance: number;
    byCategory: { label: string; value: number }[];
    bySource: { label: string; value: number }[];
  }