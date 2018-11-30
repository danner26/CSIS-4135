import { MatIconModule, MatSidenavModule, MatListModule, MatButtonModule, MatCheckboxModule, MatFormFieldModule, MatInputModule, MatMenuModule, MatCardModule  } from '@angular/material';
import { MatToolbarModule } from '@angular/material/toolbar';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


import { NgModule } from '@angular/core';

@NgModule({
  imports: [BrowserModule, BrowserAnimationsModule, MatIconModule, MatSidenavModule, MatListModule, MatButtonModule, MatCheckboxModule, MatToolbarModule, MatFormFieldModule, MatInputModule, MatMenuModule, MatCardModule ],
  exports: [BrowserModule, BrowserAnimationsModule, MatIconModule, MatSidenavModule, MatListModule, MatButtonModule, MatCheckboxModule, MatToolbarModule, MatFormFieldModule, MatInputModule, MatMenuModule, MatCardModule ],
})

export class MaterialModule { }
