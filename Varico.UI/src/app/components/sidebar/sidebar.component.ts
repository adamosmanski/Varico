import { Component, ViewChild } from '@angular/core';
import { AuthService } from '../../services/auth-service.service';
import { MatSidenav } from '@angular/material/sidenav';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';  
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css'],
  standalone: true,
  imports: [CommonModule, MatSidenavModule, MatIconModule] 
})
export class SidebarComponent {
  isLoggedIn = false;

  @ViewChild('sidenav') sidenav: MatSidenav | undefined; 

  constructor(private authService: AuthService) {
    this.authService.isLoggedIn$.subscribe((status) => {
      console.log(status);
      this.isLoggedIn = status;
      console.log(this.isLoggedIn);
    });
  }
}
