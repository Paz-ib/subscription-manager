import { Injectable, signal } from '@angular/core';
import { Subscription } from '../models/subscription';

@Injectable({
  providedIn: 'root'
})
export class SubscriptionService {

  private subscriptions = signal<Subscription[]>([
    {
      id: 1,
      name: 'Netflix',
      price: 10,
      startDate: '2024-01-01',
      paymentMethod: 'Credit Card',
      isActive: true
    },
    {
      id: 2,
      name: 'Spotify',
      price: 5,
      startDate: '2024-02-01',
      paymentMethod: 'PayPal',
      isActive: true
    }
  ]);

  getSubscriptions() {
    return this.subscriptions;
  }
}