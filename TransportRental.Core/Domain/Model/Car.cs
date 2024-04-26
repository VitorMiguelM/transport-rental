namespace TransportRental.Core.Domain.Model;

public class Car(
    string brand,
    string model,
    DateOnly manufacturingYear,
    string color,
    string chassisNumber
    ) : BaseEntity
{
    public string Brand { get; protected set; } = brand;
    public string Model { get; protected set; } = model;
    public DateOnly ManufacturingYear { get; protected set; } = manufacturingYear;
    public string Color { get; protected set; } = color;
    public string ChassisNumber { get; protected set; } = chassisNumber;

    public void Update(
        string brand,
        string model,
        DateOnly manufacturingYear,
        string color,
        string chassisNumber
        )
    {
        Brand = brand;
        Model = model;
        ManufacturingYear = manufacturingYear;
        Color = color;
        ChassisNumber = chassisNumber;

    }

}
