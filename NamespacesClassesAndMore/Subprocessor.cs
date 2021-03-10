namespace NamespacesClassesAndMore
{
    internal class Subprocessor : Processor
    {
        public Subprocessor(string name) 
            : base(name)
        {
        }

        public void DoAThing()
        {
            Process("");

            Calculate();
            base.Calculate();
        }
    }
}