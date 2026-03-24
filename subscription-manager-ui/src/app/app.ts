import { Component, OnInit } from '@angular/core';
import { SubscriptionService } from './services/subscription.service';
import { Subscription } from './models/subscription';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.html'
})
export class App implements OnInit {

  subscriptions: Subscription[] = [];

  constructor(private subscriptionService: SubscriptionService) {}

  ngOnInit(): void {
    this.subscriptionService.getSubscriptions()
      .subscribe(data => {
        this.subscriptions = data;
      });
  }
}
