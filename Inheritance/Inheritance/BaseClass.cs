namespace Inheritance
{
    class BaseClass
    {
        public string publicField = "BaseClass.publicField";
        private string privateField = "BaseClass.privateField";
        protected string protectedField = "BaseClass.protectedField";

        public void Show()
        {
            System.Console.WriteLine(privateField);
        }
    }
}