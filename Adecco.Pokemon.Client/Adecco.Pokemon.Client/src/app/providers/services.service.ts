import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from "rxjs";
import { PokemonPaginated } from "../models/pokemon";
import { Config } from "./config";

@Injectable({
  providedIn: 'root'
})
export class ServicesService {
    constructor(private http: HttpClient) { }

    get baseUri() {
      return `${Config.api}`;
    }

    getAllPokemons(pageSize : number, pageNumber : number) {
      return this.http.get(`${this.baseUri}/Pokemons?pageSize=${pageSize}&pageNumber=${pageNumber}`).pipe((map(x => <PokemonPaginated>x)));
    }

    getPokemonDetails(name: string){
      return this.http.get(`${this.baseUri}/Pokemons/${name}`).pipe((map(x => <any>x)));
    }
}
