import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-quiz',
  standalone: true,
  imports: [],
  templateUrl: './quiz.component.html',
  styleUrl: './quiz.component.css'
})
export class QuizComponent implements OnInit {
  questions = [{ question: 'What is the capital of France?', options: ['Berlin', 'Madrid', 'Paris', 'Rome'], answer: 'Paris' }]; //add more questions as needed
  selectedOptions: string[] = []

  constructor(private router: Router) { }

  submitQuiz() {
    //Logic to evaluate the quiz and navigate to the result component
    const quizResults = this.questions.map((q, i) => ({
      question: q.question,
      userAnswer: this.selectedOptions[i],
      correctAnswer: q.answer
    }))

    this.router.navigate(['/result'], { state: { quizResults } });
  }

  ngOnInit(): void {
    //Initialization logic goes here
  }
}
