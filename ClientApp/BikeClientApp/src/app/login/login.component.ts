import { Component, OnInit } from '@angular/core';
import { AuthenticationsvcService } from './authenticationsvc.service';
import {
  FormControl,
  FormBuilder,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Ttype } from '../ModelTypes/ttype';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass'],
})
export class LoginComponent implements OnInit {
  loginform: FormGroup;
  username = ``;
  token!: Ttype;
  constructor(
    private authsvc: AuthenticationsvcService,
    private formBuilder: FormBuilder
  ) {
    this.loginform = formBuilder.group({
      txtUserName: new FormControl('', Validators.required),
      txtPassword: new FormControl('', Validators.required),
    });
  }

  ngOnInit(): void {

  }

  doLogin() {
    this.authsvc
      .generateToken(
        this.loginform.value.txtUserName,
        this.loginform.value.txtPassword
      )
      .subscribe(
        data => {
            console.log("data came"+data);
        //this.token=data;
        // this.username = this.loginform.value.txtUserName;
        // this.StoreToken(data, this.username);
      },
      error=>{
        console.log(error);
      }
      );
  }

  StoreToken(token: any, un: string) {
    sessionStorage.setItem('token' + this.username, token);
  }

  RetrieveToken(un: string) {
    sessionStorage.getItem('token' + this.username);
  }

  DeleteToken(un: string) {
    sessionStorage.removeItem('token' + this.username);
  }
}
