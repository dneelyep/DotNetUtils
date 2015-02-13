using System;

namespace DotNETUtils
{
    /// <summary>
    /// Represents a <see cref="String" /> with a minimum
    /// and maximum length.
    /// </summary>
    public class BoundedString
    {
        // TODO Regions.
        private string mstrValue;
        /// <summary>
        /// The contents of this <see cref="BoundedString" />
        /// </summary>
        public string Value
        {
            get
            {
                return mstrValue;
            }

            set
            {
                if (value == null && !AllowNull)
                {
                    throw new ArgumentNullException(String.Format("Provided string {0} is null, and null values " +
                                                                  "are not allowed.", value));
                }

                if (value.Length < MinLength)
                {
                    throw new ArgumentException(String.Format("Provided string {0} of length {1} contains less " +
                                                              "characters than the minimum allowed length {2}.",
                                                              value, value.Length, MinLength));
                }

                if (value.Length > MaxLength)
                {
                    throw new ArgumentException(String.Format("Provided string {0} of length {1} contains more " +
                                                              "characters than the maximum allowed length {2}.",
                                                              value, value.Length, MaxLength));
                }

                mstrValue = value;
            }
        }

        private int mintMinLength;

        /// <summary>
        /// The minimum number of characters in this <see cref="BoundedString" />.
        /// </summary>
        public int MinLength
        {
            get
            {
                return mintMinLength;
            }

            private set
            {
                mintMinLength = value;
            }
        }


        private int mintMaxLength;

        /// <summary>
        /// The maximum number of characters in this <see cref="BoundedString" />.
        /// </summary>

        public int MaxLength
        {
            get
            {
                return mintMaxLength;
            }

            set
            {
                mintMaxLength = value;
            }
        }

        private bool mblnAllowNull;
        /// <summary>
        /// Whether or not this <see cref="BoundedString" /> can represent a null value.
        /// </summary>
        public bool AllowNull
        {
            get
            {
                return mblnAllowNull;
            }

            private set
            {
                mblnAllowNull = value;
            }
        }

        // TODO Document these constructors.
        public BoundedString(string value,
                             int maxLength)
        {
            // TODO Constants.
            MinLength = 0;
            MaxLength = maxLength;
            AllowNull = false;

            Value = value;
        }

        public BoundedString(string value,
                             int minLength,
                             int maxLength)
        {
            MinLength = minLength;
            MaxLength = maxLength;
            AllowNull = false;

            Value = value;
        }

        public BoundedString(string strValue,
                             int minLength,
                             int maxLength,
                             bool allowNull)
        {
            MinLength = minLength;
            MaxLength = maxLength;
            AllowNull = allowNull;

            Value = strValue;
        }
    }
}