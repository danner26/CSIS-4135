import { MatButtonModule, MatCheckboxModule, MatFormFieldModule, MatInputModule, MatMenuModule } from '@angular/material';
import { MatToolbarModule } from '@angular/material/toolbar';
import { NgModule } from '@angular/core';

@NgModule({
  imports: [MatButtonModule, MatCheckboxModule, MatToolbarModule, MatFormFieldModule, MatInputModule, MatMenuModule],
  exports: [MatButtonModule, MatCheckboxModule, MatToolbarModule, MatFormFieldModule, MatInputModule, MatMenuModule],
})

export class MaterialModule { }
