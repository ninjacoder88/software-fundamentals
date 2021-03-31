namespace ExtensionMethods
{
    public class MfgItemModel
    {
        public int Id {get;set;}

        public string Name {get;set;}

        public int Volume {get;set;}

        public int Quantity {get;set;}

        public int Concentration {get;set;}
    }

    public static class MfgItemEntityExtensions
    {
        public static MfgItemModel ToModel(this MfgItemEntity entity)
        {
            return new MfgItemModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Volume = entity.Volume,
                Quantity = entity.Quantity,
                Concentration = entity.Quantity / entity.Volume
            };
        }
    }
}