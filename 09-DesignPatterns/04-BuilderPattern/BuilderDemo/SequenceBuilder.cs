namespace BuilderDemo
{
    public class SequenceBuilder
    {
        public SequenceBuilder BaseA()
        {
            _sequence += "A";
            return this;
        }

        public SequenceBuilder BaseC()
        {
            _sequence += "C";
            return this;
        }

        public SequenceBuilder BaseG()
        {
            _sequence += "G";
            return this;
        }

        public SequenceBuilder BaseT()
        {
            _sequence += "T";
            return this;
        }

        public SequenceBuilder AminoAcidA()
        {
            _sequence += "GCA";
            return this;
        }

        public string Build()
        {
            return _sequence;
        }

        private string _sequence;
    }
}