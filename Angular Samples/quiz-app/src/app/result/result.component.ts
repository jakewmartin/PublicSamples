import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-result',
  standalone: true,
  imports: [],
  templateUrl: './result.component.html',
  styleUrl: './result.component.css'
})

export class ResultComponent implements OnInit {
  @Input() quizResults: any[] = [];

  ngOnInit(): void {

  }
}
