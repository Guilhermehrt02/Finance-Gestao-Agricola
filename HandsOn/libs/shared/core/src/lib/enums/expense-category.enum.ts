export enum ExpenseCategory {
  Infrastructure = 'Infrastructure',
  Machine = 'Machine',
  Input = 'Input',
  Defensive = 'Defensive',
  OthersLongTerm = 'OthersLongTerm',
  OthersShortTerm = 'OthersShortTerm',
}

export const ExpenseCategoryLabels: Record<ExpenseCategory, string> = {
  [ExpenseCategory.Infrastructure]: 'Infraestrutura',
  [ExpenseCategory.Machine]: 'Máquina',
  [ExpenseCategory.Input]: 'Insumo',
  [ExpenseCategory.Defensive]: 'Defensivo',
  [ExpenseCategory.OthersLongTerm]: 'Outros - Longo Prazo',
  [ExpenseCategory.OthersShortTerm]: 'Outros - Curto Prazo',
};
