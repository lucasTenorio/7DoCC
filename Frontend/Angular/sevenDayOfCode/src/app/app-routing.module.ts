import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { DescricaoComponent } from './pages/mascote/components/descricao/descricao.component';
import { MascoteComponent } from './pages/mascote/components/mascote-menu/mascote.component';

const routes: Routes = [
  { path : '', redirectTo: '/home', pathMatch:"full"},
  { path : 'home', component : HomeComponent,
    children : [
      {path : 'mascotes-disponiveis', component : MascoteComponent},
      {path : 'mascotes-disponiveis/descricao/:id', component : DescricaoComponent}
    ]},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

 }
