namespace BussinesLogic.Models
{
    public class Discount
    {
        private (DateTime from, DateTime to) _durationTuple; // check is null in isValid 
        public string Name { get; set; }
        public int Percantage { get; set; }
        public bool  IsValid
        { 
            get => _durationTuple.to.Equals(_durationTuple.from) ? false : true;
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

        public Discount((DateTime from, DateTime to) durationTuple, string name, int percantage)
        {
            if (IsValid)
                throw new ArgumentException("_durationTuple values cant be equal");

            else if (durationTuple.to < durationTuple.from)
                throw new ArgumentException("_durationTuple value Datetime from, cant be more then Datetime to");

            else if (String.IsNullOrEmpty(name))
                throw new ArgumentException("Name cant be null or empty");

            else if (percantage <= 0)
                throw new ArgumentException("Percentage cant be less or equal to zero");

            else if (percantage == 0)
                throw new ArgumentException("Percentage cant be null");

            _durationTuple = durationTuple;
            Name = name;
            Percantage = percantage;
        }
    }
}
