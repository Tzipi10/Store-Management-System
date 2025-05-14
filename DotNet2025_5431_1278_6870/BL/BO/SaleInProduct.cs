namespace BO
{
    public class SaleInProduct
    {
        public int SaleId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public CustomerPreference Preference { get; set; }

        public SaleInProduct(int SaleId, int Quantity, double Price, CustomerPreference Preference=BO.CustomerPreference.COSTOMER)
        {
            this.SaleId = SaleId;
            this.Quantity = Quantity;
            this.Price = Price;
            this.Preference = Preference;
        }

        public override string ToString() => this.ToStringProperty();

        //public override string ToString()
        //{
        //    return "SaleId: " + SaleId + " Quantity: " + Quantity + " Price: " + Price + " Preference: " + Preference;
        //}
    }


}
