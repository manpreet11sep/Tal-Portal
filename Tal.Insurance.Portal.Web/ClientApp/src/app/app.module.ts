import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { AppComponent } from './app.component';
import { UserDetailsComponent } from './user-details/user-details.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        UserDetailsComponent
    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', component: UserDetailsComponent, pathMatch: 'full' }
        ])
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
