import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, retry } from 'rxjs';
import { CrudService } from '../utils/crud.service';
import { PostResume } from '../models/post.model';

@Injectable({
  providedIn: 'root'
})
export class BlogService {

  constructor(private http : HttpClient, private crud: CrudService) { }

  getAllPosts() : Observable<PostResume[]> {
    const url = "http://localhost:3000/posts"
    return this.http.get<PostResume[]>(url)
    .pipe(retry(1), catchError(e => this.crud.handleError(e)))
  }
}
