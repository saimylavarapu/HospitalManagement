//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

/* tslint:disable */
/* eslint-disable */
// ReSharper disable InconsistentNaming

import { mergeMap as _observableMergeMap, catchError as _observableCatch } from 'rxjs/operators';
import { Observable, throwError as _observableThrow, of as _observableOf } from 'rxjs';
import { Injectable, Inject, Optional, InjectionToken } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse, HttpResponseBase } from '@angular/common/http';

export const BASE_URL = new InjectionToken<string>('BASE_URL');

@Injectable()
export class DepartnmentClient {
  private http: HttpClient;
  private baseUrl: string;
  protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

  constructor(@Inject(HttpClient) http: HttpClient, @Optional() @Inject(BASE_URL) baseUrl?: string) {
    this.http = http;
    this.baseUrl = baseUrl !== undefined && baseUrl !== null ? baseUrl : "";
  }

  /**
   * @param body (optional) 
   * @return Success
   */
  addDepartnmet(body: AddDepartnemtDTO | undefined): Observable<void> {
    let url_ = this.baseUrl + "/api/Departnment/AddDepartnmet";
    url_ = url_.replace(/[?&]$/, "");

    const content_ = JSON.stringify(body);

    let options_: any = {
      body: content_,
      observe: "response",
      responseType: "blob",
      headers: new HttpHeaders({
        "Content-Type": "application/json",
      })
    };

    return this.http.request("post", url_, options_).pipe(_observableMergeMap((response_: any) => {
      return this.processAddDepartnmet(response_);
    })).pipe(_observableCatch((response_: any) => {
      if (response_ instanceof HttpResponseBase) {
        try {
          return this.processAddDepartnmet(response_ as any);
        } catch (e) {
          return _observableThrow(e) as any as Observable<void>;
        }
      } else
        return _observableThrow(response_) as any as Observable<void>;
    }));
  }

  protected processAddDepartnmet(response: HttpResponseBase): Observable<void> {
    const status = response.status;
    const responseBlob =
      response instanceof HttpResponse ? response.body :
        (response as any).error instanceof Blob ? (response as any).error : undefined;

    let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); } }
    if (status === 200) {
      return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
        return _observableOf(null as any);
      }));
    } else if (status !== 200 && status !== 204) {
      return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
        return throwException("An unexpected server error occurred.", status, _responseText, _headers);
      }));
    }
    return _observableOf(null as any);
  }

  /**
   * @param id (optional) 
   * @return Success
   */
  deleteDepartnment(id: number | undefined): Observable<void> {
    let url_ = this.baseUrl + "/api/Departnment/DeleteDepartnment?";
    if (id === null)
      throw new Error("The parameter 'id' cannot be null.");
    else if (id !== undefined)
      url_ += "id=" + encodeURIComponent("" + id) + "&";
    url_ = url_.replace(/[?&]$/, "");

    let options_: any = {
      observe: "response",
      responseType: "blob",
      headers: new HttpHeaders({
      })
    };

    return this.http.request("delete", url_, options_).pipe(_observableMergeMap((response_: any) => {
      return this.processDeleteDepartnment(response_);
    })).pipe(_observableCatch((response_: any) => {
      if (response_ instanceof HttpResponseBase) {
        try {
          return this.processDeleteDepartnment(response_ as any);
        } catch (e) {
          return _observableThrow(e) as any as Observable<void>;
        }
      } else
        return _observableThrow(response_) as any as Observable<void>;
    }));
  }

  protected processDeleteDepartnment(response: HttpResponseBase): Observable<void> {
    const status = response.status;
    const responseBlob =
      response instanceof HttpResponse ? response.body :
        (response as any).error instanceof Blob ? (response as any).error : undefined;

    let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); } }
    if (status === 200) {
      return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
        return _observableOf(null as any);
      }));
    } else if (status !== 200 && status !== 204) {
      return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
        return throwException("An unexpected server error occurred.", status, _responseText, _headers);
      }));
    }
    return _observableOf(null as any);
  }

  /**
   * @param body (optional) 
   * @return Success
   */
  updateDepartnmetn(body: UpdateDepartnmentDTO | undefined): Observable<void> {
    let url_ = this.baseUrl + "/api/Departnment/UpdateDepartnmetn";
    url_ = url_.replace(/[?&]$/, "");

    const content_ = JSON.stringify(body);

    let options_: any = {
      body: content_,
      observe: "response",
      responseType: "blob",
      headers: new HttpHeaders({
        "Content-Type": "application/json",
      })
    };

    return this.http.request("put", url_, options_).pipe(_observableMergeMap((response_: any) => {
      return this.processUpdateDepartnmetn(response_);
    })).pipe(_observableCatch((response_: any) => {
      if (response_ instanceof HttpResponseBase) {
        try {
          return this.processUpdateDepartnmetn(response_ as any);
        } catch (e) {
          return _observableThrow(e) as any as Observable<void>;
        }
      } else
        return _observableThrow(response_) as any as Observable<void>;
    }));
  }

  protected processUpdateDepartnmetn(response: HttpResponseBase): Observable<void> {
    const status = response.status;
    const responseBlob =
      response instanceof HttpResponse ? response.body :
        (response as any).error instanceof Blob ? (response as any).error : undefined;

    let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); } }
    if (status === 200) {
      return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
        return _observableOf(null as any);
      }));
    } else if (status !== 200 && status !== 204) {
      return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
        return throwException("An unexpected server error occurred.", status, _responseText, _headers);
      }));
    }
    return _observableOf(null as any);
  }

  /**
   * @return Success
   */
  getAllDepartnment(): Observable<GetAllDepartnmentDTO[]> {
    let url_ = this.baseUrl + "/api/Departnment/GetAllDepartnment";
    url_ = url_.replace(/[?&]$/, "");

    let options_: any = {
      observe: "response",
      responseType: "blob",
      headers: new HttpHeaders({
        "Accept": "text/plain"
      })
    };

    return this.http.request("get", url_, options_).pipe(_observableMergeMap((response_: any) => {
      return this.processGetAllDepartnment(response_);
    })).pipe(_observableCatch((response_: any) => {
      if (response_ instanceof HttpResponseBase) {
        try {
          return this.processGetAllDepartnment(response_ as any);
        } catch (e) {
          return _observableThrow(e) as any as Observable<GetAllDepartnmentDTO[]>;
        }
      } else
        return _observableThrow(response_) as any as Observable<GetAllDepartnmentDTO[]>;
    }));
  }

  protected processGetAllDepartnment(response: HttpResponseBase): Observable<GetAllDepartnmentDTO[]> {
    const status = response.status;
    const responseBlob =
      response instanceof HttpResponse ? response.body :
        (response as any).error instanceof Blob ? (response as any).error : undefined;

    let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); } }
    if (status === 200) {
      return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
        let result200: any = null;
        let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
        if (Array.isArray(resultData200)) {
          result200 = [] as any;
          for (let item of resultData200)
            result200!.push(GetAllDepartnmentDTO.fromJS(item));
        }
        else {
          result200 = <any>null;
        }
        return _observableOf(result200);
      }));
    } else if (status !== 200 && status !== 204) {
      return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
        return throwException("An unexpected server error occurred.", status, _responseText, _headers);
      }));
    }
    return _observableOf(null as any);
  }

  /**
   * @param id (optional) 
   * @return Success
   */
  getDepartnmentbyid(id: number | undefined): Observable<GetAllDepartnmentDTO> {
    let url_ = this.baseUrl + "/api/Departnment/GetDepartnmentbyid?";
    if (id === null)
      throw new Error("The parameter 'id' cannot be null.");
    else if (id !== undefined)
      url_ += "id=" + encodeURIComponent("" + id) + "&";
    url_ = url_.replace(/[?&]$/, "");

    let options_: any = {
      observe: "response",
      responseType: "blob",
      headers: new HttpHeaders({
        "Accept": "text/plain"
      })
    };

    return this.http.request("get", url_, options_).pipe(_observableMergeMap((response_: any) => {
      return this.processGetDepartnmentbyid(response_);
    })).pipe(_observableCatch((response_: any) => {
      if (response_ instanceof HttpResponseBase) {
        try {
          return this.processGetDepartnmentbyid(response_ as any);
        } catch (e) {
          return _observableThrow(e) as any as Observable<GetAllDepartnmentDTO>;
        }
      } else
        return _observableThrow(response_) as any as Observable<GetAllDepartnmentDTO>;
    }));
  }

  protected processGetDepartnmentbyid(response: HttpResponseBase): Observable<GetAllDepartnmentDTO> {
    const status = response.status;
    const responseBlob =
      response instanceof HttpResponse ? response.body :
        (response as any).error instanceof Blob ? (response as any).error : undefined;

    let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); } }
    if (status === 200) {
      return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
        let result200: any = null;
        let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
        result200 = GetAllDepartnmentDTO.fromJS(resultData200);
        return _observableOf(result200);
      }));
    } else if (status !== 200 && status !== 204) {
      return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
        return throwException("An unexpected server error occurred.", status, _responseText, _headers);
      }));
    }
    return _observableOf(null as any);
  }
}

@Injectable()
export class Client {
  private http: HttpClient;
  private baseUrl: string;
  protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

  constructor(@Inject(HttpClient) http: HttpClient, @Optional() @Inject(BASE_URL) baseUrl?: string) {
    this.http = http;
    this.baseUrl = baseUrl !== undefined && baseUrl !== null ? baseUrl : "";
  }

  /**
   * @return Success
   */
  weatherForecast(): Observable<WeatherForecast[]> {
    let url_ = this.baseUrl + "/WeatherForecast";
    url_ = url_.replace(/[?&]$/, "");

    let options_: any = {
      observe: "response",
      responseType: "blob",
      headers: new HttpHeaders({
        "Accept": "text/plain"
      })
    };

    return this.http.request("get", url_, options_).pipe(_observableMergeMap((response_: any) => {
      return this.processWeatherForecast(response_);
    })).pipe(_observableCatch((response_: any) => {
      if (response_ instanceof HttpResponseBase) {
        try {
          return this.processWeatherForecast(response_ as any);
        } catch (e) {
          return _observableThrow(e) as any as Observable<WeatherForecast[]>;
        }
      } else
        return _observableThrow(response_) as any as Observable<WeatherForecast[]>;
    }));
  }

  protected processWeatherForecast(response: HttpResponseBase): Observable<WeatherForecast[]> {
    const status = response.status;
    const responseBlob =
      response instanceof HttpResponse ? response.body :
        (response as any).error instanceof Blob ? (response as any).error : undefined;

    let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); } }
    if (status === 200) {
      return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
        let result200: any = null;
        let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
        if (Array.isArray(resultData200)) {
          result200 = [] as any;
          for (let item of resultData200)
            result200!.push(WeatherForecast.fromJS(item));
        }
        else {
          result200 = <any>null;
        }
        return _observableOf(result200);
      }));
    } else if (status !== 200 && status !== 204) {
      return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
        return throwException("An unexpected server error occurred.", status, _responseText, _headers);
      }));
    }
    return _observableOf(null as any);
  }
}

export class AddDepartnemtDTO implements IAddDepartnemtDTO {
  departnmentName?: string | null;

  constructor(data?: IAddDepartnemtDTO) {
    if (data) {
      for (var property in data) {
        if (data.hasOwnProperty(property))
          (<any>this)[property] = (<any>data)[property];
      }
    }
  }

  init(_data?: any) {
    if (_data) {
      this.departnmentName = _data["departnmentName"] !== undefined ? _data["departnmentName"] : <any>null;
    }
  }

  static fromJS(data: any): AddDepartnemtDTO {
    data = typeof data === 'object' ? data : {};
    let result = new AddDepartnemtDTO();
    result.init(data);
    return result;
  }

  toJSON(data?: any) {
    data = typeof data === 'object' ? data : {};
    data["departnmentName"] = this.departnmentName !== undefined ? this.departnmentName : <any>null;
    return data;
  }
}

export interface IAddDepartnemtDTO {
  departnmentName?: string | null;
}

export class GetAllDepartnmentDTO implements IGetAllDepartnmentDTO {
  pkDepartnemtId?: number;
  departnmentName?: string | null;

  constructor(data?: IGetAllDepartnmentDTO) {
    if (data) {
      for (var property in data) {
        if (data.hasOwnProperty(property))
          (<any>this)[property] = (<any>data)[property];
      }
    }
  }

  init(_data?: any) {
    if (_data) {
      this.pkDepartnemtId = _data["pkDepartnemtId"] !== undefined ? _data["pkDepartnemtId"] : <any>null;
      this.departnmentName = _data["departnmentName"] !== undefined ? _data["departnmentName"] : <any>null;
    }
  }

  static fromJS(data: any): GetAllDepartnmentDTO {
    data = typeof data === 'object' ? data : {};
    let result = new GetAllDepartnmentDTO();
    result.init(data);
    return result;
  }

  toJSON(data?: any) {
    data = typeof data === 'object' ? data : {};
    data["pkDepartnemtId"] = this.pkDepartnemtId !== undefined ? this.pkDepartnemtId : <any>null;
    data["departnmentName"] = this.departnmentName !== undefined ? this.departnmentName : <any>null;
    return data;
  }
}

export interface IGetAllDepartnmentDTO {
  pkDepartnemtId?: number;
  departnmentName?: string | null;
}

export class UpdateDepartnmentDTO implements IUpdateDepartnmentDTO {
  id?: number;
  departnmentName?: string | null;

  constructor(data?: IUpdateDepartnmentDTO) {
    if (data) {
      for (var property in data) {
        if (data.hasOwnProperty(property))
          (<any>this)[property] = (<any>data)[property];
      }
    }
  }

  init(_data?: any) {
    if (_data) {
      this.id = _data["id"] !== undefined ? _data["id"] : <any>null;
      this.departnmentName = _data["departnmentName"] !== undefined ? _data["departnmentName"] : <any>null;
    }
  }

  static fromJS(data: any): UpdateDepartnmentDTO {
    data = typeof data === 'object' ? data : {};
    let result = new UpdateDepartnmentDTO();
    result.init(data);
    return result;
  }

  toJSON(data?: any) {
    data = typeof data === 'object' ? data : {};
    data["id"] = this.id !== undefined ? this.id : <any>null;
    data["departnmentName"] = this.departnmentName !== undefined ? this.departnmentName : <any>null;
    return data;
  }
}

export interface IUpdateDepartnmentDTO {
  id?: number;
  departnmentName?: string | null;
}

export class WeatherForecast implements IWeatherForecast {
  date?: Date;
  temperatureC?: number;
  readonly temperatureF?: number;
  summary?: string | null;

  constructor(data?: IWeatherForecast) {
    if (data) {
      for (var property in data) {
        if (data.hasOwnProperty(property))
          (<any>this)[property] = (<any>data)[property];
      }
    }
  }

  init(_data?: any) {
    if (_data) {
      this.date = _data["date"] ? new Date(_data["date"].toString()) : <any>null;
      this.temperatureC = _data["temperatureC"] !== undefined ? _data["temperatureC"] : <any>null;
      (<any>this).temperatureF = _data["temperatureF"] !== undefined ? _data["temperatureF"] : <any>null;
      this.summary = _data["summary"] !== undefined ? _data["summary"] : <any>null;
    }
  }

  static fromJS(data: any): WeatherForecast {
    data = typeof data === 'object' ? data : {};
    let result = new WeatherForecast();
    result.init(data);
    return result;
  }

  toJSON(data?: any) {
    data = typeof data === 'object' ? data : {};
    data["date"] = this.date ? this.date.toISOString() : <any>null;
    data["temperatureC"] = this.temperatureC !== undefined ? this.temperatureC : <any>null;
    data["temperatureF"] = this.temperatureF !== undefined ? this.temperatureF : <any>null;
    data["summary"] = this.summary !== undefined ? this.summary : <any>null;
    return data;
  }
}

export interface IWeatherForecast {
  date?: Date;
  temperatureC?: number;
  temperatureF?: number;
  summary?: string | null;
}

export class ApiException extends Error {
  override message: string;
  status: number;
  response: string;
  headers: { [key: string]: any; };
  result: any;

  constructor(message: string, status: number, response: string, headers: { [key: string]: any; }, result: any) {
    super();

    this.message = message;
    this.status = status;
    this.response = response;
    this.headers = headers;
    this.result = result;
  }

  protected isApiException = true;

  static isApiException(obj: any): obj is ApiException {
    return obj.isApiException === true;
  }
}

function throwException(message: string, status: number, response: string, headers: { [key: string]: any; }, result?: any): Observable<any> {
  if (result !== null && result !== undefined)
    return _observableThrow(result);
  else
    return _observableThrow(new ApiException(message, status, response, headers, null));
}

function blobToText(blob: any): Observable<string> {
  return new Observable<string>((observer: any) => {
    if (!blob) {
      observer.next("");
      observer.complete();
    } else {
      let reader = new FileReader();
      reader.onload = event => {
        observer.next((event.target as any).result);
        observer.complete();
      };
      reader.readAsText(blob);
    }
  });
}
