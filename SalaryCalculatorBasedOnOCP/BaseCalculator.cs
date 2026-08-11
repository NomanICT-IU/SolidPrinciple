using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculatorBasedOnOCP
{
   public abstract class BaseCalculator
    {
        protected WrokerModel _wrokerModel { get; set; }
        protected BaseCalculator(WrokerModel wrokerModel)
        {
            _wrokerModel = wrokerModel;
        }

        public virtual double CalculateSalary()
        {
            return _wrokerModel.WorkingHours * _wrokerModel.HourlyRate;
        }   
    }
}
