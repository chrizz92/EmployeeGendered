using System;

namespace EmployeeGendered
{
    /// <summary>
    /// Arbeiter ist ein Mitarbeiter, der aber nach Arbeitsstunden und Stundenlohn bezahlt wird
    /// </summary>
    public class Worker : Employee
    {
        private double _hours;           // Spezielle Daten des Arbeiters
        private double _hourlyWage;      // Stundenlohn

        /// <summary>
        /// Überladener Konstruktor
        /// Stunden und Stundenlohn werden später zugebracht
        /// Verwendet den Konstruktor der Basisklasse Employee
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="department"></param>
        public Worker(string name, Gender gender, string department)
            : base(name, gender, department)
        {
        }

        /// <summary>
        /// Überladener Konstruktor des Arbeiters verwendet wieder den Konstruktor der eigenen Klasse mit
        /// (Deltaprogrammierung)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="department"></param>
        /// <param name="hours"></param>
        /// <param name="hourlyWage"></param>
        public Worker(string name, Gender gender, string department, double hours, double hourlyWage)
            : this(name, gender, department)
        {
            _hours = hours;
            _hourlyWage = hourlyWage;
        }

        /// <summary>
        /// Arbeiter fügt sein Dienstverhältnis hinzu
        /// </summary>
        /// <returns>Info des Arbeiter</returns>
        public override string GetInfo()
        {
            string genderedJob = " und bin Arbeiterin";
            if (base.Gender == 0)
            {
                genderedJob = " und bin Arbeiter";
            }

            return base.GetInfo() + genderedJob;
        }

        public double HourlyWage
        {
            get
            {
                return _hourlyWage;
            }
            set
            {
                _hourlyWage = value;
            }
        }

        /// <summary>
        /// Die Monatsstunden dürfen nicht negativ sein. Ausserdem ist die
        /// Tagesarbeitszeit auf 16 Stunden beschränkt
        /// </summary>
        public double Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                _hours = value;
            }
        }

        /// <summary>
        /// Das Gehalt des Arbeiters unterscheidet sich in der Berechnung
        /// vom Gehalt des Mitarbeiters und Angestellten.
        /// </summary>
        public override double GetSalary()
        {
            throw new NotImplementedException();
        }
    }
}