using System;
using EmployeeGendered;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeTestProject
{
    [TestClass]
    public class InheritanceTests
    {
        /// <summary>
        /// tests for GetInfo
        ///</summary>
        [TestMethod()]
        public void GetInfo_Worker_ShouldReturnCorrectData()
        {
            Worker worker = new Worker("WorkerName", Gender.Male, "Department1");
            Assert.AreEqual("Ich heiße WorkerName und arbeite in der Abteilung Department1 und bin Arbeiter", worker.GetInfo(), "Text des Arbeiters stimmt nicht");
        }

        [TestMethod()]
        public void GetInfo_FemaleWorker_ShouldReturnCorrectData()
        {
            DepartmentalEmployee depEmployee = new DepartmentalEmployee("Ruth Reisig", Gender.Female, "Sachen für Reisende", 2300.0);
            Assert.AreEqual("Ich heiße Ruth Reisig und arbeite in der Abteilung Sachen für Reisende und bin Angestellte", depEmployee.GetInfo(), "Text der Angestellten stimmt nicht");
        }

        [TestMethod()]
        public void GetInfo_HeadOfDepartment_ShouldReturnCorrectData()
        {
            HeadOfDepartment headOfDepartment = new HeadOfDepartment("NameHeadOfDepartment", Gender.Female, "Department2", 2500.00);
            Assert.AreEqual("Ich heiße NameHeadOfDepartment und leite die Abteilung Department2", headOfDepartment.GetInfo(), "Text des Abteilungsleiters stimmt nicht");
        }

        /// <summary>
        /// typetests of instances
        ///</summary>
        [TestMethod()]
        public void TypeTest_WorkerIsWorker_ShouldReturnTrue()
        {
            Worker worker = new Worker("WorkerName", Gender.Male, "Department1");
            Assert.IsTrue(worker is Worker, "Muss ein Worker sein");
        }

        [TestMethod()]
        public void TypeTest_WorkerIsEmployee_ShouldReturnTrue()
        {
            Worker worker = new Worker("WorkerName", Gender.Male, "Department1");
            Assert.IsTrue(worker is Employee, "Ein Worker ist auch ein Employee");
        }

        [TestMethod()]
        public void TypeTest_WorkerIsDepartmentEmployee_ShouldReturnFalse()
        {
            Worker worker = new Worker("WorkerName", Gender.Male, "Department1");

            Employee employee = worker; // valid, because worker ist an employee, too.
            Assert.IsFalse(employee is DepartmentalEmployee, "Ein Worker ist kein Angestellter");
        }


        /// <summary>
        /// A test for name
        ///</summary>
        [TestMethod()]
        public void Name_FirstLetterUppercase_2Letters_ShouldReturn_Ö1()
        {
            Worker worker = new Worker("Ö1", Gender.Male, "Department1");
            Assert.AreEqual("Ö1", worker.Name, "Ö1 beginnt mit einem Großbuchstaben und hat zwei Zeichen");
        }

        [TestMethod()]
        public void Name_FirstLetterIsNumber_ShouldReturn_ERROR()
        {
            Worker worker = new Worker("1Ö", Gender.Female, "Department1");
            Assert.AreEqual("ERROR", worker.Name, "1Ö beginnt mit einer Ziffer");
        }

        [TestMethod()]
        public void Name_OnlyOneLetter_ShouldReturn_ERROR()
        {
            Worker worker = new Worker("X", Gender.Female, "Department1");
            Assert.AreEqual("ERROR", worker.Name, "X ist zu kurz");
        }

        /// <summary>
        /// A test for hourlyWage und hours
        ///</summary>
        [TestMethod()]
        public void GetSalary_Worker_ShouldReturnCorrectValue()
        {
            Worker worker = new Worker("Max", Gender.Male, "Department1", 175, 17.5);
            double salary = worker.GetSalary();
            Assert.AreEqual(175 * 17.5, worker.GetSalary(), 0.01, "Gehalt des Arbeiters stimmt nicht");
        }

        [TestMethod()]
        public void HoursWorker_OverLimitWorker_ShouldReturn0()
        {
            Worker worker = new Worker("Max", Gender.Male, "Department1", 175, 17.5);
            worker.Hours = 31 * 16.01;  // too many hours
            Assert.AreEqual(0, worker.Hours, "Zuweisung von zu vielen Stunden führt zu 0 bei Stunden");
        }

        [TestMethod()]
        public void HoursWorker_LessThanZero_ShouldReturn0()
        {
            Worker worker = new Worker("Max", Gender.Male, "Department1", 175, 17.5);
            worker.Hours = -1;  // hours negative
            Assert.AreEqual(0, worker.Hours, "Zuweisung von negativen Stunden führt zu 0 bei Stunden");
        }

        [TestMethod()]
        public void HourlyWageWorker_LessThanZero_ShouldReturn0()
        {
            Worker worker = new Worker("Max", Gender.Male, "Department1", 175, 17.5);
            worker.Hours = 10;
            worker.HourlyWage = -1;
            Assert.AreEqual(0, worker.HourlyWage, "Zuweisung von negativem Stundenlohn führt zu 0 bei Stundenlohn");
        }

        [TestMethod()]
        public void SalaryWorker_HourlyWageNegative_ShouldReturn0()
        {
            Worker worker = new Worker("Max", Gender.Male, "Department1", 175, 17.5);
            worker.Hours = 10;
            worker.HourlyWage = -1;
            double salary = worker.GetSalary();
            Assert.AreEqual(0, worker.GetSalary(), 0.01, "10 Stunden * 0 ==> 0");
        } 

        /// <summary>
        /// A test for HeadOfDepartment
        ///</summary>
        [TestMethod()]
        public void GetSalary_HeadOfDepartmentTest_ShouldReturnCorrectValue()
        {
            HeadOfDepartment head = new HeadOfDepartment("Chef", Gender.Male, "Dept1", 3500);
            Assert.AreEqual(3500 * 1.2, head.GetSalary(), "Gehalt mit Zuschlag");
        }

        [TestMethod()]
        public void TypeTest_HeadIsDepartmentalEmployee_ShouldReturnTrue()
        {
            HeadOfDepartment head = new HeadOfDepartment("Chef", Gender.Male, "Dept1", 3500);
            Assert.IsTrue(head is DepartmentalEmployee, "Chef ist auch Abteilungsmitarbeiter");
        }

        [TestMethod()]
        public void TypeTest_HeadIsEmployee_ShouldReturnTrue()
        {
            HeadOfDepartment head = new HeadOfDepartment("Chef", Gender.Male, "Dept1", 3500);
            Assert.IsTrue(head is Employee, "Chef ist auch Mitarbeiter");
        }
    }
}
