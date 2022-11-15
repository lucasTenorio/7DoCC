import { Component, OnInit } from '@angular/core';
import { firstValueFrom } from 'rxjs';
import { IPokedex, PokeService } from 'src/app/providers/backend-client-provider';

@Component({
  selector: 'app-mascote',
  templateUrl: './mascote.component.html',
  styleUrls: ['./mascote.component.scss']
})
export class MascoteComponent implements OnInit {

  pokeList : IPokedex = {}

  constructor(private readonly pokedexService : PokeService) { }

  async ngOnInit(): Promise<void> {
    this.pokeList = await firstValueFrom(this.pokedexService.apiPoke())
  }

}
