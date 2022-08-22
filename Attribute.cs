public abstract class Attribute // TypeDefIndex: 174
{	public virtual object TypeId { get; }


	private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit) { }

	private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit) { }

	private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit) { }

	private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit) { }

	private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit) { }

	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type) { }

	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit) { }

	public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit) { }

	public static bool IsDefined(MemberInfo element, Type attributeType) { }

	public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit) { }

	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit) { }

	public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit) { }

	public static Attribute[] GetCustomAttributes(Module element, bool inherit) { }

	public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit) { }

	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType) { }

	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit) { }

	public static Attribute[] GetCustomAttributes(Assembly element) { }

	public static Attribute[] GetCustomAttributes(Assembly element, bool inherit) { }

	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit) { }

	protected void .ctor() { }

	public override bool Equals(object obj) { }

	private static bool AreFieldValuesEqual(object thisValue, object thatValue) { }

	public override int GetHashCode() { }

	public virtual object get_TypeId() { }

	public virtual bool Match(object obj) { }

	public virtual bool IsDefaultAttribute() { }

}

public enum AttributeTargets // TypeDefIndex: 175
{	public int value__; // 0x0
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
{	internal AttributeTargets m_attributeTarget; // 0x10
	internal bool m_allowMultiple; // 0x14
	internal bool m_inherited; // 0x15
	internal static AttributeUsageAttribute Default; // 0x0

	public bool AllowMultiple { get; set; }
	public bool Inherited { get; set; }


	public void .ctor(AttributeTargets validOn) { }

	public bool get_AllowMultiple() { }

	public void set_AllowMultiple(bool value) { }

	public bool get_Inherited() { }

	public void set_Inherited(bool value) { }

	private static void .cctor() { }

}

internal enum AttributeProperties // TypeDefIndex: 1863
{	public uint value__; // 0x0
	public const AttributeProperties DEFAULT = 0;
	public const AttributeProperties URI = 1;
	public const AttributeProperties BOOLEAN = 2;
	public const AttributeProperties NAME = 4;

}

internal class AttributePSVIInfo // TypeDefIndex: 1943
{	internal string localName; // 0x10
	internal string namespaceUri; // 0x18
	internal object typedAttributeValue; // 0x20
	internal XmlSchemaInfo attributeSchemaInfo; // 0x28


	internal void .ctor() { }

	internal void Reset() { }

}

internal enum AttributeMatchState // TypeDefIndex: 2279
{	public int value__; // 0x0
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
{	public static readonly AttributeCollection Empty; // 0x0
	private static Hashtable _defaultAttributes; // 0x8
	private Attribute[] _attributes; // 0x10
	private static object internalSyncObject; // 0x10
	private AttributeCollection.AttributeEntry[] _foundAttributeTypes; // 0x18
	private int _index; // 0x20

	protected virtual Attribute[] Attributes { get; }
	public int Count { get; }
	public virtual Attribute Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }


	public void .ctor(Attribute[] attributes) { }

	protected virtual Attribute[] get_Attributes() { }

	public int get_Count() { }

	public virtual Attribute get_Item(Type attributeType) { }

	public bool Contains(Attribute attribute) { }

	protected Attribute GetDefaultAttribute(Type attributeType) { }

	public IEnumerator GetEnumerator() { }

	private int System.Collections.ICollection.get_Count() { }

	private object System.Collections.ICollection.get_SyncRoot() { }

	public void CopyTo(Array array, int index) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private static void .cctor() { }

}

private struct AttributeCollection.AttributeEntry // TypeDefIndex: 2667
{	public Type type; // 0x0
	public int index; // 0x8

}

public class AttributeProviderAttribute : Attribute // TypeDefIndex: 2668
{	private string _typeName; // 0x10
	private string _propertyName; // 0x18

	public string TypeName { get; }
	public string PropertyName { get; }


	public string get_TypeName() { }

	public string get_PropertyName() { }

}

internal class AttributeHelperEngine // TypeDefIndex: 3492
{	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10


	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Type[] GetRequiredComponents(Type klass) { }

	private static int GetExecuteMode(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static int CheckIsEditorScript(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	private static T GetCustomAttributeOfType<T>(Type klass) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A3EA0 Offset: 0x14A32A0 VA: 0x1814A3EA0
	|-AttributeHelperEngine.GetCustomAttributeOfType<object>
	|-AttributeHelperEngine.GetCustomAttributeOfType<DefaultExecutionOrder>
	*/

	private static void .cctor() { }

}

