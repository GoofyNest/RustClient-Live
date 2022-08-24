internal sealed class ReflectPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2741
{
	private static readonly Type[] argsNone; 
	private static readonly object noValue; 
	private static TraceSwitch PropDescCreateSwitch; 
	private static TraceSwitch PropDescUsageSwitch; 
	private static readonly int BitDefaultValueQueried; 
	private static readonly int BitGetQueried; 
	private static readonly int BitSetQueried; 
	private static readonly int BitShouldSerializeQueried; 
	private static readonly int BitResetQueried; 
	private static readonly int BitChangedQueried; 
	private static readonly int BitIPropChangedQueried; 
	private static readonly int BitReadOnlyChecked; 
	private static readonly int BitAmbientValueQueried; 
	private static readonly int BitSetOnDemand; 
	private BitVector32 state; 
	private Type componentClass; 
	private Type type; 
	private object defaultValue; 
	private PropertyInfo propInfo; 
	private MethodInfo getMethod; 
	private MethodInfo setMethod; 
	private MethodInfo shouldSerializeMethod; 
	private EventDescriptor realChangedEvent; 
	private Type receiverType; 

	public override Type ComponentType { get; }
	private object DefaultValue { get; }
	private MethodInfo GetMethodValue { get; }
	private bool IsExtender { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	private MethodInfo SetMethodValue { get; }
	private MethodInfo ShouldSerializeMethodValue { get; }


	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	public override Type get_ComponentType() { }

	private object get_DefaultValue() { }

	private MethodInfo get_GetMethodValue() { }

	private bool get_IsExtender() { }

	public override bool get_IsReadOnly() { }

	public override Type get_PropertyType() { }

	private MethodInfo get_SetMethodValue() { }

	private MethodInfo get_ShouldSerializeMethodValue() { }

	internal Type ExtenderGetReceiverType() { }

	internal Type ExtenderGetType(IExtenderProvider provider) { }

	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	protected override void FillAttributes(IList attributes) { }

	public override object GetValue(object component) { }

	protected override void OnValueChanged(object component, EventArgs e) { }

	public override void SetValue(object component, object value) { }

	public override bool ShouldSerializeValue(object component) { }

	private static void .cctor() { }

}

