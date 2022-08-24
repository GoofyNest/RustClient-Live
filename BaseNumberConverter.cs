public abstract class BaseNumberConverter : TypeConverter // TypeDefIndex: 2773
{
	internal virtual bool AllowHex { get; }
	internal abstract Type TargetType { get; }


	internal virtual bool get_AllowHex() { }

	internal abstract Type get_TargetType();

	internal abstract object FromString(string value, int radix);

	internal abstract object FromString(string value, NumberFormatInfo formatInfo);

	internal virtual Exception FromStringError(string failedText, Exception innerException) { }

	internal abstract string ToString(object value, NumberFormatInfo formatInfo);

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	public override bool CanConvertTo(ITypeDescriptorContext context, Type t) { }

	protected void .ctor() { }

}

