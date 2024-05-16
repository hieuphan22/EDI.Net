namespace Scm.Common.Domain.Shared.Attributes
{
    public class StringValueAttribute : System.Attribute
    {
        /// <summary>
        /// Holds the stringvalue for a value in an enum.
        /// </summary>
        private string _value;

        /// <summary>
        /// Creates a new <see cref="StringValueAttribute"/> instance.
        /// </summary>
        /// <param name="value"></param>
        public StringValueAttribute(string value)
        {
            _value = value;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        public string StringValue
        {
            get
            {
                return _value;
            }
        }
    }
}
