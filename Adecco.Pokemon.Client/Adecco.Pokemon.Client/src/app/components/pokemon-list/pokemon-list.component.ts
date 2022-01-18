import { Component, OnInit } from '@angular/core';
import { PokemonPaginated, PokemonViewModel } from '../../models/pokemon';
import { ServicesService } from '../../providers/services.service';

@Component({
  selector: 'app-pokemon-list',
  templateUrl: './pokemon-list.component.html',
  styleUrls: ['./pokemon-list.component.css']
})

export class PokemonListComponent implements OnInit {
  pokemonPaginated : PokemonPaginated = {};
  pageNumber : number = 1;
  pageSize : number = 20;
  constructor(private service:ServicesService) { }

  ngOnInit(): void {
    this.getPokemons();
  }

  previous() : void{
    this.pageNumber -= 1;
    this.getPokemons();
  }

  next() : void{
    this.pageNumber += 1;
    this.getPokemons();
  }

  getPokemons(){
    this.service.getAllPokemons(this.pageSize, this.pageNumber).subscribe((x) =>{
      this.pokemonPaginated = x;
    })
  }
}
