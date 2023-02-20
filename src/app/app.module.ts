import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DxDataGridModule,DxTextBoxModule,DxValidatorModule,DxButtonModule } from 'devextreme-angular';
import { ContactComponent } from './component/contact/contact.component'; 
import { HeaderComponent } from './component/header/header.component';
import { FooterComponent } from './component/footer/footer.component';
import { LoginComponent } from './component/login/login.component';
import { UserFormComponent } from './component/user-form/user-form.component';
import { WineListComponent } from './component/wine-list/wine-list.component';
import { WineCardComponent } from './component/wine-card/wine-card.component';
import { UserBasketComponent } from './component/user-basket/user-basket.component';
import { HomeComponent } from './component/home/home.component';
import { ProfileComponent } from './component/profile/profile.component';
import { CustomerService } from './services/customer.service';
import { ItemService } from './services/item.service';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    ContactComponent,
    HeaderComponent,
    FooterComponent,
    ContactComponent,
    LoginComponent,
    UserFormComponent,
    WineListComponent,
    WineCardComponent,
    UserBasketComponent,
    HomeComponent,
    ProfileComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    RouterModule,
    DxDataGridModule,
    DxTextBoxModule,
    DxValidatorModule,
    DxButtonModule
  ],
  providers: [
    CustomerService,
    ItemService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
