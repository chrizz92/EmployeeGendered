using System;

namespace EmployeeGendered
{
    /// <summary>
    /// Abteilungsmitarbeiter ist ein Mitarbeiter
    /// Als Gehalt erhält er einen fixen Monatslohn
    /// </summary>
    public class DepartmentalEmployee : Employee
    {
        private double _monthlyWage;

        /// <summary>
        /// Konstruktor des Abteilungsmitarbeiter
        /// Verwendet den Konstruktor der Basisklasse und ergänzt diesen um spezielle
        /// Aufgaben für den Angestellten
        /// </summary>
        /// <param name="name"></param>
        /// <param name="department"></param>
        /// <param name="monthlyWage"></param>
        public DepartmentalEmployee(string name, Gender gender, string department, double monthlyWage)
            : base(name, gender, department)
        {
            _monthlyWage = monthlyWage;
        }

        /// <summary>
        /// Abteilungsmitarbeiter fügt sein Dienstverhältnis hinzu
        /// </summary>
        /// <returns>Info des Angestellten</returns>
        public override string GetInfo()
        {
            string genderedJob = " und bin Angestellte";
            if (base.Gender == 0)
            {
                genderedJob = " und bin Angestellter";
            }

            return base.GetInfo() + genderedJob;
        }

        /// <summary>
        /// Abteilungsmitarbeiter überschreibt GetSalary() indem er seinen
        /// Monatslohn zurückgibt.
        /// </summary>
        /// <returns></returns>
        public override double GetSalary()
        {
            return _monthlyWage;
        }
    }
}