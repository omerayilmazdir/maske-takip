﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    /*
     - kelime anlamı arayüzdür.
     - metotların imzaları oluşturulur
     
     */
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GerList();

        bool CheckPerson(Person person);
    }
}
