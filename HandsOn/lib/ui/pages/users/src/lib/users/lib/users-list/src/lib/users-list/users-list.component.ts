import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  TableComponent,
  Column,
} from 'lib/ui/shared/components/table/table.component';
import { MenuItem } from 'primeng/api';
import { User } from '@hands-on/models';

@Component({
  selector: 'lib-users-list',
  imports: [CommonModule, TableComponent],
  templateUrl: './users-list.component.html',
  styleUrl: './users-list.component.css',
})
export class UsersListComponent {
  data: unknown[];
  columns: Column[];
  showMoreItems: MenuItem[] = [
    {
      label: 'Opções',
      items: [
        {
          label: 'Editar',
          icon: 'pi pi-pencil',
          routerLink: null,
          styleClass: 'description',
        },
        {
          label: 'Excluir',
          icon: 'pi pi-trash',
          routerLink: null,
          styleClass: 'description',
          iconClass: 'error',
        },
      ],
    },
  ];

  constructor() {
    this.data = dataTest;
    this.columns = columnsTest;
  }

  onShowMoreClick(rowClicked: User) {
    if (!rowClicked || !this.showMoreItems[0].items) return;

    this.showMoreItems[0].items[0].routerLink = `/farm/users/${rowClicked.id}`;
  }
}

const dataTest: User[] = [
  {
    id: '66d3d671-5670-48a9-ac52-61db1a4cc575',
    firstName: 'Alice1',
    lastName: 'Anderson',
    email: 'example3@gmail.com',
    phoneNumber: '+5535922222222',
    role: 'Consultant',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: '68f0303a-94cf-4f9b-a1ff-85bc75f48aa9',
    firstName: 'Bob',
    lastName: 'Anderson',
    email: 'example4@gmail.com',
    phoneNumber: '+5535933333333',
    role: 'Manager',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: '7b4f2b03-a795-4d3b-9191-0de5b668441f',
    firstName: 'John',
    lastName: 'Doe',
    email: 'example1@gmail.com',
    phoneNumber: '+5535900000000',
    role: 'Admin',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: 'e998504d-8b41-45b2-9991-1b83d49834fc',
    firstName: 'Jane',
    lastName: 'Doe',
    email: 'example2@gmail.com',
    phoneNumber: '+5535911111111',
    role: 'Owner',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: 'f5a86e69-6dd3-430b-af47-71532a31df88',
    firstName: 'Charlie',
    lastName: 'Smith',
    email: 'example5@gmail.com',
    phoneNumber: '+5535944444444',
    role: 'Collaborator',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: '66d3d671-5670-48a9-ac52-61db1a4cc575',
    firstName: 'Alice',
    lastName: 'Anderson',
    email: 'example3@gmail.com',
    phoneNumber: '+5535922222222',
    role: 'Consultant',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: '68f0303a-94cf-4f9b-a1ff-85bc75f48aa9',
    firstName: 'Bob',
    lastName: 'Anderson',
    email: 'example4@gmail.com',
    phoneNumber: '+5535933333333',
    role: 'Manager',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: '7b4f2b03-a795-4d3b-9191-0de5b668441f',
    firstName: 'John',
    lastName: 'Doe',
    email: 'example1@gmail.com',
    phoneNumber: '+5535900000000',
    role: 'Admin',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: 'e998504d-8b41-45b2-9991-1b83d49834fc',
    firstName: 'Jane',
    lastName: 'Doe',
    email: 'example2@gmail.com',
    phoneNumber: '+5535911111111',
    role: 'Owner',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: 'f5a86e69-6dd3-430b-af47-71532a31df88',
    firstName: 'Charlie',
    lastName: 'Smith',
    email: 'example5@gmail.com',
    phoneNumber: '+5535944444444',
    role: 'Collaborator',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: '66d3d671-5670-48a9-ac52-61db1a4cc575',
    firstName: 'Alice',
    lastName: 'Anderson',
    email: 'example3@gmail.com',
    phoneNumber: '+5535922222222',
    role: 'Consultant',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: '68f0303a-94cf-4f9b-a1ff-85bc75f48aa9',
    firstName: 'Bob',
    lastName: 'Anderson',
    email: 'example4@gmail.com',
    phoneNumber: '+5535933333333',
    role: 'Manager',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: '7b4f2b03-a795-4d3b-9191-0de5b668441f',
    firstName: 'John',
    lastName: 'Doe',
    email: 'example1@gmail.com',
    phoneNumber: '+5535900000000',
    role: 'Admin',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: 'e998504d-8b41-45b2-9991-1b83d49834fc',
    firstName: 'Jane',
    lastName: 'Doe',
    email: 'example2@gmail.com',
    phoneNumber: '+5535911111111',
    role: 'Owner',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
  {
    id: 'f5a86e69-6dd3-430b-af47-71532a31df88',
    firstName: 'Charlie',
    lastName: 'Smith',
    email: 'example5@gmail.com',
    phoneNumber: '+5535944444444',
    role: 'Collaborator',
    createdAt: '2025-02-24T22:44:02',
    updatedAt: '2025-02-24T22:44:02',
    status: 0,
  },
];

const columnsTest: Column[] = [
  {
    field: 'firstName',
    header: 'Name',
    type: 'text',
    sortable: true,
    filterable: true,
    visible: true,
    showToUser: true,
  },
  {
    field: 'lastName',
    header: 'Sobrenome',
    type: 'text',
    sortable: true,
    filterable: true,
    visible: true,
    showToUser: true,
  },
  {
    field: 'email',
    header: 'Email',
    type: 'text',
    sortable: true,
    filterable: true,
    visible: true,
    showToUser: true,
  },
  {
    field: 'phoneNumber',
    header: 'Telefone',
    type: 'text',
    sortable: true,
    filterable: true,
    visible: true,
    showToUser: true,
  },
  {
    field: 'role',
    header: 'Função',
    type: 'text',
    sortable: true,
    filterable: true,
    visible: true,
    showToUser: true,
    fraction: 0.5,
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
    field: 'status',
    header: 'Status',
    type: 'text',
    sortable: true,
    filterable: true,
    visible: true,
    showToUser: true,
    fraction: 0.5,
  },
];
