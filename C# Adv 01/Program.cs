namespace C__Adv_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //generic class is class that can work with any data type 
            //we are using generic because its save and it has good preformance 
            #endregion
            #region Question 3
            //same as single generic class parameter  you pass two generic values and it will be work with any data type
            #endregion
            #region Question 4 
            //generic method is method that can declare its own data type
            #endregion
            #region Question 5
            // it defines a contract with type parameters that must be implemented by any class that implements the interface.
            #endregion
            #region Question 7 
            // Struct constrain force the parameter to be value type 
            Question_7<int> q = new Question_7<int>();
            #endregion

            #region Question 8
            // class constrain force the parameter to be refernce type 
            Question8<string> p = new Question8<string>();
            #endregion

            #region Question 9
            // must have parameterless constractor 
            Question_9<int> q9 = new Question_9<int>(5);
            #endregion

            #region Question 10 
            //it means class must implement the interface and the interface is generic and it can work with any data type 
            Question_10<IRepository<string>> q10 = new Question_10<IRepository<string>>();
            #endregion

            #region 11
            // it forces subclass to inhiert from baseclass
            #endregion

            #region Question 12
            //it is possible to have multiple constraints on a generic type parameter in C#. You can specify multiple constraints using the where keyword,
            //separating each constraint with a comma. For example:
            Questiion_12 questiion = new Questiion_12("hello");
            #endregion

            #region Question 13
            //it return default value for type t 0/false for value type null for reference type
            #endregion
        }
    }
}
