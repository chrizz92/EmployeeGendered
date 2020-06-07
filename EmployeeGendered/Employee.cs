/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 4ABIF 2019/2020
 *--------------------------------------------------------------
 *              Name: Christian Schadler
 *--------------------------------------------------------------
 *
 *
 *--------------------------------------------------------------
*/

using System;

namespace EmployeeGendered
{
    public enum Gender
    {
        Male,
        Female
    };

    /// <summary>
    /// Abstrakter Mitarbeiter
    /// Codeverdopplung wird vermieden, indem in dieser Klasse alles implementiert wird,
    /// was alle Arten von Mitarbeitern (Arbeiter, Angestellte, Abteilungsleiter) gemeinsam haben
    /// </summary>
    public abstract class Employee
    {
        private string _name;        // Konkrete Felder jedes Mitarbeiters
        private string _department;
        private Gender _gender;

        /// <summary>
        /// Konstruktor erzeugt Mitarbeiter mit Namen und Abteilung
        /// </summary>
        /// <param name="name"></param>
        /// <param name="department"></param>
        public Employee(string name, Gender gender, string department)
        {
            if (Char.IsUpper(name[0]) && name.Length >= 2)//Beginnt der Name mit einem Grossbuchstaben und hat mindestens 2 Zeichen?
            {
                _name = name;
            }
            else
            {
                _name = "ERROR";
            }

            _gender = gender;
            _department = department;
        }

        /// <summary>
        /// Jeder Mitarbeiter kann seine Grunddaten bekanntgeben
        /// </summary>
        /// <returns></returns>
        public virtual string GetInfo()
        {
            return $"Ich heiße {_name} und arbeite in der Abteilung {_department}";
        }

        /// <summary>
        /// Liefert das Gehalt des Mitarbeiters. Dieses ist aber für Arbeiter,
        /// Angestellte und Abteilungsleiter unterschiedlich und kann daher
        /// in der Basisklasse nicht implementiert werden.
        /// </summary>
        /// <returns></returns>
        public abstract double GetSalary();

        public string Department
        {
            get
            {
                return _department;
            }
            private set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                throw new NotImplementedException();
            }
        }

        public Gender Gender
        {
            get
            {
                return _gender;
            }
            private set
            {
                throw new NotImplementedException();
            }
        }
    }
}