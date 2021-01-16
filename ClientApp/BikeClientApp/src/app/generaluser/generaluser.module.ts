import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GeneraluserRoutingModule } from './generaluser-routing.module';
import { GeneraluserComponent } from './generaluser.component';


@NgModule({
  declarations: [GeneraluserComponent],
  imports: [
    CommonModule,
    GeneraluserRoutingModule
  ],
  exports:[GeneraluserComponent]
})
export class GeneraluserModule { }
