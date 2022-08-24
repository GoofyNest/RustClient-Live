public class TypeConverter // TypeDefIndex: 2751
{
private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; 

private static bool UseCompatibleTypeConversion { get; }


private static bool get_UseCompatibleTypeConversion() { }

public bool CanConvertFrom(Type sourceType) { }

public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

public bool CanConvertTo(Type destinationType) { }

public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

public object ConvertFrom(object value) { }

public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

public object ConvertFromInvariantString(string text) { }

public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

public object ConvertFromString(string text) { }

public object ConvertFromString(ITypeDescriptorContext context, string text) { }

public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

public object ConvertTo(object value, Type destinationType) { }

public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

public string ConvertToInvariantString(object value) { }

public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

public string ConvertToString(object value) { }

public string ConvertToString(ITypeDescriptorContext context, object value) { }

public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

public object CreateInstance(IDictionary propertyValues) { }

public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

protected Exception GetConvertFromException(object value) { }

protected Exception GetConvertToException(object value, Type destinationType) { }

public bool GetCreateInstanceSupported() { }

public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

public PropertyDescriptorCollection GetProperties(object value) { }

public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

public bool GetPropertiesSupported() { }

public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

public ICollection GetStandardValues() { }

public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

public bool GetStandardValuesExclusive() { }

public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

public bool GetStandardValuesSupported() { }

public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

public bool IsValid(object value) { }

public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names) { }

public void .ctor() { }

private static void .cctor() { }

}

public class TypeConverter.StandardValuesCollection : ICollection, IEnumerable // TypeDefIndex: 2753
{
	private ICollection values; 
	private Array valueArray; 

public int Count { get; }
private int System.Collections.ICollection.Count { get; }
private object System.Collections.ICollection.SyncRoot { get; }


public void .ctor(ICollection values) { }

public int get_Count() { }

public void CopyTo(Array array, int index) { }

public IEnumerator GetEnumerator() { }

private int System.Collections.ICollection.get_Count() { }

private object System.Collections.ICollection.get_SyncRoot() { }

private void System.Collections.ICollection.CopyTo(Array array, int index) { }

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

