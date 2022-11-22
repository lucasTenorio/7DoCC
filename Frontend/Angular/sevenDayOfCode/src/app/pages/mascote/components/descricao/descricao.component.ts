import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { firstValueFrom, Subscription } from 'rxjs';
import { IPokemonStatus,  PokeService } from 'src/app/providers/backend-client-provider';

@Component({
  selector: 'app-descricao',
  templateUrl: './descricao.component.html',
  styleUrls: ['./descricao.component.scss']
})
export class DescricaoComponent implements OnInit, OnDestroy {

  pokeDetails : IPokemonStatus = {}
  currentId : number = 0
  
  private subscription: Subscription = new Subscription;
  constructor(
    private readonly pokedexService : PokeService,
    private readonly  navData : ActivatedRoute,
    private readonly toastService : ToastrService
    ) {}
    
  ngOnInit(): void {
    this.subscription = this.navData.params.subscribe((value) => this.currentId = value['id'])
    this.loadDescription(this.currentId)
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
  }

  async loadDescription(filter : number | undefined){
    if(!filter) return;
    try
    {
      this.pokeDetails = await firstValueFrom(this.pokedexService.apiPokemonDescription(filter))
    }
    catch(error)
    {
      console.error(error)
    }
  }

  adotar(){
    localStorage.setItem("mascote", this.currentId.toString())
    if(!localStorage.getItem("mascote")){
      console.log("armazenado: ", localStorage.getItem("mascote"));
      return this.toastService.info("Novo mascote Selecionado com sucesso!")
    }
    console.log("armazenado: ", localStorage.getItem("mascote"));
    return this.toastService.info("Mascote selecionado com sucesso!")
  }

}
