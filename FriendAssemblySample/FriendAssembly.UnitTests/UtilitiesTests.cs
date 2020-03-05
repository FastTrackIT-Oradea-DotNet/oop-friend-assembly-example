using FriendAssembly.SoftwareLibrary;
using Xunit;

namespace FriendAssembly.UnitTests
{
    public class UtilitiesTests
    {
        [Fact]
        public void ConvertToIntArray_Should_Return_Empty_Array_When_Input_Is_Null()
        {
            int[] result = Utilities.ConvertToIntArray(null);

            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void ConvertToIntArray_Should_Return_Empty_Array_When_Input_Is_Empty()
        {
            int[] result = Utilities.ConvertToIntArray(new string[0]);

            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void ConvertToIntArray_Should_Return_Empty_Array_When_Input_Has_Value()
        {
            int[] result = Utilities.ConvertToIntArray(new string[] { "123", "456" });

            Assert.NotNull(result);
            Assert.Equal(2, result.Length);
            Assert.Equal(123, result[0]);
            Assert.Equal(456, result[1]);
        }

        [Theory]
        [InlineData("123", 123)]
        [InlineData("-123", -123)]
        [InlineData(null, 0)]
        [InlineData("", 0)]
        [InlineData("    ", 0)]
        [InlineData("abc", 0)]
        public void ConvertToIntArray_StringConversions_Tests(string value, int expected)
        {
            int result = Utilities.ConvertStringToInt(value);

            Assert.Equal(expected, result);
        }
    }
}
