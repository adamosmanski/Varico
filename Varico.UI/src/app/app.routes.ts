import { Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { ReservationComponent } from './components/reservation/reservation.component';

export const routes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'reservation', component: ReservationComponent},
    { path: '', redirectTo: '/home', pathMatch: 'full' } 
];
