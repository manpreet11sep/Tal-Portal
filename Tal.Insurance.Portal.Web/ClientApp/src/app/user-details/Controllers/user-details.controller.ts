import { UserDetailsModal } from "../Modal/user-details.modal";


export class UserDetailsController {
    public userDetails: UserDetailsModal;

    private formErrors: {
        noError: boolean;
    };

    public static $inject = [
        '$scope',
        '$http',
        '$window'
    ];

    constructor(private $scope, private $http, private $window) {
        this.userDetails = {
            firstName: '',
            lastName: '',
            age: 0,
            occupation: '',
            dateOfBirth: '',
            sumInsured: 0
        }
    }

    continueToNextStep() {

        this.$http({
            method: 'Get',
            url: '/api/calculate',
            data: JSON.stringify(this.userDetails)
        }).then((response) => {
            this.$window.alert(response.CalculatedPremium)
        }, (response) => {

        }).finally(() => {

        });
    }

}

