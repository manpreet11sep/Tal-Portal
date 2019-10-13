import { UserDetailsModal } from "../Modal/user-details.modal";
import { HttpClient } from '@angular/common/http';
import { Inject } from "@angular/core";

export class UserDetailService {

    public insurancePremium: number;
    baseUrl: string;
    
    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl;
    }

    submitUserDetails(userDetails: UserDetailsModal) {
        this.http.get<number>(this.baseUrl + 'getinsurancepremium').subscribe(result => {
            this.insurancePremium = result;
        }, error => console.error(error));
    }
    
    
}
