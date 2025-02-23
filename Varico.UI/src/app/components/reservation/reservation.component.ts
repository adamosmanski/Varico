import { Component, OnInit } from '@angular/core';
import { VehicleService } from '../../services/vehicle-service.service';
import { Vehicle } from '../../models/vehicle.model';
import { CommonModule } from '@angular/common'; 

@Component({
  selector: 'app-reservation',
  templateUrl: './reservation.component.html',
  styleUrls: ['./reservation.component.css'],
  imports: [CommonModule]
})
export class ReservationComponent implements OnInit {
  reservedVehicles: Vehicle[] = [];
  selectedVehicle: Vehicle | null = null;

  constructor(private vehicleService: VehicleService) {}

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
    this.loadReservedVehicles();
  }

  loadReservedVehicles(): void {
    this.vehicleService.getReservedVehicles().subscribe({
      next: (data) => this.reservedVehicles = data,
      error: (err) => console.error('Błąd pobierania pojazdów:', err)
    });
  }
  viewDetails(vehicle: Vehicle): void {
    console.log(vehicle + '   -3');
    this.selectedVehicle = vehicle;
    if (!this.selectedVehicle) {
      console.error("Błąd: Pojazd nie został wybrany.");
    }
  }
  closeDetails(): void {
    this.selectedVehicle = null;
  }

  isNearReturnDate(reservedTo: string | Date): boolean {
    const today = new Date();
    const returnDate = new Date(reservedTo);
    const diffInDays = Math.ceil((returnDate.getTime() - today.getTime()) / (1000 * 60 * 60 * 24));
  
    return diffInDays <= 3;
  }

  returnVehicle(vehicleId: number): void {
    this.vehicleService.returnReservedVehicles(vehicleId).subscribe({
      next: () => {
        this.reservedVehicles = this.reservedVehicles.filter(v => v.id !== vehicleId);
        this.selectedVehicle = null;
      },
      error: (err) => {
        console.error('Błąd podczas zwracania pojazdu:', err);
      }
    });
  }

  extendReservation(vehicleId: number): void {
    this.vehicleService.extendSelectedReservation(vehicleId).subscribe({
      next: () => {
        this.selectedVehicle = null;
      },
      error: (err) => {
        console.error("Błąd:", err);
      }
    });
  }
}
