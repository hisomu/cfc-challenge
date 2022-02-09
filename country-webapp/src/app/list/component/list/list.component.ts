import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { catchError, Observable, throwError } from 'rxjs';
import { untilComponentDestroyed } from 'src/app/shared/component-destroyed';
import { TrackByService } from 'src/app/shared/services';
import { CountryService } from '../../services/country.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  provinces$: Observable<any> | undefined;
  cities$: Observable<any> | undefined;

  constructor(
		private readonly cdRef: ChangeDetectorRef,
		private readonly countrySvc: CountryService,
		public trackBySvc: TrackByService
	) { }

  ngOnInit(): void {
    this.provinces$ = this.countrySvc.provinces$
			.pipe(
				catchError((err, caught) => {
					this.cdRef.detectChanges();

					return throwError(err);
				}),
				untilComponentDestroyed(this));

        this.cities$ = this.countrySvc.cities$
			.pipe(
				catchError((err, caught) => {
					this.cdRef.detectChanges();

					return throwError(err);
				}),
				untilComponentDestroyed(this));
  }

	ngOnDestroy(): void {
		// required to properly unsubscribe observables
	}

  tabChange(event: any){
    this.countrySvc.province$.next(event);
  }

}
