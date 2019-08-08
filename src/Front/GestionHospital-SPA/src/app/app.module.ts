import { AppRoutes } from './routes';
import { DemoMaterialModule } from './material-module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatNativeDateModule} from '@angular/material/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { RouterModule } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UsersComponent } from './users/Users.component';
import { SidenavComponent } from './sidenav/sidenav.component';
import { HomeComponent } from './home/home.component';


@NgModule({
   declarations: [
      AppComponent,
      UsersComponent,
      SidenavComponent,
      HomeComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      BrowserAnimationsModule,
      DemoMaterialModule,
      MatNativeDateModule,
      FormsModule,
      ReactiveFormsModule,
      RouterModule.forRoot(AppRoutes),
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
