import { Component } from '@angular/core';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { RegisterDialogComponent } from '../register-dialog/register-dialog.component';
import { LoginDialogComponent } from '../login-dialog/login-dialog.component';
import { AuthService } from '../../services/auth-service.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-navbar',
  standalone: true,
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
  imports: [MatToolbarModule, MatButtonModule, CommonModule, MatDialogModule]
})
export class NavbarComponent {
  isLoggedIn = false;
  constructor(private dialog: MatDialog, private authService: AuthService) {
    this.authService.isLoggedIn$.subscribe((status) => {
      this.isLoggedIn = status;
    });
  }

  openRegisterDialog() {
    this.dialog.open(RegisterDialogComponent, {
      width: '600px',
      disableClose: true
    });
  }
  openLoginDialog() {
    const dialogRef = this.dialog.open(LoginDialogComponent, {
      width: '600px',
      disableClose: true
    });

    dialogRef.afterClosed().subscribe((result) => {
      if (result) {
        this.authService.login();
      }
    });
  }


  logout() {
    this.authService.logout();
  }
}

