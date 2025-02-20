import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private apiUrl = 'https://localhost:7016/api/Users';

  constructor(private http: HttpClient) {}

  registerUser(userData: any): Observable<any> {
    console.log("Sending request to:", `${this.apiUrl}/register`); 
    return this.http.post(`${this.apiUrl}/register`, userData);
  }
}
