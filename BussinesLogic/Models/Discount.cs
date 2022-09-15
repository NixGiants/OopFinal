using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Models
{
    public class Discount
    {
        private (DateTime from, DateTime to) _durationTuple; // check is null in isValid 
        public string? Name { get; set; }
        public int Percantage { get; set; }
        public bool  IsValid
        { 
            get => _durationTuple.to.Equals(_durationTuple.to) ? false : true;
        }
        public (DateTime from, DateTime to) DurationTuple {
            
            get => _durationTuple;
            
            set
            {
                if (value.from > value.to)
                {
                    throw new ArgumentException("Datetime from cant be more then Datetime to");
                }
                _durationTuple = value;
            }
        }
    }
}
