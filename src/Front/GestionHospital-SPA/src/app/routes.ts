import { HomeComponent } from './home/home.component';
import { UsersListComponent } from './users/users-list/users-list.component';
import { Routes } from '@angular/router';
import { UserEditComponent } from './users/user-edit/user-edit.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    children: [
      {path: 'users', component: UsersListComponent},
      {path: 'NewUser', component: UserEditComponent}
    ]
  },
  {path: '**', redirectTo: '', pathMatch: 'full'}
];

export const AppRoutes: Routes = routes;
