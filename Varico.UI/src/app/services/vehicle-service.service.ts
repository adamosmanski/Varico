import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Vehicle } from '../models/vehicle.model';
import { AuthService } from './auth-service.service';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {
  private apiUrl = 'https://localhost:7016/api/Vehicles';

  constructor(private http: HttpClient,
    private authService: AuthService
  ) {}

  searchVehicles(brand: string): Observable<Vehicle[]> {
    return this.http.get<Vehicle[]>(`${this.apiUrl}/search?brand=${brand}`);
  }

  getVehicles(): Observable<Vehicle[]> {
    return this.http.get<Vehicle[]>(`${this.apiUrl}/getAllVehicles`);
  }

  
  reserveVehicle(vehicleId: number, reservedFrom: Date, reservedTo: Date, userId: number): Observable<any> {
    const reservationData = {
      vehicleId: vehicleId,
      reservedFrom: reservedFrom,
      reservedTo: reservedTo,
      userId: userId
    };
    return this.http.post(`${this.apiUrl}/reserveVehicle`, reservationData);
  }

  getReservedVehicles(): Observable<Vehicle[]> {
    const userId = this.authService.getUserId();
    console.log(userId);
  
    if (userId === null) {
      throw new Error('User is not logged in');
    }
  
    return this.http.get<any[]>(`${this.apiUrl}/reserved?userId=${userId}`).pipe(
      map((vehicles) => vehicles.map(vehicle => ({
        ...vehicle,
        reservedFrom: vehicle.dateStart ? new Date(vehicle.dateStart) : null,
        reservedTo: vehicle.dateEnd ? new Date(vehicle.dateEnd) : null
      })))
    );
  }
  returnReservedVehicles(vehicleId: number): Observable<void> {
    return this.http.patch<void>(`${this.apiUrl}/returnReservedVehicle`, { vehicleId });
  }

  extendSelectedReservation(vehicleId: number): Observable<any> {
    return this.http.post(`${this.apiUrl}/extend/${vehicleId}`, {});
  }
}