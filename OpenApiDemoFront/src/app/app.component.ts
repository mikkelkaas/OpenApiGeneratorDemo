import { Component } from '@angular/core';
import { MealboxService } from './core/api/v1';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'OpenApiDemoFrontend';
  mealboxes$ = this.mealboxService.apiMealboxGetMealboxesGet().subscribe(mealboxes => {
    mealboxes.forEach(mealbox => {
      console.log(mealbox.name + " contains " + mealbox.recipes?.map(x=>x.name).join(", "));
    });
  });

  constructor(private mealboxService: MealboxService) { }
}
