import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { SmartphonesComponent } from './Smartphones/smartphones.component';

const routes: Routes = [
  {path: 'smartphone',component:SmartphonesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
