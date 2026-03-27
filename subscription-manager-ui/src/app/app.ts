import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { SubscriptionService } from './services/subscription.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true, 
  imports: [RouterOutlet, CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  subscriptions: any;

  constructor(private subscriptionService: SubscriptionService) 
  {
    this.subscriptions = this.subscriptionService.getSubscriptions(); 
  }

  
}
