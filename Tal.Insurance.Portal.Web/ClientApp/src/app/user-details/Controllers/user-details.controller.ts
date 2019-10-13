import { UserDetailsModal } from "../Modal/user-details.modal";

let angular = require('angular');

export class UserDetailsController {
    private userDetails: UserDetailsModal;

    private formErrors: {
        noError: boolean;
    };

    public static $inject = [
        '$scope'
    ];

    constructor(private $scope) {
        this.userDetails = {
            firstName: '',
            lastName: '',
            age: 0,
            occupation: '',
            dateOfBirth: '',
            sumInsured: 0
        }
    }

    SubmitUserDetails() {
    }
}
