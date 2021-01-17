import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders, HttpParams }  from '@angular/common/http';
import { Ttype } from '../ModelTypes/ttype';
import { Observable, throwError, of } from 'rxjs';
import { catchError, retry, delay, map } from 'rxjs/operators';
import 'rxjs/add/observable/of';
import 'rxjs/add/operator/delay';
import 'rxjs/add/operator/map';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationsvcService {
  private token="";

  constructor(private httpClient:HttpClient)
  {

  }
  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.error.message);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong.
      console.error(
        `Backend returned code ${error.status}, ` +
        `body was: ${error.error}`);
    }
    // Return an observable with a user-facing error message.
    return throwError(
      'Something bad happened; please try again later.');
  }

  generateToken(un:string,pwd:string):Observable<Ttype>
  {
    const url=`http://localhost:51054/token`;
    const body= `username=${un}&password=${pwd}&grant_type=password`;
    let headers=new HttpHeaders({
      'Content-Type' : 'application/x-www-form-urlencoded'
    });

    return  this.httpClient
    .post<Ttype>(url,body,{headers:headers})
    .pipe(
      catchError(this.handleError)
    )
  }
}
