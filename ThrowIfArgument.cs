internal static class ThrowIfArgument // TypeDefIndex: 7637
{
	internal static void IsNull(string parameterName, object argument) { }

	internal static void IsInvalidEnumValue<TEnum>(string parameterName, TEnum argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x154B080 Offset: 0x154A480 VA: 0x18154B080
	|-ThrowIfArgument.IsInvalidEnumValue<SmpteFormat>
	|-ThrowIfArgument.IsInvalidEnumValue<MidiTimeCodeComponent>
	|-ThrowIfArgument.IsInvalidEnumValue<ByteEnum>
	|
	|-RVA: 0x154B210 Offset: 0x154A610 VA: 0x18154B210
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
	|-RVA: 0x154B3A0 Offset: 0x154A7A0 VA: 0x18154B3A0
	|-ThrowIfArgument.StartsWithInvalidValue<byte>
	|
	|-RVA: 0x154B480 Offset: 0x154A880 VA: 0x18154B480
	|-ThrowIfArgument.StartsWithInvalidValue<object>
	*/

}

