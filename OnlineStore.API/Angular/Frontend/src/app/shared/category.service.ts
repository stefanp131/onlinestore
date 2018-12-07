import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ConfigService } from './config.service';
import { Category } from './category.model';
import { Observable } from 'rxjs';

@Injectable()
export class CategoryService {

    constructor(private http: HttpClient, private config: ConfigService) { }

    getCategories(): Observable<Category[]> {
        return this.http.get<Category[]>(this.config.baseUrl + 'api/category');
    }

    createCategory(category: Category) {
        return this.http.post(this.config.baseUrl + 'api/category', category);
    }
}
