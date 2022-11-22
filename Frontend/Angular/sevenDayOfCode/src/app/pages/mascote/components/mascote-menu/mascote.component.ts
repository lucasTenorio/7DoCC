import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { firstValueFrom } from 'rxjs';
import { IPokedex, IPokemonStatus, PokeService } from 'src/app/providers/backend-client-provider';

@Component({
  selector: 'app-mascote',
  templateUrl: './mascote.component.html',
  styleUrls: ['./mascote.component.scss']
})
export class MascoteComponent implements OnInit {

  pokeList : IPokedex = {}

  pokeDetails : IPokemonStatus = {}

  constructor(
    private readonly pokedexService : PokeService) { }

  async ngOnInit(): Promise<void> {
    this.pokeList = await firstValueFrom(this.pokedexService.apiPoke())
  }


}
