import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminguradGuard } from './admingurad.guard';
import { GeneraluserGuardGuard } from './generaluser-guard.guard';

const routes: Routes = [
  {
    path: 'login',
    loadChildren: () =>
      import('./login/login.module').then((m) => m.LoginModule),
  },
  {
    path: 'admin',
    loadChildren: () =>
      import('./admin/admin.module').then((m) => m.AdminModule),
    canActivate:[AdminguradGuard]
  },
  {
    path: 'generaluser',
    loadChildren: () =>
      import('./generaluser/generaluser.module').then(
        (m) => m.GeneraluserModule
      ),
      canActivate:[GeneraluserGuardGuard]
  },
  {
    path: '',
    redirectTo:'login',
    pathMatch:'full'
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
