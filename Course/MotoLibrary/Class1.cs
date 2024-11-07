namespace MotoLibrary
{
    public interface IMotorcycle
    {
        string model { get; set; }
        int year { get; set; }
        double price { get; set; }
        int capacityEng { get; set; }
        int mas { get; set; }
        string GetInfo();
    }
}
