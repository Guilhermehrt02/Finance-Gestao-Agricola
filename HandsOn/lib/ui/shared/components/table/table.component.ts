import {
  AfterViewInit,
  Component,
  EventEmitter,
  Input,
  OnInit,
  Output,
  ViewChild,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormControl, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { debounceTime } from 'rxjs';
import { Table, TableModule } from 'primeng/table';
import { Skeleton } from 'primeng/skeleton';
import { ButtonComponent, InputComponent, MenuComponent } from '../..';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-table',
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    TableModule,
    Skeleton,
    ButtonComponent,
    InputComponent,
    MenuComponent,
  ],
  templateUrl: './table.component.html',
  styleUrl: './table.component.css',
})
export class TableComponent implements AfterViewInit, OnInit {
  @Input() data: any[] = [];
  @Input() columns: Column[] = [];
  @Input() loading = false;
  @Input() showLoader = false;
  @Input() totalRecords = 0;
  @Input() rows = 10;
  @Input() rowsPerPageOptions: number[] = [5, 10, 25, 50, 100];
  @Input() paginator = true;
  @Input() stateKey = 'tableState';
  @Input() globalFilterFields: string[] = [];
  @Input() dataKey = 'id';
  @Input() currencyCode: 'BRL' | 'USD' | 'EUR' = 'BRL';
  @Input() showMoreButton = false;
  @Input() showMoreItems: MenuItem[] = [];

  @Output() rowSelect: EventEmitter<any> = new EventEmitter();
  @Output() rowUnselect: EventEmitter<any> = new EventEmitter();
  @Output() showMore: EventEmitter<any> = new EventEmitter();

  @ViewChild(Table) table: any;

  selectedData: any[] = [];
  showClearFilterButton = false;
  searchControl = new FormControl('');
  filteredColumns: Column[] = [];

  columnsWidths: any = {};
  totalColumnsWidth = 0;

  rowClicked: any = null;

  ngOnInit() {
    this.searchControl.valueChanges
      .pipe(debounceTime(300))
      .subscribe((term) => {
        this.onFilterGlobal(term);
      });

    this.filteredColumns = this.columns.filter(
      (column) => column.showToUser && column.visible
    );

    this.calculateColumnsWidths();
  }

  ngAfterViewInit() {
    this.globalFilterFields = this.columns
      .filter((column) => column.showToUser)
      .map((column) => column.field);

    const state = localStorage.getItem(this.stateKey);

    if (state) {
      const parsedState = JSON.parse(state);

      if (parsedState.filters) {
        this.onFilterGlobal(parsedState.filters.global?.value);
      }
    }
  }

  onRowSelected(event: any) {
    this.rowSelect.emit(event.data);
  }

  onRowUnselected(event: any) {
    this.rowUnselect.emit(event.data);
  }

  clearSelection() {
    this.selectedData = [];
  }

  onShowMoreClick(event: any) {
    this.showMore.emit(event);
  }

  get getSelectedData(): any[] {
    return this.selectedData;
  }

  get getColumns(): Column[] {
    return this.columns.filter((column) => column.visible);
  }

  get getGlobalFilterFields(): string[] {
    return this.globalFilterFields;
  }

  onFilterGlobal(term: string | null) {
    if (!this.table) return;

    if (term && term.length > 0) {
      this.showClearFilterButton = true;
      this.table.filterGlobal(term, 'contains');
    } else {
      this.showClearFilterButton = false;
      this.table.clear();
      this.table.reset();
      this.table.clearFilterValues();
      this.table.clearState();
    }
  }

  onClearFilter() {
    this.searchControl.setValue('');
    this.showClearFilterButton = false;
    this.table.clear();
    this.table.reset();
    this.table.clearFilterValues();
    this.table.clearState();
  }

  calculateColumnsWidths() {
    this.totalColumnsWidth = 0;

    const columnsWidths = this.columns
      .filter((column) => column.showToUser && column.visible)
      .reduce((acc: any, column: any) => {
        const fraction = column.fraction || 1;

        this.totalColumnsWidth += fraction;

        acc[column.field] = fraction;

        return acc;
      }, {});

    const size = this.showMoreButton ? 95 : 100;

    this.columnsWidths = Object.keys(columnsWidths).reduce(
      (acc: any, key: any) => {
        const value: number =
          (columnsWidths[key] / this.totalColumnsWidth) * size;

        acc[key] = `${value.toFixed(2)}%`;

        return acc;
      },
      {}
    );
  }

  onClickRow(event: any) {
    this.rowClicked = event;
  }
}

export interface Column {
  field: string;
  header: string;
  type: 'text' | 'date' | 'datetime' | 'currency';
  sortable?: boolean;
  filterable?: boolean;
  visible?: boolean;
  showToUser?: boolean;
  fraction?: number;
}
