"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var UserDetailsController = /** @class */ (function () {
    function UserDetailsController($scope, $http, $window) {
        this.$scope = $scope;
        this.$http = $http;
        this.$window = $window;
        this.userDetails = {
            firstName: '',
            lastName: '',
            age: 0,
            occupation: '',
            dateOfBirth: '',
            sumInsured: 0
        };
    }
    UserDetailsController.prototype.continueToNextStep = function () {
        var _this = this;
        this.$http({
            method: 'Get',
            url: '/api/calculate',
            data: JSON.stringify(this.userDetails)
        }).then(function (response) {
            _this.$window.alert(response.CalculatedPremium);
        }, function (response) {
        }).finally(function () {
        });
    };
    UserDetailsController.$inject = [
        '$scope',
        '$http',
        '$window'
    ];
    return UserDetailsController;
}());
exports.UserDetailsController = UserDetailsController;
//# sourceMappingURL=user-details.controller.js.map