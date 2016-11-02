(function (angular) {
    angular.module('schoolPlan').controller('classController', classController);
    function classController($log, classService) {
        var ctrl = this;
        getClasses();

        function getClasses() {
            classService.getClasses().then(function (data) {
                ctrl.classes = data;
            }, function (err) {
                $log.error('Load Classes Failed', err);
            });
        }
    }
})(angular);