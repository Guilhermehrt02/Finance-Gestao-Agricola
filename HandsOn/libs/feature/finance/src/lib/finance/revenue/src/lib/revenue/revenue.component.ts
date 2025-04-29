import { Component, OnDestroy, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { CardComponent, RevenueFormComponent } from '@farm/ui';
import { RevenueComponentFacade } from './revenue.component.facade';
import { Revenue } from '@farm/core';

@Component({
  selector: 'lib-revenue',
  imports: [CommonModule, CardComponent, RevenueFormComponent, RouterModule],
  templateUrl: './revenue.component.html',
  styleUrl: './revenue.component.css',
})

export class RevenueComponent implements OnInit, OnDestroy{
  id: string | undefined;
  revenue: Revenue | undefined;
  loading = false;

  title = 'Criar Receita';
  description = 'Preencha os campos abaixo para criar uma nova receita';
  submitLabel = 'Cadastrar';

  constructor(
    private route: ActivatedRoute,
    private facade: RevenueComponentFacade
  ) {}

  ngOnInit() {
    this.id = this.route.snapshot.paramMap.get('id') || undefined;

    if (!this.id) {
      return;
    }
    this.title = 'Editar Receita';
    this.description = 'Preencha os campos abaixo para editar a receita';
    this.submitLabel = 'Editar';

    this.facade.load(this.id);

    this.facade.revenue$.subscribe((revenue) => {
      if (!revenue) return;

      this.revenue = revenue;
    });

    this.facade.loading$.subscribe((loading) => {
      this.loading = loading;
    });
  }

  ngOnDestroy() {
    this.facade.reset();
  }

  onSubmit(revenue: any) {
    this.facade.submit(revenue);
  }
}
