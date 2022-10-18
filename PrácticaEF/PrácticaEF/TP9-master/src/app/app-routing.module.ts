import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home/home.component';
import { SuppliersComponent } from './suppliers/suppliers/suppliers.component';

const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: '',
    redirectTo:'home',
    pathMatch:'full',
  },
  {
    path: 'suppliers',
    component: SuppliersComponent
  },
  {
    path: '**',
    redirectTo:'home',
    pathMatch:'full',
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
