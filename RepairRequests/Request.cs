using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairRequests
{
    public enum EquipmentType
    {
        Холодильник,
        СтиральнаяМашина,
        Телевизор,
        Микроволновка,
        Пылесос
    }

    public enum Brand
    {
        Samsung,
        LG,
        Bosch,
        Indesit,
        Philips
    }

    public enum RequestStatus
    {
        НоваяЗаявка,
        ВПроцессеРемонта,
        Завершена
    }

    public class Request
    {
        public int RequestId { get; set; }
        public DateTime DateAdded { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string ProblemDescription { get; set; }
        public string ClientName { get; set; }
        public string PhoneNumber { get; set; }
        public RequestStatus Status { get; set; }
    }
}