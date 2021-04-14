namespace FactoryDemo
{
    public class MixedBaseFactory
    {
        public MixedBase Provide(char currentBase)
        {
            switch(currentBase)
            {
                case 'N':
                    return new MixedBaseN();
                case 'M':
                    return new MixedBaseM();
                case 'K':
                    return new MixedBaseK();
                default:
                    return null;
            }
        }
    }
}