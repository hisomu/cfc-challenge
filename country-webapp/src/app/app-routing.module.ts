import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListComponent } from './list/component/list/list.component';

const routes: Routes = [
	{
		path: '',

		children: [
			{ path: '', pathMatch: 'full', redirectTo: 'countries' },

			// birthdays
			{ path: 'countries', component: ListComponent }
		]
	}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
