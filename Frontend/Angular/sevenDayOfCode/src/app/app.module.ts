import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';

import { MascoteModule } from './pages/mascote/mascote.module';
import { PokeService } from './providers/backend-client-provider';
import { HeaderComponent } from './common/header/header.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MascoteModule,
    HttpClientModule
  ],
  providers: [PokeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
