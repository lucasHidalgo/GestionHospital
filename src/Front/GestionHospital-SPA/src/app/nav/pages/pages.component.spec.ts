/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By, BrowserModule } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PagesComponent } from './pages.component';
import { RouterTestingModule } from '@angular/router/testing';
import { AppRoutingModule } from 'src/app/app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from 'src/app/material-module';
import { MatNativeDateModule } from '@angular/material/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { AppRoutes } from 'src/app/routes';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from 'src/app/app.component';
import { UsersListComponent } from 'src/app/users/users-list/users-list.component';
import { UserEditComponent } from 'src/app/users/user-edit/user-edit.component';
import { SidenavComponent } from '../sidenav/sidenav.component';
import { HomeComponent } from 'src/app/home/home.component';

describe('PagesComponent', () => {
  let component: PagesComponent;
  let fixture: ComponentFixture<PagesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [
        RouterTestingModule,
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
      declarations: [
        PagesComponent
      ],
    }).compileComponents();
  }));


  beforeEach(() => {
    fixture = TestBed.createComponent(PagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  it('should set one', () => {
    expect(component.openMenu).toBe(false);
  });
});
