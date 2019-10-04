import { PagesComponent } from './nav/pages/pages.component';
import { HomeComponent } from './home/home.component';
import { SidenavComponent } from './nav/sidenav/sidenav.component';
import { UserEditComponent } from './users/user-edit/user-edit.component';
import { UsersListComponent } from './users/users-list/users-list.component';
import { MaterialModule } from './material-module';
import { TestBed, async } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatNativeDateModule } from '@angular/material/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { AppRoutes } from './routes';

describe('AppComponent', () => {
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
        AppComponent,
        UsersListComponent,
        UserEditComponent,
        SidenavComponent,
        HomeComponent,
        PagesComponent
      ],
    }).compileComponents();
  }));

  it('should create the app', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  });
});
