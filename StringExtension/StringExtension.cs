using System.Runtime.InteropServices;
using System.Text;

namespace StringExtension
{
    /// <summary>
    /// Gives extension methods for double type
    /// </summary>
    public static class NumberRepresentationConverter
    {
        /// <summary>
        /// Gets string representation of double in IEEE754 format
        /// </summary>
        /// <param name="number">
        /// Double number 
        /// </param>
        /// <returns>
        /// String representation of number
        /// </returns>
        public static string DoubleToBinaryString(this double number)
        {
            DoubleToLongStruct d = new DoubleToLongStruct(number);
            StringBuilder sb = new StringBuilder();

            if (number > 0)
            {
                sb.Append(0);
            }
            else
            {
                sb.Append(1);
            }

            sb.Append(d.Long64Bits.ToBinary());
            return sb.ToString();
        }

        /// <summary>
        /// Struct to work with memory allocation
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        private struct DoubleToLongStruct
        {
            [FieldOffset(0)]
            private readonly long long64bits;

            [FieldOffset(0)]
            private double double64bits;

            public long Long64Bits => long64bits;

           /// <summary>
           /// Construction to set the value of number
           /// </summary>
           /// <param name="val">
           /// Exact value
           /// </param>
            public DoubleToLongStruct(double val) : this()
            {
                this.double64bits = val;
            }
        }
    }
}
