import { Component, ViewChild, OnDestroy } from '@angular/core';
import { AuthService } from '../../services/auth-service.service';
import { MatSidenav } from '@angular/material/sidenav';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';  
import { CommonModule } from '@angular/common';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css'],
  standalone: true,
  imports: [CommonModule, MatSidenavModule, MatIconModule] 
})
export class SidebarComponent implements OnDestroy {
  isLoggedIn = false;
  private destroy$ = new Subject<void>();

  @ViewChild('sidenav') sidenav: MatSidenav | undefined; 

  constructor(private authService: AuthService) {
    this.authService.isLoggedIn$.pipe(takeUntil(this.destroy$)).subscribe((status) => {
      this.isLoggedIn = status;
    });
  }

  ngOnDestroy(): void {
    this.destroy$.next();
    this.destroy$.complete(); 
  }
}
