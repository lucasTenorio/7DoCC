import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-adotado',
  templateUrl: './adotado.component.html',
  styleUrls: ['./adotado.component.scss']
})
export class AdotadoComponent implements OnInit {

  subscription : Subscription = new Subscription
  mascoteId: number = 0;

  constructor(private readonly  route : ActivatedRoute) { }

  ngOnInit(): void {
    this.route.params.subscribe((value) => this.mascoteId = value['id'])
  }

}
