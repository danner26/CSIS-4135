import { Component, OnInit } from '@angular/core';
import { User } from '../models/user';
import { Form, FormsModule } from '@angular/forms';
import { AuthService } from '../services/auth.service';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model = new User();
  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  submit(form: Form) {
    console.log('Submitted');

    console.log(this.model)
    console.log(form);
    if (this.model['password'] == this.model['confpassword']) {
      console.log("passwords match");
      alert("Success! Passwords match");
      //this.authService.register(this.model.username, this.model.password).subscribe(user => console.log(user));
    } else {
      console.log("passwords do not match");
      alert("Error! Passwords do not match");
    }
  }
}
