using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatientCard.Models
{
    public class Patient
    {
        public int Id { get; set; }
        [StringLength(12, MinimumLength = 12, ErrorMessage = "ИИН состоит из 12 цифр")]
        public int IIN { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
/*1. Заполнение личных данных (ИИН, ФИО, Адрес, Телефон)
2. Заполнение истории посещений в табличном виде (Специалист (терапевт, лор, и т.д.), ФИО врача, диагноз, жалобы, дата посещения)
3. Поиск пациента по ИИН и ФИО (в отдельном контроллере со своими Views)*/