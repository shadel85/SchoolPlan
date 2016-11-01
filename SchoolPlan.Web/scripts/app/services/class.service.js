(function (angular) {
    angular.module('schoolPlan').factory('classService', classService);

    function classService($http) {
        var service = {
            getClasses: getClasses,
            updateClass: updateClass,
            deleteClass: deleteClass,
            addClass: addClass
        };

        return service;

        function updateClass(updatedClass, classId) {
            var request = $http({
                method: "put",
                url: "/api/Classes/" + classId,
                data: updatedClass
            });
            return request;
        }

        function getClasses() {
            return $http.get("/api/Classes")
                .then(function (response) {
                    return response.data;
                });
        }

        function deleteClass(classId) {
            var request = $http({
                method: "delete",
                url: "/api/Classes/" + classId
            });
            return request;
        }

        function addClass(newClass) {
            var request = $http({
                method: "post",
                url: "/api/Classes",
                data: newClass
            });
            return request;
        }
    }

})(angular);