namespace SimpleCheckout.Entities
{
    public class ProductDetail
    {
        public int? Id { get; set; }
        public string MobileName{ get; set; }
        public string Url { get; set; }
        public string Feature { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public SimType SimType { get; set; }
    }
    public enum SimType
    {
        OneSim =1,
        DualSim,
        TrioSim
    }
}