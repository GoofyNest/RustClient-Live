public class TypeConverter // TypeDefIndex: 2751
{	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; // 0x13723

	// Properties
	private static bool UseCompatibleTypeConversion { get; }

	// Methods

	// RVA: 0x1734820 Offset: 0x1733C20 VA: 0x181734820
	private static bool get_UseCompatibleTypeConversion() { }

	// RVA: 0x1733720 Offset: 0x1732B20 VA: 0x181733720
	public bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x17336A0 Offset: 0x1732AA0 VA: 0x1817336A0 Slot: 4
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x17337B0 Offset: 0x1732BB0 VA: 0x1817337B0
	public bool CanConvertTo(Type destinationType) { }

	// RVA: 0x1733740 Offset: 0x1732B40 VA: 0x181733740 Slot: 5
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x17339A0 Offset: 0x1732DA0 VA: 0x1817339A0
	public object ConvertFrom(object value) { }

	// RVA: 0x1733A20 Offset: 0x1732E20 VA: 0x181733A20 Slot: 6
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1733860 Offset: 0x1732C60 VA: 0x181733860
	public object ConvertFromInvariantString(string text) { }

	// RVA: 0x17337D0 Offset: 0x1732BD0 VA: 0x1817337D0
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x1733970 Offset: 0x1732D70 VA: 0x181733970
	public object ConvertFromString(string text) { }

	// RVA: 0x17338E0 Offset: 0x1732CE0 VA: 0x1817338E0
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x13968C0 Offset: 0x1395CC0 VA: 0x1813968C0
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x1733E70 Offset: 0x1733270 VA: 0x181733E70
	public object ConvertTo(object value, Type destinationType) { }

	// RVA: 0x1733EA0 Offset: 0x17332A0 VA: 0x181733EA0 Slot: 7
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1733B20 Offset: 0x1732F20 VA: 0x181733B20
	public string ConvertToInvariantString(object value) { }

	// RVA: 0x1733A90 Offset: 0x1732E90 VA: 0x181733A90
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1733C80 Offset: 0x1733080 VA: 0x181733C80
	public string ConvertToString(object value) { }

	// RVA: 0x1733D70 Offset: 0x1733170 VA: 0x181733D70
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1733BA0 Offset: 0x1732FA0 VA: 0x181733BA0
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x17340A0 Offset: 0x17334A0 VA: 0x1817340A0
	public object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 8
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x17340C0 Offset: 0x17334C0 VA: 0x1817340C0
	protected Exception GetConvertFromException(object value) { }

	// RVA: 0x1734200 Offset: 0x1733600 VA: 0x181734200
	protected Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x1734380 Offset: 0x1733780 VA: 0x181734380
	public bool GetCreateInstanceSupported() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x17343C0 Offset: 0x17337C0 VA: 0x1817343C0
	public PropertyDescriptorCollection GetProperties(object value) { }

	// RVA: 0x17344D0 Offset: 0x17338D0 VA: 0x1817344D0
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 10
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x17343A0 Offset: 0x17337A0 VA: 0x1817343A0
	public bool GetPropertiesSupported() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 11
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1734630 Offset: 0x1733A30 VA: 0x181734630
	public ICollection GetStandardValues() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 12
	public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x17345F0 Offset: 0x17339F0 VA: 0x1817345F0
	public bool GetStandardValuesExclusive() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 13
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1734610 Offset: 0x1733A10 VA: 0x181734610
	public bool GetStandardValuesSupported() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 14
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1734650 Offset: 0x1733A50 VA: 0x181734650
	public bool IsValid(object value) { }

	// RVA: 0x1734670 Offset: 0x1733A70 VA: 0x181734670 Slot: 15
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x17347E0 Offset: 0x1733BE0 VA: 0x1817347E0
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class TypeConverter.StandardValuesCollection : ICollection, IEnumerable // TypeDefIndex: 2753
{	// Fields
	private ICollection values; // 0x10
	private Array valueArray; // 0x18

	// Properties
	public int Count { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x172F070 Offset: 0x172E470 VA: 0x18172F070
	public void .ctor(ICollection values) { }

	// RVA: 0x172F010 Offset: 0x172E410 VA: 0x18172F010
	public int get_Count() { }

	// RVA: 0x172EF50 Offset: 0x172E350 VA: 0x18172EF50
	public void CopyTo(Array array, int index) { }

	// RVA: 0x172EFC0 Offset: 0x172E3C0 VA: 0x18172EFC0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x172F010 Offset: 0x172E410 VA: 0x18172F010 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x172EF50 Offset: 0x172E350 VA: 0x18172EF50 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x172EFC0 Offset: 0x172E3C0 VA: 0x18172EFC0 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

