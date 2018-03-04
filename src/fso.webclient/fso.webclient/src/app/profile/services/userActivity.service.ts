
import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import 'rxjs/add/operator/map';
import { Observable } from 'rxjs/Observable';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { environment } from '../../../environments/environment';

@Injectable()
export class UserActivityService {

    private actionUrl: string;
    private headers: HttpHeaders;

    constructor(private _http: HttpClient) {
        this.actionUrl = `${environment.serviceUrls.Base}api/UserInfo/`;
        this.headers = new HttpHeaders();
        this.headers = this.headers.set('Content-Type', 'application/json');
        this.headers = this.headers.set('Accept', 'application/json');
    }
    public GetUserActivities = (userName: string, pageIndex: number, pageSize: number): Observable<any> => {
        return this._http.get<any>
        (this.actionUrl + `GetUserFeed?userName=${userName}&pageIndex=${pageIndex}&pageSize=${pageSize}`,
        {headers: this.headers});
    }
}
