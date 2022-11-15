import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { MascoteComponent } from './pages/mascote/components/mascote-menu/mascote.component';

const routes: Routes = [
  { path : '', component : HomeComponent},
  { path : 'mascote', component : MascoteComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

 }
