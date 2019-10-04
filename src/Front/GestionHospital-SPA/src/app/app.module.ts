import { AppRoutes } from './routes';
import { MaterialModule } from './material-module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatNativeDateModule} from '@angular/material/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HttpClientModule} from "@angular/common/http";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UsersListComponent } from './users/users-list/users-list.component';
import { SidenavComponent } from './nav/sidenav/sidenav.component';
import { HomeComponent } from './home/home.component';
import { UserEditComponent } from './users/user-edit/user-edit.component';
import { PagesComponent } from './nav/pages/pages.component';


@NgModule({
   declarations: [
      AppComponent,
      UsersListComponent,
      UserEditComponent,
      SidenavComponent,
      HomeComponent,
      PagesComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      BrowserAnimationsModule,
      MaterialModule,
      MatNativeDateModule,
      FormsModule,
      ReactiveFormsModule,
      RouterModule.forRoot(AppRoutes),
      HttpClientModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
