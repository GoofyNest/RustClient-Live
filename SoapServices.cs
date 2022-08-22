public class SoapServices // TypeDefIndex: 1150
{	private static Hashtable _xmlTypes; // 0x0
	private static Hashtable _xmlElements; // 0x8
	private static Hashtable _soapActions; // 0x10
	private static Hashtable _soapActionsMethods; // 0x18
	private static Hashtable _typeInfos; // 0x20

	public static string XmlNsForClrTypeWithAssembly { get; }
	public static string XmlNsForClrTypeWithNs { get; }
	public static string XmlNsForClrTypeWithNsAndAssembly { get; }


	public static string get_XmlNsForClrTypeWithAssembly() { }

	public static string get_XmlNsForClrTypeWithNs() { }

	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	private static string GetNameKey(string name, string namspace) { }

	private static string GetAssemblyName(MethodBase mb) { }

	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	public static void PreLoad(Assembly assembly) { }

	public static void PreLoad(Type type) { }

	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

	private static string EncodeNs(string ns) { }

	private static void .cctor() { }

}

private class SoapServices.TypeInfo // TypeDefIndex: 1151
{	public Hashtable Attributes; // 0x10
	public Hashtable Elements; // 0x18


	public void .ctor() { }

}

