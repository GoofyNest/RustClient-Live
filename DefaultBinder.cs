internal class DefaultBinder : Binder // TypeDefIndex: 203
{	// Methods

	// RVA: 0xD65180 Offset: 0xD64580 VA: 0x180D65180 Slot: 4
	public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state) { }

	// RVA: 0xD64970 Offset: 0xD63D70 VA: 0x180D64970 Slot: 5
	public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

	// RVA: 0xD69F00 Offset: 0xD69300 VA: 0x180D69F00 Slot: 6
	public override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0xD6A750 Offset: 0xD69B50 VA: 0x180D6A750 Slot: 7
	public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

	// RVA: 0xD68150 Offset: 0xD67550 VA: 0x180D68150 Slot: 8
	public override object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

	// RVA: 0xD699C0 Offset: 0xD68DC0 VA: 0x180D699C0 Slot: 9
	public override void ReorderArgumentArray(ref object[] args, object state) { }

	// RVA: 0xD685B0 Offset: 0xD679B0 VA: 0x180D685B0
	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0xD68940 Offset: 0xD67D40 VA: 0x180D68940
	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0xD694B0 Offset: 0xD688B0 VA: 0x180D694B0
	private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0xD690C0 Offset: 0xD684C0 VA: 0x180D690C0
	private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

	// RVA: 0xD68E60 Offset: 0xD68260 VA: 0x180D68E60
	private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0xD68D80 Offset: 0xD68180 VA: 0x180D68D80
	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

	// RVA: 0xD68D80 Offset: 0xD68180 VA: 0x180D68D80
	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

	// RVA: 0xD681C0 Offset: 0xD675C0 VA: 0x180D681C0
	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

	// RVA: 0xD69930 Offset: 0xD68D30 VA: 0x180D69930
	internal static int GetHierarchyDepth(Type t) { }

	// RVA: 0xD68C60 Offset: 0xD68060 VA: 0x180D68C60
	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

	// RVA: 0xD69D30 Offset: 0xD69130 VA: 0x180D69D30
	private static void ReorderParams(int[] paramOrder, object[] vars) { }

	// RVA: 0xD68340 Offset: 0xD67740 VA: 0x180D68340
	private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names) { }

	// RVA: 0xD67EF0 Offset: 0xD672F0 VA: 0x180D67EF0
	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

	// RVA: 0xD67DF0 Offset: 0xD671F0 VA: 0x180D67DF0
	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

internal class DefaultBinder.BinderState // TypeDefIndex: 204
{	// Fields
	internal int[] m_argsMap; // 0x10
	internal int m_originalSize; // 0x18
	internal bool m_isParamArray; // 0x1C

	// Methods

	// RVA: 0xD63070 Offset: 0xD62470 VA: 0x180D63070
	internal void .ctor(int[] argsMap, int originalSize, bool isParamArray) { }

}

private sealed class DefaultBinder.<>c // TypeDefIndex: 205
{	// Fields
	public static readonly DefaultBinder.<>c <>9; // 0x0
	public static Predicate<Type> <>9__3_0; // 0x8

	// Methods

	// RVA: 0xD827F0 Offset: 0xD81BF0 VA: 0x180D827F0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xD82520 Offset: 0xD81920 VA: 0x180D82520
	internal bool <SelectProperty>b__3_0(Type t) { }

}

