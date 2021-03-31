namespace ExtensionMethods
{
    public class Repository
    {
        public MfgItemEntity Load()
        {
            MfgItemEntity entity = new MfgItemEntity();
            entity.Id = 1;
            entity.Name = "A";
            entity.Volume = 10;
            entity.Quantity = 200;
            return entity;
        }
    }
}