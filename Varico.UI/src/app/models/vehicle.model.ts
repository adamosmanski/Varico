export interface Vehicle {
  id: number;
  brand: string;
  model: string;
  productionYear: number;
  vehicleType: 'Sedan' | 'SUV' | 'Hatchback' | 'Coupe' | 'Convertible';
  bodyType: 'Sedan' | 'SUV' | 'Hatchback' | 'Coupe' | 'Convertible';
  availability: boolean;
  reservedById?: number | null;
  reservedBy?: string | null;
  pictureURL: string;
  mileage: number;
  transmission: 'Manual' | 'Automatic' | 'Semi-Automatic';  
  engineCapacity: number;
  price: number;
  fuelType: 'Petrol' | 'Diesel' | 'Electric' | 'Hybrid';
  drivetrain: 'Front-Wheel' | 'Rear-Wheel' | 'All-Wheel';
  acceleration: number;
  trunkCapacity: number;
  maxSpeed: number;
  reservedFrom: Date;
  reservedTo: Date;
}

export enum VehicleType {
  Sedan = 'Sedan',
  SUV = 'SUV',
  Hatchback = 'Hatchback',
  Coupe = 'Coupe',
  Convertible = 'Convertible',
}

export enum BodyType {
  Sedan = 'Sedan',
  SUV = 'SUV',
  Hatchback = 'Hatchback',
  Coupe = 'Coupe',
  Convertible = 'Convertible',
}

export enum TransmissionType {
  Manual = 'Manual',
  Automatic = 'Automatic',
  SemiAutomatic = 'Semi-Automatic',
}

export enum FuelType {
  Petrol = 'Petrol',
  Diesel = 'Diesel',
  Electric = 'Electric',
  Hybrid = 'Hybrid',
}

export enum DrivetrainType {
  FrontWheel = 'Front-Wheel',
  RearWheel = 'Rear-Wheel',
  AllWheel = 'All-Wheel',
}

