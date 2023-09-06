import { Component, OnInit } from '@angular/core';
import { BlogService } from '../blog.service';
import { PostResume } from 'src/app/models/post.model';

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css']
})
export class BlogComponent implements OnInit {
    constructor(private blogService: BlogService){}

    posts: PostResume[] = [];

    ngOnInit() {debugger
        this.blogService.getAllPosts().subscribe((result: PostResume[]) => {debugger
            this.posts = result;
        });
    }
}
