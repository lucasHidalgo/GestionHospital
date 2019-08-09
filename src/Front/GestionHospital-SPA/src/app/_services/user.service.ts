import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../_models/user';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  baseUrl: string = environment.apiUrl;
constructor(private http: HttpClient) { }
  getUsers() {

  }

  createNewUser(user: User) {
    console.log(this.baseUrl + 'Users/CreateNewUser');
    return this.http.post(this.baseUrl + 'Users/CreateNewUser', user);
  }

  editUser(id: number) {

  }
}
