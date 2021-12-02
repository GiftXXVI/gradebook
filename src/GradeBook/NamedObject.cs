namespace GradeBook
{
    public class NamedObject
    {
        protected string name
        {
            get;
            set;
        }

        public NamedObject(string in_name)
        {
            this.name = in_name;
        }
    }
}