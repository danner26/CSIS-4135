import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroupDirective, NgForm, Validators, Form } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';

import { User } from '../models/user';
import { AuthService } from '../services/auth.service';

/** Error when invalid control is dirty, touched, or submitted. */
export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}

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

  matcher = new MyErrorStateMatcher();

  submit(form: Form) {
    console.log('Submitted');

    console.log(this.model)
    console.log(form);
    if (this.model['password'] == this.model['confpassword']) {
      console.log("passwords match");
      //this.authService.register(this.model.username, this.model.password).subscribe(user => console.log(user));
    } else {
      console.log("passwords do not match");
    }
  }
}
