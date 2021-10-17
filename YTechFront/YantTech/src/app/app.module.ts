import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShowSmartComponent } from './Smartphones/show-smart/show-smart.component';
import { AddEditSmartComponent } from './Smartphones/add-edit-smart/add-edit-smart.component';
import { SmartphonesComponent } from './Smartphones/smartphones.component';
import { SharedService } from './shared.service';

import {HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    ShowSmartComponent,
    AddEditSmartComponent,
    SmartphonesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
