// components/task-list/task-list.component.ts
import { Component, Input, OnInit } from '@angular/core';
import { Task } from '../../constants/tasks.interface';
@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html'
})
export class TaskListComponent implements OnInit {
  @Input() tasks: Task[] = [];
  constructor() { }
  ngOnInit(): void {
  }
  removeTask(task: Task) {
    const taskIndex = this.tasks.indexOf(task);
    if (taskIndex !== -1) {
      this.tasks.splice(taskIndex, 1);
    }
  }
  toggleCompleted(task: Task) {
    task.completed = !task.completed;
  }
}
