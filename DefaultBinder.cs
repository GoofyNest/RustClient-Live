internal class DefaultBinder : Binder // TypeDefIndex: 203
{

public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state) { }

public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

public override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

public override object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

public override void ReorderArgumentArray(ref object[] args, object state) { }

public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

internal static int GetHierarchyDepth(Type t) { }

internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

private static void ReorderParams(int[] paramOrder, object[] vars) { }

private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names) { }

private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

public void .ctor() { }

}

internal class DefaultBinder.BinderState // TypeDefIndex: 204
{
	internal int[] m_argsMap; 
	internal int m_originalSize; 
	internal bool m_isParamArray; 


internal void .ctor(int[] argsMap, int originalSize, bool isParamArray) { }

}

private sealed class DefaultBinder.<>c // TypeDefIndex: 205
{
	public static readonly DefaultBinder.<>c <>9; 
	public static Predicate<Type> <>9__3_0; 


private static void .cctor() { }

public void .ctor() { }

internal bool <SelectProperty>b__3_0(Type t) { }

}

