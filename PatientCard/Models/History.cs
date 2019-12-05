using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientCard.Models
{
    public class History
    {
        public int Id { get; set; }
        public string Speciality { get; set; }
        public string Doctor { get; set; }
        public string Diagnose { get; set; }
        public string Complaints { get; set; }
        public DateTime VisitDate { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
/*1. Заполнение личных данных (ИИН, ФИО, Адрес, Телефон)
2. Заполнение истории посещений в табличном виде (Специалист (терапевт, лор, и т.д.), ФИО врача, диагноз, жалобы, дата посещения)
3. Поиск пациента по ИИН и ФИО (в отдельном контроллере со своими Views)*/