import { Menu } from './../../_models/menu';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pages',
  templateUrl: './pages.component.html',
  styleUrls: ['./pages.component.css']
})
export class PagesComponent implements OnInit {
   menuPages: Menu[] = [
      {Name: 'Users', Description: 'Description for users', matIcon: 'account_circle', pages: [
        {Url: '/users', Name: 'List of users' },
        {Url: '/NewUser', Name: 'New user' }
      ]},
      {Name: 'Roles', Description: 'Description for Roles', matIcon: 'cached', pages: [
        {Url: './home', Name: 'Roles' }
      ]}
    ];
    openMenu = false;
  constructor() {
  }

  ngOnInit() {
  }
  test () {
    this.openMenu = true;
  }
}
