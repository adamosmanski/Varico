import { Component, OnInit, ChangeDetectorRef  } from '@angular/core';
import { VehicleService } from '../../services/vehicle-service.service';
import { Vehicle } from '../../models/vehicle.model';
import { AuthService } from '../../services/auth-service.service';
import { MatDialog } from '@angular/material/dialog';
import { LoginDialogComponent } from '../login-dialog/login-dialog.component';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  imports:[FormsModule,CommonModule,]
})
export class HomeComponent implements OnInit {
  vehicles: Vehicle[] = [];
  isLoggedIn: boolean = false;
  searchCriteria: any = {};

  constructor(
    private vehicleService: VehicleService,
    private authService: AuthService,
    private dialog: MatDialog ,
    private cdr: ChangeDetectorRef
  ) {}

  ngOnInit(): void {
    this.loadVehicles();
    this.authService.isLoggedIn$.subscribe((loggedInStatus) => {
      this.isLoggedIn = loggedInStatus;
    });
  }
  private loadVehicles(): void {
    this.vehicleService.getVehicles().subscribe({
      next: (data) => this.vehicles = data,
      error: (err) => console.error('Błąd pobierania pojazdów:', err)
    });
  }
  searchVehicles(): void {
    console.log(this.searchCriteria);
  }
  viewDetails(vehicle: any) {
    console.log('Szczegóły pojazdu:', vehicle);
  }


  
}
