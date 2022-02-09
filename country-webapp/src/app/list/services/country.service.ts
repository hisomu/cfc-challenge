import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, combineLatest, distinctUntilChanged, filter, Observable, shareReplay, switchMap } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CountryService {
  provinces$ = this.httpClient
  .get<Array<any>>('http://localhost:4200/api/provinces')
		.pipe(
			shareReplay({ bufferSize: 1, refCount: true })
		);
  province$ = new BehaviorSubject<string | undefined>(undefined);
  cities$ = combineLatest([
		this.province$.pipe(distinctUntilChanged()),
    this.provinces$
	])
	.pipe(
		switchMap(([prov, provinces]) => {
      let num = prov ? +prov : 0;
      let provin = provinces[num];

			return this.httpClient.get<Array<any>>(`http://localhost:4200/api/cities/${provin.name}`)
		}),
		shareReplay(1)
	);

  constructor(
    protected httpClient: HttpClient
  ) {}
}
