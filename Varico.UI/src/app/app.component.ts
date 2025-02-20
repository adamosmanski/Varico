import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from './components/navbar/navbar.component';
import { AuthService } from './services/auth-service.service';
import { SidebarComponent } from './components/sidebar/sidebar.component'; 
import { CommonModule } from '@angular/common';
import { Observable } from 'rxjs';
import { HomeComponent } from "./components/home/home.component";

import { ReservationComponent } from "./components/reservation/reservation.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, NavbarComponent, SidebarComponent, CommonModule, HomeComponent,ReservationComponent],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  isLoggedIn$: Observable<boolean>;

  constructor(private authService: AuthService) {
    this.isLoggedIn$ = this.authService.isLoggedIn$;
  }
}
