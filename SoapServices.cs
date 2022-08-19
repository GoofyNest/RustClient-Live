public class SoapServices // TypeDefIndex: 1150
{	// Fields
	private static Hashtable _xmlTypes; // 0x0
	private static Hashtable _xmlElements; // 0x8
	private static Hashtable _soapActions; // 0x10
	private static Hashtable _soapActionsMethods; // 0x18
	private static Hashtable _typeInfos; // 0x20

	// Properties
	public static string XmlNsForClrTypeWithAssembly { get; }
	public static string XmlNsForClrTypeWithNs { get; }
	public static string XmlNsForClrTypeWithNsAndAssembly { get; }

	// Methods

	// RVA: 0x1200080 Offset: 0x11FF480 VA: 0x181200080
	public static string get_XmlNsForClrTypeWithAssembly() { }

	// RVA: 0x12000E0 Offset: 0x11FF4E0 VA: 0x1812000E0
	public static string get_XmlNsForClrTypeWithNs() { }

	// RVA: 0x12000B0 Offset: 0x11FF4B0 VA: 0x1812000B0
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	// RVA: 0x11FED20 Offset: 0x11FE120 VA: 0x1811FED20
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	// RVA: 0x11FF100 Offset: 0x11FE500 VA: 0x1811FF100
	private static string GetNameKey(string name, string namspace) { }

	// RVA: 0x11FEFB0 Offset: 0x11FE3B0 VA: 0x1811FEFB0
	private static string GetAssemblyName(MethodBase mb) { }

	// RVA: 0x11FF160 Offset: 0x11FE560 VA: 0x1811FF160
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	// RVA: 0x11FF270 Offset: 0x11FE670 VA: 0x1811FF270
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	// RVA: 0x11FF320 Offset: 0x11FE720 VA: 0x1811FF320
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	// RVA: 0x11FF3D0 Offset: 0x11FE7D0 VA: 0x1811FF3D0
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	// RVA: 0x11FF4C0 Offset: 0x11FE8C0 VA: 0x1811FF4C0
	public static void PreLoad(Assembly assembly) { }

	// RVA: 0x11FF580 Offset: 0x11FE980 VA: 0x1811FF580
	public static void PreLoad(Type type) { }

	// RVA: 0x11FFC10 Offset: 0x11FF010 VA: 0x1811FFC10
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	// RVA: 0x11FFDB0 Offset: 0x11FF1B0 VA: 0x1811FFDB0
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

	// RVA: 0x11FEF20 Offset: 0x11FE320 VA: 0x1811FEF20
	private static string EncodeNs(string ns) { }

	// RVA: 0x11FFF50 Offset: 0x11FF350 VA: 0x1811FFF50
	private static void .cctor() { }

}

private class SoapServices.TypeInfo // TypeDefIndex: 1151
{	// Fields
	public Hashtable Attributes; // 0x10
	public Hashtable Elements; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

