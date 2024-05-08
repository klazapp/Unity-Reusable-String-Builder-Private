using System.Runtime.CompilerServices;
using System.Text;

namespace com.Klazapp.Utility
{
    [ScriptHeader("ReusableStringBuilder improves performance on string concatenation by reusing a single string builder for multiple usages")]
    public class ReusableStringBuilder : MonoSingletonGlobal<ReusableStringBuilder>
    {
        #region Variables
        private readonly StringBuilder reusableStringBuilder = new();
        #endregion

        #region Public Access
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string StringBuilderReuse(string firstParam, string secondParam)
        {
            reusableStringBuilder.Clear();
            reusableStringBuilder.Append(firstParam);
            reusableStringBuilder.Append(secondParam);
            var stringVal = reusableStringBuilder.ToString();
            return stringVal;
        }
        #endregion
    }
}