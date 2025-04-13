export enum Category {
    Infrastructure = 0,
    Machine = 1,
    input = 2,
    defensive = 3,
    othersLongTerm = 4,
    othersShortTerm = 5
  }
  
  export const categoryLabels: Record<Category, string> = {
    [Category.Infrastructure]: 'Infraestrutura',
    [Category.Machine]: 'Máquina',
    [Category.input]: 'Insumo',
    [Category.defensive]: 'Defensivo',
    [Category.othersLongTerm]: 'Outros (Longo Prazo)',
    [Category.othersShortTerm]: 'Outros (Curto Prazo)',
  };
  