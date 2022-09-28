public class TimeSpanConverter : TypeConverter // TypeDefIndex: 2750
{

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	public void .ctor() { }

}

internal static class TimeSpanConverter // TypeDefIndex: 7454
{
	private static readonly Dictionary<TimeSpanType, Type> TimeSpansTypes; 
	private static readonly Dictionary<Type, ITimeSpanConverter> Converters; 


	public static TTimeSpan ConvertTo<TTimeSpan>(long timeSpan, long time, TempoMap tempoMap) { }
	/* GenericInstMethod :
	|
	|-TimeSpanConverter.ConvertTo<object>
	*/

	public static ITimeSpan ConvertTo(ITimeSpan timeSpan, Type timeSpanType, long time, TempoMap tempoMap) { }

	public static long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap) { }

	private static ITimeSpanConverter GetConverter<TTimeSpan>() { }
	/* GenericInstMethod :
	|
	|-TimeSpanConverter.GetConverter<object>
	*/

	private static ITimeSpanConverter GetConverter(Type timeSpanType) { }

	private static void .cctor() { }

}

