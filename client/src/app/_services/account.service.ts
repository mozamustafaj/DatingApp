import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, map } from 'rxjs';
import { User } from '../_models/user';

//Services can be injecable into our components or into other services. Thats what @injectable decorator represents

//when an service is provided in root module, such as the app module when our app is initialized then services are also initialized at the same time
//and the service is not destroyed until our applications is finished or the user is finished
//The service lives for the lifetime of our application.
//Recap: Services are injectable. Services are singleton
// diff with components : Componennts are destroyed when we move from one component to other component
@Injectable({
  providedIn: 'root', //it no need to privoide in appmodule as in older versions of angular. It automatically provide it in the roor
})
export class AccountService {
  baseUrl = 'https://localhost:5001/api/';
  private currentUserSource = new BehaviorSubject<User | null>(null);
  currentUser$ = this.currentUserSource.asObservable(); //$ is a convention to signify tahat is an oblservable

  constructor(private http: HttpClient) {}

  login(model: any) {
    //post method requires to pass body parameter
    //<User> it means that we know that the response is going to be the type User
    return this.http.post<User>(this.baseUrl + 'account/login', model).pipe(
      map((response: User) => {
        const user = response;
        if (user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUserSource.next(user);
        }
      })
    );
  }

  setCurrentUser(user: User) {
    this.currentUserSource.next(user);
  }

  logout() {
    localStorage.removeItem('user');
    this.currentUserSource.next(null);
  }
}
