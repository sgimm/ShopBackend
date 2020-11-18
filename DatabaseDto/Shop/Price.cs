using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValkyraECommerce.DatabaseDto.Shop
{
    public class Price : BaseDbDto
    {
        public decimal GrossAmount { get; set; }
        public decimal NetAmout { get; set; }
        public decimal VatPercent { get; set; }
        public Currency Currency { get; set; }
        public Country Country { get; set; }
    }
}
