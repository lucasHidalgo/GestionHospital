import { User } from '../../_models/user';
import { Component, OnInit, ViewChild} from '@angular/core';
import {MatTableDataSource} from '@angular/material/table';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';

@Component({
  selector: 'app-users-list',
  templateUrl: './users-list.component.html',
  styleUrls: ['./users-list.component.css']
})

export class UsersListComponent implements OnInit {  
  displayedColumns: string[] = ['Id', 'Nombre', 'Apellido', 'Edad'];
  dataSource: MatTableDataSource<User>;

  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;

  constructor() {
    const usuarios = Array.from({length: 100}, (_, k) => CrearUsuarios());

    this.dataSource = new MatTableDataSource(usuarios);
  }

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }
}

function CrearUsuarios(): User{
  return {
    Id: Math.round(Math.random() * 100),
    Nombre: 'Nombre Test',
    Apellido: 'Apellido Test',
    Edad: Math.round(Math.random() * 100)
  };
}
