import { Component, OnInit } from '@angular/core';
import { Item } from 'src/app/data/item.model';
import { WineType } from 'src/app/data/wineType.model';
import { Provider } from 'src/app/data/provider.model';
import { ItemService } from 'src/app/services/item.service';



@Component({
  selector: 'app-wine-list',
  templateUrl: './wine-list.component.html',
  styleUrls: ['./wine-list.component.scss']
})
export class WineListComponent implements OnInit{
  items: Item[]=[];
  wineTypes : WineType[] = [];
  providers : Provider[] = [];
  readonly allowedPageSizes = [5, 10, 'all'];
  readonly displayModes = [{ text: "Display Mode 'full'", value: 'full' }, { text: "Display Mode 'compact'", value: 'compact' }];
  displayMode = 'full';
  showPageSizeSelector = true;
  showInfo = true;
  showNavButtons = true;

  constructor(private itemService :ItemService){}

  ngOnInit(): void {
    this.itemService.GetItem().subscribe(resultat => {
      this.items = resultat;
    });

    this.itemService.GetWineType().subscribe(resultat => {
      this.wineTypes = resultat;
      console.log(this.wineTypes);
    });

    this.itemService.GetProvider().subscribe(resultat => {
      this.providers = resultat;
      console.log(this.providers);
    });
  }
}
