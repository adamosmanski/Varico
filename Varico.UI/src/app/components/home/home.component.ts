import { Component, OnInit, ChangeDetectorRef  } from '@angular/core';
import { VehicleService } from '../../services/vehicle-service.service';
import { Vehicle } from '../../models/vehicle.model';
import { AuthService } from '../../services/auth-service.service';
import { MatDialog } from '@angular/material/dialog';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  imports:[FormsModule,CommonModule],
  standalone:true
})
export class HomeComponent implements OnInit {
  vehicles: Vehicle[] = [];
  isLoggedIn: boolean = false;
  selectedVehicle: Vehicle | null = null;
  searchCriteria: any = {};
  reservedFrom: Date | null = null;
  reservedTo: Date | null = null;
  invalidDateRange: boolean = false;
  currentRoute: string = '';

  constructor(
    private vehicleService: VehicleService,
    private authService: AuthService,
    private dialog: MatDialog ,
    private cdr: ChangeDetectorRef,
    private activatedRoute: ActivatedRoute
  ) {}
  getVehicleTypeName(type: number | string): string {
    const mapping: Record<string | number, string> = {
      0: 'Samochód osobowy',
      1: 'Ciężarówka',
      2: 'Motocykl',
      Passenger: 'Samochód osobowy',
      Truck: 'Ciężarówka',
      Motorcycle: 'Motocykl'
    };
    return mapping[type] ?? type.toString();
  }
  
  getBodyTypeName(type: number | string): string {
    const mapping: Record<string | number, string> = {
      0: 'SUV',
      1: 'Hatchback',
      2: 'Sedan',
      3: 'Kombi',
      4: 'Inny',
      SUV: 'SUV',
      HATCHBACK: 'Hatchback',
      SEDAN: 'Sedan',
      KOMBI: 'Kombi',
      ANOTHER: 'Inny'
    };
    return mapping[type] ?? type.toString();
  }
  
  getTransmissionTypeName(type: number | string): string {
    const mapping: Record<string | number, string> = {
      0: 'Manualna',
      1: 'Automatyczna',
      Manual: 'Manualna',
      Automatic: 'Automatyczna'
    };
    return mapping[type] ?? type.toString();
  }
  
  getFuelTypeName(type: number | string): string {
    const mapping: Record<string | number, string> = {
      0: 'Benzyna',
      1: 'Diesel',
      2: 'Elektryczny',
      3: 'Hybrydowy',
      4: 'Gaz',
      Petrol: 'Benzyna',
      Diesel: 'Diesel',
      Electric: 'Elektryczny',
      Hybrid: 'Hybrydowy',
      Gas: 'Gaz'
    };
    return mapping[type] ?? type.toString();
  }
  
  getDrivetrainTypeName(type: number | string): string {
    const mapping: Record<string | number, string> = {
      0: 'Napęd na przednie koła',
      1: 'Napęd na tylne koła',
      2: 'Napęd na wszystkie koła (4x4)',
      FWD: 'Napęd na przednie koła',
      RWD: 'Napęd na tylne koła',
      AWD: 'Napęd na wszystkie koła (4x4)'
    };
    return mapping[type] ?? type.toString();
  }
  
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
    this.vehicleService.searchVehicles(this.searchCriteria.brand).subscribe({
      next: (data) => {
        this.vehicles = data;
      },
      error: (err) => {
        console.error('Błąd podczas wyszukiwania pojazdów:', err);
      }
    });
  }

  viewDetails(vehicle: Vehicle): void {
    console.log(vehicle + '   -2');
    this.selectedVehicle = vehicle;
    if (!this.selectedVehicle) {
      console.error("Błąd: Pojazd nie został wybrany.");
    }
  }

  closeDetails(): void {
    this.selectedVehicle = null;
  }

  validateDates() {
    if (this.reservedFrom && this.reservedTo) {
      this.invalidDateRange = new Date(this.reservedFrom) > new Date(this.reservedTo);
    } else {
      this.invalidDateRange = false;
    }
  }


  reserveVehicle(vehicle: Vehicle): void {
    if (!this.reservedFrom || !this.reservedTo) {
      console.log('Wybierz daty rezerwacji.');
      return;
    }    
    const startDate = new Date(this.reservedFrom);
    const endDate = new Date(this.reservedTo);
    const userId = this.authService.getUserId();
  
    if (userId === null) {
      console.error('Błąd: Użytkownik nie jest zalogowany.');
      return;
    }
  
    if (!vehicle.availability) {
      console.log('Pojazd jest już zarezerwowany.');
      return;
    }

    this.vehicleService.reserveVehicle(vehicle.id, this.reservedFrom, this.reservedTo, userId)
      .subscribe(
        (response) => {
          vehicle.availability = false;
          vehicle.reservedFrom = startDate;
          vehicle.reservedTo = endDate;
          vehicle.reservedById = userId;
  
          console.log(`Pojazd ${vehicle.brand} ${vehicle.model} zarezerwowany od ${this.reservedFrom} do ${this.reservedTo}.`);
  
          this.vehicles = this.vehicles.filter(v => v.id !== vehicle.id);
          this.cdr.detectChanges();
        },
        (error) => {
          console.error('Błąd rezerwacji pojazdu:', error);
        }
      );
  }
}  