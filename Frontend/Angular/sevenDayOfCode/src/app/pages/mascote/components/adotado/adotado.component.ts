import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { firstValueFrom, Subscription } from 'rxjs';
import { AnimalStatus, IAnimalStatus, PokeService } from 'src/app/providers/backend-client-provider';

@Component({
  selector: 'app-adotado',
  templateUrl: './adotado.component.html',
  styleUrls: ['./adotado.component.scss']
})
export class AdotadoComponent implements OnInit {
  
  @Input() adopted : IAnimalStatus = {}
  
  subscription : Subscription = new Subscription
  mascoteId: number = 0;
  
  constructor(
    private readonly route : ActivatedRoute,
    private readonly pokemonService : PokeService ) { }
  
  ngOnInit(): void {
    this.route.params.subscribe((value) => this.mascoteId = value['id'])
  }
  
  async Play() {
    try {
      this.adopted = await firstValueFrom(this.pokemonService.apiInteractPlay(new AnimalStatus(this.adopted)))
    } catch (error) {
      console.error(error);
      alert(error);
    }
  }
  async Rest() {
    try {
      this.adopted = await firstValueFrom(this.pokemonService.apiInteractRest(new AnimalStatus(this.adopted)))
    } catch (error) {
      console.error(error);
      alert(error);
    }
  }
  async Feed() {
    try {
      this.adopted = await firstValueFrom(this.pokemonService.apiInteractFeed(new AnimalStatus(this.adopted)))
    } catch (error) {
      console.error(error);
      alert(error);
    }
  }

}
