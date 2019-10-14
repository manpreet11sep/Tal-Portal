import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient, HttpParams} from '@angular/common/http';
import { UserDetailsModal } from './Modal/user-details.modal';

@Component({
    selector: 'app-user-details',
    templateUrl: './user-details.component.html',
    styleUrls: ['./user-details.component.css']
})
export class UserDetailsComponent implements OnInit {

    public insurancePremium: calculatedResponse;
    baseUrl: string;
    public userDetails: UserDetailsModal;

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {


        this.baseUrl = baseUrl;

        this.userDetails = {
            firstName: '',
            lastName: '',
            age: 0,
            occupation: '',
            dateOfBirth: '',
            sumInsured: 0
        }


       
    }

    

    ngOnInit() {
        
    }

    continueToNextStep(userDetails: UserDetailsModal) {

        let params = new HttpParams({
            fromObject: {
                age: userDetails.age.toString(),
                occupation: userDetails.occupation,
                suminsured: userDetails.sumInsured.toString()
            }
        });

        this.http.get<calculatedResponse>(this.baseUrl + 'insurancepremium', { params: params }).subscribe(result => {
            this.insurancePremium = result;
        }, error => console.error(error));             

       
    }

    
}


interface calculatedResponse {
    calculatedPremium: number;
}
