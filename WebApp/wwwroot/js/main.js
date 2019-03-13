var Personnel;
(function (Personnel) {
    var Employee = (function () {
        function Employee(Name, BirthDate, Status) {
            this.Name = Name;
            this.BirthDate = BirthDate;
            this.Status = Status;
        }
        ;
        Object.defineProperty(Employee.prototype, "StatusText", {
            get: function () {
                if (this.Status != null)
                    return EmployeeStatus[this.Status];
            },
            enumerable: true,
            configurable: true
        });
        ;
        return Employee;
    }());
    Personnel.Employee = Employee;
    var EmployeeStatus;
    (function (EmployeeStatus) {
        EmployeeStatus[EmployeeStatus["Active"] = 0] = "Active";
        EmployeeStatus[EmployeeStatus["OnVacation"] = 1] = "OnVacation";
        EmployeeStatus[EmployeeStatus["Released"] = 2] = "Released";
    })(EmployeeStatus = Personnel.EmployeeStatus || (Personnel.EmployeeStatus = {}));
})(Personnel || (Personnel = {}));
var static = Personnel;
var employees = [
    new p.Employee("Tom", new Date(1992, 15, 14))
];
console.log("Name: " + employees[0].Name + ", BirthDate: " + employees[0].BirthDate + ", Status: " + employees[0].StatusText);
//# sourceMappingURL=main.js.map