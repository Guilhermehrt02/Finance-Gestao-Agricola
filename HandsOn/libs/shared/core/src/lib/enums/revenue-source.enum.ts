export enum RevenueSource {
  Salary = 'Salary',
  Bonus = 'Bonus',
  Investment = 'Investment',
  RentalIncome = 'RentalIncome',
  Other = 'Other',
}

export const RevenueSourceLabels: Record<RevenueSource, string> = {
    [RevenueSource.Salary]: 'Salário',
    [RevenueSource.Bonus]: 'Bônus',
    [RevenueSource.Investment]: 'Investimento',
    [RevenueSource.RentalIncome]: 'Renda de Aluguel',
    [RevenueSource.Other]: 'Outros',
  };