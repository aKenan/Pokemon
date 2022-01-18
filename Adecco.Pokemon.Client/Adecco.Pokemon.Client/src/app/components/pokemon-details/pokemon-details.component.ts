import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ServicesService } from '../../providers/services.service';

@Component({
  selector: 'app-pokemon-details',
  templateUrl: './pokemon-details.component.html',
  styleUrls: ['./pokemon-details.component.css']
})
export class PokemonDetailsComponent implements OnInit {
  name: any = '';
  details : any = {};
  constructor(private activatedRoute: ActivatedRoute, private service: ServicesService) { }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe((map) => {
      this.name = map.get('name');

      this.service.getPokemonDetails(this.name)
      .subscribe((x)=>{
        this.details = x;
      })
    });

    
  }

}
