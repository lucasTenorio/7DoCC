import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EspeciesComponent } from './components/especies/especies.component';
import { DescricaoComponent } from './components/descricao/descricao.component';
import { MascoteComponent } from './components/mascote-menu/mascote.component';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    EspeciesComponent,
    DescricaoComponent,
    MascoteComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule
  ]
})
export class MascoteModule { }
