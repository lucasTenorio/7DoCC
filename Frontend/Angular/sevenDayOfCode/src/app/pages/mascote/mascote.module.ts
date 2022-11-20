import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EspeciesComponent } from './components/especies/especies.component';
import { DescricaoComponent } from './components/descricao/descricao.component';
import { MascoteComponent } from './components/mascote-menu/mascote.component';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from 'src/app/app-routing.module';
import { AdotadoComponent } from './components/adotado/adotado.component';

@NgModule({
  declarations: [
    EspeciesComponent,
    DescricaoComponent,
    MascoteComponent,
    AdotadoComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    AppRoutingModule
  ]
})
export class MascoteModule { }
