internal static class ThrowIfArgument // TypeDefIndex: 7637
{

	internal static void IsNull(string parameterName, object argument) { }

	internal static void IsInvalidEnumValue<TEnum>(string parameterName, TEnum argument) { }
	/* GenericInstMethod :
	|
	|-ThrowIfArgument.IsInvalidEnumValue<SmpteFormat>
	|-ThrowIfArgument.IsInvalidEnumValue<MidiTimeCodeComponent>
	|-ThrowIfArgument.IsInvalidEnumValue<ByteEnum>
	|
	|-ThrowIfArgument.IsInvalidEnumValue<TimeSpanMode>
	|-ThrowIfArgument.IsInvalidEnumValue<Int32Enum>
	*/

	internal static void IsOutOfRange(string parameterName, int value, int min, int max, string message) { }

	internal static void IsOutOfRange(string parameterName, long value, long min, long max, string message) { }

	internal static void IsOutOfRange(string parameterName, double value, double min, double max, string message) { }

	internal static void DoesntSatisfyCondition(string parameterName, int value, Predicate<int> condition, string message) { }

	internal static void IsGreaterThan(string parameterName, int value, int reference, string message) { }

	internal static void IsLessThan(string parameterName, int value, int reference, string message) { }

	internal static void IsLessThan(string parameterName, long value, long reference, string message) { }

	internal static void IsLessThan(string parameterName, double value, double reference, string message) { }

	internal static void IsNegative(string parameterName, int value, string message) { }

	internal static void IsNegative(string parameterName, long value, string message) { }

	internal static void IsNegative(string parameterName, double value, string message) { }

	internal static void IsNonpositive(string parameterName, int value, string message) { }

	internal static void IsNonpositive(string parameterName, long value, string message) { }

	internal static void IsNullOrWhiteSpaceString(string parameterName, string value, string stringDescription) { }

	internal static void IsInvalidIndex(string parameterName, int index, int collectionSize) { }

	internal static void StartsWithInvalidValue<T>(string parameterName, IEnumerable<T> collection, T invalidValue, string message) { }
	/* GenericInstMethod :
	|
	|-ThrowIfArgument.StartsWithInvalidValue<byte>
	|
	|-ThrowIfArgument.StartsWithInvalidValue<object>
	*/

}

