public abstract class BaseNumberConverter : TypeConverter // TypeDefIndex: 2773
{	// Properties
	internal virtual bool AllowHex { get; }
	internal abstract Type TargetType { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 16
	internal virtual bool get_AllowHex() { }

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Type get_TargetType();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract object FromString(string value, int radix);

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract object FromString(string value, NumberFormatInfo formatInfo);

	// RVA: 0x1598BF0 Offset: 0x1597FF0 VA: 0x181598BF0 Slot: 20
	internal virtual Exception FromStringError(string failedText, Exception innerException) { }

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract string ToString(object value, NumberFormatInfo formatInfo);

	// RVA: 0x1598590 Offset: 0x1597990 VA: 0x181598590 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1598680 Offset: 0x1597A80 VA: 0x181598680 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1598970 Offset: 0x1597D70 VA: 0x181598970 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1598640 Offset: 0x1597A40 VA: 0x181598640 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type t) { }

	// RVA: 0x1598DC0 Offset: 0x15981C0 VA: 0x181598DC0
	protected void .ctor() { }

}

