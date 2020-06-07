using System;

namespace EmployeeGendered
{
    /// <summary>
    /// Abteilungsleiter ist ein Abteilungsmitarbeiter, der die Abteilung leitet
    /// Er gibt einen speziellen Text als Info aus und erhält 20% Leitungszuschlag auf seinen Monatslohn
    /// </summary>
    public class HeadOfDepartment : DepartmentalEmployee
    {
        /// <summary>
        /// Konstruktor des Abteilungsleiters verwendet den Konstruktor des
        /// Abteilungsmitarbeiters.
        /// Spezielles bleibt nichts übrig
        /// </summary>
        /// <param name="name"></param>
        /// <param name="abteilung"></param>
        /// <param name="monatsLohn"></param>
        public HeadOfDepartment(string name, Gender gender, string department, double monthlyWage)
            : base(name, gender, department, monthlyWage)
        {
        }

        /// <summary>
        /// Abteilungsleiter schreibt Text komplett neu (100% Änderung)
        /// Verwendet nicht den Text der Basisklasse (Abteilungsmitarbeiter)
        /// </summary>
        /// <returns>Info des Abteilungsleiters</returns>
        public override string GetInfo()
        {
            return $"Ich heiße {base.Name} und leite die Abteilung {base.Department}";
        }

        /// <summary>
        /// Abteilungsleiter ist ein Angestellter und bekommt 20% Zuschlag
        /// für die Leitung der Abteilung
        /// </summary>
        /// <returns></returns>
        public override double GetSalary()
        {
            return base.GetSalary() * 1.2;
        }
    }
}