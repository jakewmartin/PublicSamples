// app.module.ts

import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component'; // Import the NavbarComponent
import { TaskListComponent } from './components/task-list/task-list.component'; // Import Task List component
import { TaskFormComponent } from './components/task-form/task-form.component'; // Import Task Form component
@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    TaskListComponent, // Add Task List component to the declarations array before Task Form component
    TaskFormComponent // Add Task Form component to the declarations array
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
