import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from './components/navbar/navbar.component';
import { AuthService } from './services/auth-service.service';
import { SidebarComponent } from './components/sidebar/sidebar.component'; 
import { CommonModule } from '@angular/common';
import { Observable } from 'rxjs';
import { HomeComponent } from "./components/home/home.component";
import { ReservationComponent } from "./components/reservation/reservation.component";
import { SignalRService } from './services/signal-r.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, NavbarComponent, SidebarComponent, CommonModule, HomeComponent, ReservationComponent],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  isLoggedIn$: Observable<boolean>;

  constructor(private authService: AuthService, private signalRService: SignalRService) {
    this.isLoggedIn$ = this.authService.isLoggedIn$;
  }

  ngOnInit(): void {
    this.authService.isLoggedIn$.subscribe(isLoggedIn => {if (isLoggedIn) {
      this.signalRService.startConnection();
      this.signalRService.listenForReservationAlerts((message) => {       
        alert(message);
      });
    }
  });
}
}