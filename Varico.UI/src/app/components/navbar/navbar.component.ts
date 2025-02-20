import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { RegisterDialogComponent } from '../register-dialog/register-dialog.component';

@Component({
  selector: 'app-navbar',
  standalone: true,
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
  imports: [MatToolbarModule, MatButtonModule]
})
export class NavbarComponent {
  constructor(private dialog: MatDialog) {}

  openRegisterDialog() {
    this.dialog.open(RegisterDialogComponent, {
      width: '600px',
      disableClose: true
    });
  }
}
