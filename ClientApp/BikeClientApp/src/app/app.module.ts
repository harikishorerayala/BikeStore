import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { LoginModule } from './login/login.module';
import { AdminModule } from './admin/admin.module';
import { GeneraluserModule } from './generaluser/generaluser.module';



@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule,
    LoginModule,
    AdminModule,
    GeneraluserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
