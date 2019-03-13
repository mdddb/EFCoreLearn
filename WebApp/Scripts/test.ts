namespace Personnel {
    export class Employee {
        constructor(public Name: string, public BirthDate: Date, public Status?: EmployeeStatus) {

        };
        get StatusText() {
            if (this.Status != null)
                return EmployeeStatus[this.Status];
        };
    }

    export enum EmployeeStatus {
        Active,
        OnVacation,
        Released
    }
}

var employees = [
    new Personnel.Employee("Tom", new Date(1992, 15, 14))
];
console.log(`Name: ${employees[0].Name}, BirthDate: ${employees[0].BirthDate}, Status: ${employees[0].StatusText}`);