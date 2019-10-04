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
  
  createNewUser(user: User) {
    console.log(this.baseUrl + 'Users/CreateNewUser');
    return this.http.post(this.baseUrl + 'Users/CreateNewUser', user);
  }
  getDoctors() {
    return this.http.get<User[]>(this.baseUrl + 'Users/Doctors');
  }

  getPatients() {
    return this.http.get<User[]>(this.baseUrl + 'Users/Patients');
  }

  editUser(id: number) {

  }
}
