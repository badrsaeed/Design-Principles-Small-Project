namespace SOLID_InterfaceSegregationPrinciple_ISP.Before
{
    interface IEntitlement
    { 
        decimal CalculatePension();
        decimal CalculateHealthInsurance();
        decimal CalculateRentalSubsidy();
        decimal CalculateBonuses();
        decimal CalculateTransportationReimbursement();

    }
}
