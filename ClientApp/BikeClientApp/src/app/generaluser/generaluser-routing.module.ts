import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { GeneraluserComponent } from './generaluser.component';

const routes: Routes = [{ path: '', component: GeneraluserComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GeneraluserRoutingModule { }
