internal static class ThrowIfArgument // TypeDefIndex: 7637
{	// Methods

	// RVA: 0x13A3B00 Offset: 0x13A2F00 VA: 0x1813A3B00
	internal static void IsNull(string parameterName, object argument) { }

	// RVA: -1 Offset: -1
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

	// RVA: 0x13A3B70 Offset: 0x13A2F70 VA: 0x1813A3B70
	internal static void IsOutOfRange(string parameterName, int value, int min, int max, string message) { }

	// RVA: 0x13A3C20 Offset: 0x13A3020 VA: 0x1813A3C20
	internal static void IsOutOfRange(string parameterName, long value, long min, long max, string message) { }

	// RVA: 0x13A3CD0 Offset: 0x13A30D0 VA: 0x1813A3CD0
	internal static void IsOutOfRange(string parameterName, double value, double min, double max, string message) { }

	// RVA: 0x13A3650 Offset: 0x13A2A50 VA: 0x1813A3650
	internal static void DoesntSatisfyCondition(string parameterName, int value, Predicate<int> condition, string message) { }

	// RVA: 0x13A3710 Offset: 0x13A2B10 VA: 0x1813A3710
	internal static void IsGreaterThan(string parameterName, int value, int reference, string message) { }

	// RVA: 0x13A37B0 Offset: 0x13A2BB0 VA: 0x1813A37B0
	internal static void IsLessThan(string parameterName, int value, int reference, string message) { }

	// RVA: 0x13A37E0 Offset: 0x13A2BE0 VA: 0x1813A37E0
	internal static void IsLessThan(string parameterName, long value, long reference, string message) { }

	// RVA: 0x13A3810 Offset: 0x13A2C10 VA: 0x1813A3810
	internal static void IsLessThan(string parameterName, double value, double reference, string message) { }

	// RVA: 0x13A38E0 Offset: 0x13A2CE0 VA: 0x1813A38E0
	internal static void IsNegative(string parameterName, int value, string message) { }

	// RVA: 0x13A39D0 Offset: 0x13A2DD0 VA: 0x1813A39D0
	internal static void IsNegative(string parameterName, long value, string message) { }

	// RVA: 0x13A3910 Offset: 0x13A2D10 VA: 0x1813A3910
	internal static void IsNegative(string parameterName, double value, string message) { }

	// RVA: 0x13A3A30 Offset: 0x13A2E30 VA: 0x1813A3A30
	internal static void IsNonpositive(string parameterName, int value, string message) { }

	// RVA: 0x13A3A00 Offset: 0x13A2E00 VA: 0x1813A3A00
	internal static void IsNonpositive(string parameterName, long value, string message) { }

	// RVA: 0x13A3A60 Offset: 0x13A2E60 VA: 0x1813A3A60
	internal static void IsNullOrWhiteSpaceString(string parameterName, string value, string stringDescription) { }

	// RVA: 0x13A3740 Offset: 0x13A2B40 VA: 0x1813A3740
	internal static void IsInvalidIndex(string parameterName, int index, int collectionSize) { }

	// RVA: -1 Offset: -1
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

