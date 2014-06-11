var app = angular.module("LoginApp", []);
app.factory("LoginService", function() {
    var factory = {};
    factory.Login = Login;
    factory.Error = Error;
    return factory;
});

app.controller("LoginController", ["$scope", "$http", "LoginService", function ($scope, $http, LoginService) {
    DefineUserTypes($scope);
    $scope.Submit = function () {
        LoginService.Login($http, $scope.LoginModel)
        .success(function (data){
            alert("done");
        })
        .error(function(data){
            LoginService.Error($scope, $http, data.Message);
        });
    };
}]);

function DefineUserTypes($scope) {
    $scope.LoginModel = {
        UserTypes : 
            {
                Admin: {
                    "ID": "1",
                    "Value": "Admin"
                }
            }
    }
    $scope.LoginModel.UserTypes.Guest = {
        "ID": "2",
        "Value": "Guest"
    }
    $scope.LoginModel.UserType = $scope.LoginModel.UserTypes.Admin;
}

function Login(http, loginModel)
{
    return http.post("/api/Login", loginModel);
}

function Error(scope, http, errorString) {
    http.post("/home/error",
            { error: errorString }
        );
}

