import { UserService } from './../../_services/user.service';
import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/_models/user';

@Component({
  selector: 'app-user-edit',
  templateUrl: './user-edit.component.html',
  styleUrls: ['./user-edit.component.css']
})
export class UserEditComponent implements OnInit {
  user: User = new User();

  constructor(private userService: UserService) {}

  ngOnInit() {}

  createNewUser() {
    this.userService.createNewUser(this.user).subscribe(() => {
      console.log('success');
    }, error => console.log(error));
  }
}
