public abstract class Attribute // TypeDefIndex: 174
{	// Properties
	public virtual object TypeId { get; }

	// Methods

	// RVA: 0x158AAB0 Offset: 0x1589EB0 VA: 0x18158AAB0
	private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit) { }

	// RVA: 0x158AA10 Offset: 0x1589E10 VA: 0x18158AA10
	private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit) { }

	// RVA: 0x158AC50 Offset: 0x158A050 VA: 0x18158AC50
	private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit) { }

	// RVA: 0x158AB50 Offset: 0x1589F50 VA: 0x18158AB50
	private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x158ABD0 Offset: 0x1589FD0 VA: 0x18158ABD0
	private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x1589720 Offset: 0x1588B20 VA: 0x181589720
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type) { }

	// RVA: 0x1589BB0 Offset: 0x1588FB0 VA: 0x181589BB0
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit) { }

	// RVA: 0x1589E90 Offset: 0x1589290 VA: 0x181589E90
	public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit) { }

	// RVA: 0x158B400 Offset: 0x158A800 VA: 0x18158B400
	public static bool IsDefined(MemberInfo element, Type attributeType) { }

	// RVA: 0x158B0E0 Offset: 0x158A4E0 VA: 0x18158B0E0
	public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x15895B0 Offset: 0x15889B0 VA: 0x1815895B0
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	// RVA: 0x1589440 Offset: 0x1588840 VA: 0x181589440
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x158A1C0 Offset: 0x15895C0 VA: 0x18158A1C0
	public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x158A6A0 Offset: 0x1589AA0 VA: 0x18158A6A0
	public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit) { }

	// RVA: 0x158A570 Offset: 0x1589970 VA: 0x18158A570
	public static Attribute[] GetCustomAttributes(Module element, bool inherit) { }

	// RVA: 0x1589960 Offset: 0x1588D60 VA: 0x181589960
	public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit) { }

	// RVA: 0x158A840 Offset: 0x1589C40 VA: 0x18158A840
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType) { }

	// RVA: 0x1589730 Offset: 0x1588B30 VA: 0x181589730
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x158A470 Offset: 0x1589870 VA: 0x18158A470
	public static Attribute[] GetCustomAttributes(Assembly element) { }

	// RVA: 0x158A0B0 Offset: 0x15894B0 VA: 0x18158A0B0
	public static Attribute[] GetCustomAttributes(Assembly element, bool inherit) { }

	// RVA: 0x1589500 Offset: 0x1588900 VA: 0x181589500
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	// RVA: 0x1589660 Offset: 0x1588A60 VA: 0x181589660
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x1589110 Offset: 0x1588510 VA: 0x181589110 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1588F00 Offset: 0x1588300 VA: 0x181588F00
	private static bool AreFieldValuesEqual(object thisValue, object thatValue) { }

	// RVA: 0x158A850 Offset: 0x1589C50 VA: 0x18158A850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10D7550 Offset: 0x10D6950 VA: 0x1810D7550 Slot: 4
	public virtual object get_TypeId() { }

	// RVA: 0x158B410 Offset: 0x158A810 VA: 0x18158B410 Slot: 5
	public virtual bool Match(object obj) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 6
	public virtual bool IsDefaultAttribute() { }

}

public enum AttributeTargets // TypeDefIndex: 175
{	// Fields
	public int value__; // 0x0
	public const AttributeTargets Assembly = 1;
	public const AttributeTargets Module = 2;
	public const AttributeTargets Class = 4;
	public const AttributeTargets Struct = 8;
	public const AttributeTargets Enum = 16;
	public const AttributeTargets Constructor = 32;
	public const AttributeTargets Method = 64;
	public const AttributeTargets Property = 128;
	public const AttributeTargets Field = 256;
	public const AttributeTargets Event = 512;
	public const AttributeTargets Interface = 1024;
	public const AttributeTargets Parameter = 2048;
	public const AttributeTargets Delegate = 4096;
	public const AttributeTargets ReturnValue = 8192;
	public const AttributeTargets GenericParameter = 16384;
	public const AttributeTargets All = 32767;

}

public sealed class AttributeUsageAttribute : Attribute // TypeDefIndex: 176
{	// Fields
	internal AttributeTargets m_attributeTarget; // 0x10
	internal bool m_allowMultiple; // 0x14
	internal bool m_inherited; // 0x15
	internal static AttributeUsageAttribute Default; // 0x0

	// Properties
	public bool AllowMultiple { get; set; }
	public bool Inherited { get; set; }

	// Methods

	// RVA: 0x1588EC0 Offset: 0x15882C0 VA: 0x181588EC0
	public void .ctor(AttributeTargets validOn) { }

	// RVA: 0x9EF9E0 Offset: 0x9EEDE0 VA: 0x1809EF9E0
	public bool get_AllowMultiple() { }

	// RVA: 0x9EFA00 Offset: 0x9EEE00 VA: 0x1809EFA00
	public void set_AllowMultiple(bool value) { }

	// RVA: 0x139FE10 Offset: 0x139F210 VA: 0x18139FE10
	public bool get_Inherited() { }

	// RVA: 0x1588EF0 Offset: 0x15882F0 VA: 0x181588EF0
	public void set_Inherited(bool value) { }

	// RVA: 0x1588E50 Offset: 0x1588250 VA: 0x181588E50
	private static void .cctor() { }

}

internal enum AttributeProperties // TypeDefIndex: 1863
{	// Fields
	public uint value__; // 0x0
	public const AttributeProperties DEFAULT = 0;
	public const AttributeProperties URI = 1;
	public const AttributeProperties BOOLEAN = 2;
	public const AttributeProperties NAME = 4;

}

internal class AttributePSVIInfo // TypeDefIndex: 1943
{	// Fields
	internal string localName; // 0x10
	internal string namespaceUri; // 0x18
	internal object typedAttributeValue; // 0x20
	internal XmlSchemaInfo attributeSchemaInfo; // 0x28

	// Methods

	// RVA: 0x12D7FA0 Offset: 0x12D73A0 VA: 0x1812D7FA0
	internal void .ctor() { }

	// RVA: 0x12D7F10 Offset: 0x12D7310 VA: 0x1812D7F10
	internal void Reset() { }

}

internal enum AttributeMatchState // TypeDefIndex: 2279
{	// Fields
	public int value__; // 0x0
	public const AttributeMatchState AttributeFound = 0;
	public const AttributeMatchState AnyIdAttributeFound = 1;
	public const AttributeMatchState UndeclaredElementAndAttribute = 2;
	public const AttributeMatchState UndeclaredAttribute = 3;
	public const AttributeMatchState AnyAttributeLax = 4;
	public const AttributeMatchState AnyAttributeSkip = 5;
	public const AttributeMatchState ProhibitedAnyAttribute = 6;
	public const AttributeMatchState ProhibitedAttribute = 7;
	public const AttributeMatchState AttributeNameMismatch = 8;
	public const AttributeMatchState ValidateAttributeInvalidCall = 9;

}

public class AttributeCollection : ICollection, IEnumerable // TypeDefIndex: 2666
{	// Fields
	public static readonly AttributeCollection Empty; // 0x0
	private static Hashtable _defaultAttributes; // 0x8
	private Attribute[] _attributes; // 0x10
	private static object internalSyncObject; // 0x10
	private AttributeCollection.AttributeEntry[] _foundAttributeTypes; // 0x18
	private int _index; // 0x20

	// Properties
	protected virtual Attribute[] Attributes { get; }
	public int Count { get; }
	public virtual Attribute Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x1597F00 Offset: 0x1597300 VA: 0x181597F00
	public void .ctor(Attribute[] attributes) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 8
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0x1597E30 Offset: 0x1597230 VA: 0x181597E30
	public int get_Count() { }

	// RVA: 0x1597FE0 Offset: 0x15973E0 VA: 0x181597FE0 Slot: 9
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0x15977D0 Offset: 0x1596BD0 VA: 0x1815977D0
	public bool Contains(Attribute attribute) { }

	// RVA: 0x15978E0 Offset: 0x1596CE0 VA: 0x1815978E0
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x1597E00 Offset: 0x1597200 VA: 0x181597E00
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1597E30 Offset: 0x1597230 VA: 0x181597E30 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1597850 Offset: 0x1596C50 VA: 0x181597850 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1597E00 Offset: 0x1597200 VA: 0x181597E00 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1597E60 Offset: 0x1597260 VA: 0x181597E60
	private static void .cctor() { }

}

private struct AttributeCollection.AttributeEntry // TypeDefIndex: 2667
{	// Fields
	public Type type; // 0x0
	public int index; // 0x8

}

public class AttributeProviderAttribute : Attribute // TypeDefIndex: 2668
{	// Fields
	private string _typeName; // 0x10
	private string _propertyName; // 0x18

	// Properties
	public string TypeName { get; }
	public string PropertyName { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_TypeName() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_PropertyName() { }

}

internal class AttributeHelperEngine // TypeDefIndex: 3492
{	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1819E60 Offset: 0x1819260 VA: 0x181819E60
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1819F40 Offset: 0x1819340 VA: 0x181819F40
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x1819D60 Offset: 0x1819160 VA: 0x181819D60
	private static int GetExecuteMode(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1819C30 Offset: 0x1819030 VA: 0x181819C30
	private static int CheckIsEditorScript(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1819CF0 Offset: 0x18190F0 VA: 0x181819CF0
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: -1 Offset: -1
	private static T GetCustomAttributeOfType<T>(Type klass) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A3EA0 Offset: 0x14A32A0 VA: 0x1814A3EA0
	|-AttributeHelperEngine.GetCustomAttributeOfType<object>
	|-AttributeHelperEngine.GetCustomAttributeOfType<DefaultExecutionOrder>
	*/

	// RVA: 0x181A300 Offset: 0x1819700 VA: 0x18181A300
	private static void .cctor() { }

}

