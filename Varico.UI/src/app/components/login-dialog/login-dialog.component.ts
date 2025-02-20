import { Component, inject, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule, AbstractControl, ValidationErrors } from '@angular/forms';
import { UserService } from '../../services/user.service';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { AuthService } from '../../services/auth-service.service';
@Component({
  selector: 'app-login-dialog',
  templateUrl: './login-dialog.component.html',
  styleUrl: './login-dialog.component.css',
  standalone: true,
  imports: [ 
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule
  ]
})


export class LoginDialogComponent {
  loginForm: FormGroup;
  hidePassword = true;
  errorMessage: string = '';
  constructor(private fb: FormBuilder,
    private dialogRef: MatDialogRef<LoginDialogComponent>,
    private userService: UserService,
    private authService: AuthService,
  ) {
    this.loginForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6)]]
    });
  }
  onLogin() {
    if (this.loginForm.valid) {
      const { email, password } = this.loginForm.value;
  
      this.userService.login(email, password).subscribe({
        next: (response) => {
          console.log('Zalogowano:', response);
  
          if (response.userId) {
            const userId = response.userId;
            this.authService.setUserId(userId);
            this.dialogRef.close(response);
          } else {
            console.error('Błąd: Brak userId w odpowiedzi');
          }
        },
        error: (error) => {
          this.errorMessage = error.error.message || 'Błąd logowania';
        }
      });
    }
  }

  close() {
    this.dialogRef.close();
  }
}