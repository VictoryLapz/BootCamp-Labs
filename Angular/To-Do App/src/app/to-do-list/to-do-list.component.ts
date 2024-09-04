import { Component } from '@angular/core';
import { ToDo } from './models/to-do';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-to-do-list',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './to-do-list.component.html',
  styleUrls: ['./to-do-list.component.css']
})
export class ToDoListComponent {
  ToDo: ToDo[] = [
    {
      task: "Fold Clothes", isComplete: false, duration: 30,
      priority: 'Normal-Level'
    },
    {
      task: "Call Mom", isComplete: true, duration: 15,
      priority: 'High-Level'
    },
    {
      task: "Walk the Dog", isComplete: true, duration: 20,
      priority: 'Low-Level'
    },
    {
      task: "Relax Time", isComplete: false, duration: 45,
      priority: 'High-Level'
    },
  ];

  newTask: string = '';
  newDuration: number = 0;
  newPriority: 'Low-Level' | 'High-Level' | 'Normal-Level' = 'Normal-Level';
  filterText: string = '';

  completeTask(todo: ToDo) {
    todo.isComplete = true;
  }

  removeTask(todo: ToDo) {
    this.ToDo = this.ToDo.filter(t => t !== todo);
  }

  addToDo(): void {
    if (this.newTask.trim() && this.newDuration > 0) {
      console.log('task', this.newTask);
      console.log('duration', this.newDuration);
      console.log('priority', this.newPriority);
  
      const newTodo: ToDo = {
        task: this.newTask,
        duration: this.newDuration,
        isComplete: false,
        priority: this.newPriority
      };
  
      this.ToDo.push(newTodo);;

      this.newTask = '';
      this.newDuration = 0;
      this.newPriority = 'Normal-Level';

  }
}
filteredTodos(): ToDo[] {
  return this.ToDo.filter(todo => todo.task.toLowerCase().includes(this.filterText.toLowerCase()));
}
}