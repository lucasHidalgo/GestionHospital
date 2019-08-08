import { HomeComponent } from './home/home.component';
import { UsersComponent } from './users/Users.component';
import { Routes } from '@angular/router';

const routes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    children: [
      {path: 'users', component: UsersComponent}
    ]
  },
  {path: '**', redirectTo: '', pathMatch: 'full'}
];

export const AppRoutes: Routes = routes;
