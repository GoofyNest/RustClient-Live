public class SoapServices // TypeDefIndex: 1150
{
	private static Hashtable _xmlTypes; 
	private static Hashtable _xmlElements; 
	private static Hashtable _soapActions; 
	private static Hashtable _soapActionsMethods; 
	private static Hashtable _typeInfos; 

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
{
	public Hashtable Attributes; 
	public Hashtable Elements; 


	public void .ctor() { }

}

