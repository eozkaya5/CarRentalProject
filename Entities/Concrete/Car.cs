
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
  
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }      
        public string CarName { get; set; }
        public int Modelyear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
//Attribute: Öz nitelikler
//Çalışma anında nesnelerin özelliklerine methodlara anlam katmak için kullanırız
//İş kuralları koyabilirsiniz.

//[Obsolete]// Bu methodu kullanma
