namespace PZ6
{
    internal class MyProperty
    {
        public int MyProperty1 {  
            get; 
            private set 
            {
                if(value == field)
                {
                    return;
                }
                field = value;
            } 
        }


        private int _myProperty;

        public int GetMyProperty()
        {
            return _myProperty;
        }

        private void SetMyProperty(int value)
        {
            if (value == _myProperty)
            {
                return;
            }
            
            _myProperty = value;
        }
    }
}
