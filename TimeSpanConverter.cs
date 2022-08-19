public class TimeSpanConverter : TypeConverter // TypeDefIndex: 2750
{	// Methods

	// RVA: 0x17301E0 Offset: 0x172F5E0 VA: 0x1817301E0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1730290 Offset: 0x172F690 VA: 0x181730290 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1730370 Offset: 0x172F770 VA: 0x181730370 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1730580 Offset: 0x172F980 VA: 0x181730580 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1730880 Offset: 0x172FC80 VA: 0x181730880
	public void .ctor() { }

}

internal static class TimeSpanConverter // TypeDefIndex: 7481
{	// Fields
	private static readonly Dictionary<TimeSpanType, Type> TimeSpansTypes; // 0x0
	private static readonly Dictionary<Type, ITimeSpanConverter> Converters; // 0x8

	// Methods

	// RVA: -1 Offset: -1
	public static TTimeSpan ConvertTo<TTimeSpan>(long timeSpan, long time, TempoMap tempoMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C0B80 Offset: 0x14BFF80 VA: 0x1814C0B80
	|-TimeSpanConverter.ConvertTo<object>
	*/

	// RVA: 0x21FD270 Offset: 0x21FC670 VA: 0x1821FD270
	public static ITimeSpan ConvertTo(ITimeSpan timeSpan, Type timeSpanType, long time, TempoMap tempoMap) { }

	// RVA: 0x21FD140 Offset: 0x21FC540 VA: 0x1821FD140
	public static long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	// RVA: -1 Offset: -1
	private static ITimeSpanConverter GetConverter<TTimeSpan>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1259BA0 Offset: 0x1258FA0 VA: 0x181259BA0
	|-TimeSpanConverter.GetConverter<object>
	*/

	// RVA: 0x21FD400 Offset: 0x21FC800 VA: 0x1821FD400
	private static ITimeSpanConverter GetConverter(Type timeSpanType) { }

	// RVA: 0x21FD4E0 Offset: 0x21FC8E0 VA: 0x1821FD4E0
	private static void .cctor() { }

}

