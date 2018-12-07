import { Component, OnInit } from '@angular/core';
import { Category } from '../shared/category.model';
import { CategoryService } from '../shared/category.service';

@Component({
  selector: 'app-create-category',
  templateUrl: './create-category.component.html',
  styleUrls: ['./create-category.component.scss']
})
export class CreateCategoryComponent implements OnInit {

  category: Category = { name: 'Your Name', description: 'Your Description'};

  constructor(private categoryService: CategoryService) { }

  ngOnInit() {

  }

  createCategory() {
    this.categoryService.createCategory(this.category).subscribe(() => location.reload());
  }

}
