import { Component, OnInit } from '@angular/core';
import { User } from '../models/user';
import { Form } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  model = new User();
  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  submit(form: Form) {
    console.log('Submitted');
    console.log(this.model);
    console.log(form);

    this.http.post('/api/auth/login', this.model).subscribe(status => console.log(JSON.stringify(status)));
  }

}
