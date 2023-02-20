import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ItemService } from 'src/app/services/item.service';
import { Item } from 'src/app/data/item.model';
import { Provider } from 'src/app/data/provider.model';
import { WineType } from 'src/app/data/wineType.model';

@Component({
  selector: 'app-wine-card',
  templateUrl: './wine-card.component.html',
  styleUrls: ['./wine-card.component.scss']
})
export class WineCardComponent {

  //id:number;
  item: Item=<Item>{};
  provider: Provider=<Provider>{};
  wineType: WineType=<WineType>{};
  providerId: number;
  wineTypeId:number;
  constructor(private route: ActivatedRoute, private itemService: ItemService){}

  ngOnInit(): void {
    //this.id = this.route.snapshot.params['id'];
    //console.log(this.id);

    const id: number = +this.route.snapshot.paramMap.get('id');
      console.log(id);

      this.itemService.GetSingleItem(id).subscribe(resultat => {
        this.item = resultat;
        this.providerId = +this.item.providerId;
        this.wineTypeId = +this.item.wineTypeId;
        
        this.itemService.GetSingleProvider(this.providerId).subscribe(resultat => {
          this.provider = resultat;
          console.log(this.provider);
        });

        this.itemService.GetSingleWineType(this.wineTypeId).subscribe(resultat => {
          this.wineType = resultat;
          console.log(this.wineType);
        });
      });
     

  }

}
