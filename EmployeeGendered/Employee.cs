/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class:
 *--------------------------------------------------------------
 *              Name
 *--------------------------------------------------------------
 * Description:
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Jeder Mitarbeiter kann seine Grunddaten bekanntgeben
        /// </summary>
        /// <returns></returns>
        public virtual string GetInfo()
        {
            throw new NotImplementedException();
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
            get { throw new NotImplementedException(); }
            private set { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
            private set
            {
                throw new NotImplementedException();
            }
        }

        public Gender Gender
        {
            get
            {
                throw new NotImplementedException();
            }
            private set
            {
                throw new NotImplementedException();
            }
        }
    }
}