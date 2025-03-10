import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private isLoggedInSubject = new BehaviorSubject<boolean>(false);
  private userId: number | null = null;
  isLoggedIn$ = this.isLoggedInSubject.asObservable();

  setUserId(id: number): void {
    this.userId = id;
  }
  getUserId(): number | null {
    return this.userId;
  }
  login() {
    this.isLoggedInSubject.next(true);
  }

  logout() {
    this.isLoggedInSubject.next(false);
  }
  
}


