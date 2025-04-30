import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonComponent, Column, Row, TableComponent } from '@farm/ui';
import { RevenueListComponentFacade } from './revenue-list.component.facade';

@Component({
  selector: 'lib-revenue-list',
  imports: [CommonModule, TableComponent, ButtonComponent],
  templateUrl: './revenue-list.component.html',
  styleUrl: './revenue-list.component.css',
})

export class RevenueListComponent implements OnInit {
  data: Row[] = [];
  columns: Column[];
  loading = false;
  showMoreButton = true;

  constructor(private facade: RevenueListComponentFacade) {
    this.columns = columns;
  }

  ngOnInit(): void {
    this.facade.loading$.subscribe((loading) => {
      this.loading = loading;
    });

    this.facade.revenues$.subscribe((revenues) => {
      this.data = revenues
    });

    this.facade.load();
  }

  refresh() {
    this.facade.load();
  }

  onCreate() {
    this.facade.navegateToCreateRevenue();
  }
}

const columns: Column[] = [
  {
    field: 'description',
    header: 'Descrição',
    type: 'text',
    sortable: false,
    filterable: true,
    visible: true,
    showToUser: true,
  },
  {
    field: 'source',
    header: 'Fonte',
    type: 'text',
    sortable: true,
    filterable: true,
    visible: true,
    showToUser: true,
  },
  {
    field: 'amount',
    header: 'Valor',
    type: 'currency',
    sortable: true,
    filterable: true,
    visible: true,
    showToUser: true,
  },
  {
    field: 'date',
    header: 'Data',
    type: 'date',
    sortable: true,
    filterable: true,
    visible: true,
    showToUser: true,
  },
  {
    field: 'createdAt',
    header: 'Criado em',
    type: 'datetime',
    sortable: true,
    filterable: true,
    visible: true,
    showToUser: false,
  },
  {
    field: 'updatedAt',
    header: 'Atualizado em',
    type: 'datetime',
    sortable: true,
    filterable: true,
    visible: true,
    showToUser: false,
  },
  {
    field: 'receiptUrl',
    header: 'Comprovante',
    type: 'file',
    sortable: false,
    filterable: true,
    visible: true,
    showToUser: true,
  }
];
