var myApp = angular.module('myApp', []);

myApp.controller('EmployeeControllers', function ($scope, $http) {

   

    $http.get('https://localhost:44358/api/Employee/Get').then(function (d) {
        $scope.employees = d.data;
    }, function (e) {
        alert(e);
    });

    $scope.DeleteEmployee = function (employeeID) {
        var id = employeeID;
        console.log($scope.id);

        $http({
            method: 'Delete',
            url: 'https://localhost:44358/api/Employee/DeleteEmployee/' + id,
        }).then(function successCallBack() {
            alert('employee data is deleted');
           
            $http.get('https://localhost:44358/api/Employee/Get').then(function (d) {
                $scope.employees = d.data;
            }, function (e) {
                alert(e);
            });
        });      
    }
});



myApp.controller('AddEmployeeController', function ($scope, $http) {
    $scope.btntext = 'Save';

    $http.get('https://localhost:44358/api/Employee/Get').then(function (d) {
        $scope.employees = d.data;
    }, function (e) {
        alert(e);
    });


    $scope.AddEmployee = function () {
        console.log("inside add method", $scope.newEmployee);
        var data = {
            'EmployeeName': $scope.newEmployee.fullName,
            'EmailID': $scope.newEmployee.email,
            'Password': $scope.newEmployee.password,
            'Designation': $scope.newEmployee.designation,
            'Salary': $scope.newEmployee.salary
        }
        console.log("newdata=", data);

        $http({
            method: 'Post',
            url: 'https://localhost:44358/api/Employee/AddEmployee',
            data: data,
   
        }).then(function successCallBack() {
            alert('Employee data is Added');
            $http.get('https://localhost:44358/api/Employee/Get').then(function (d) {
                $scope.employees = d.data;
            }, function (e) {
                alert(e);
            });

        }, function (e) {
            alert(e);
        });
    }
});
