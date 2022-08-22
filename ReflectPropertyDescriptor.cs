internal sealed class ReflectPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2741
{	private static readonly Type[] argsNone; // 0x0
	private static readonly object noValue; // 0x8
	private static TraceSwitch PropDescCreateSwitch; // 0x10
	private static TraceSwitch PropDescUsageSwitch; // 0x18
	private static readonly int BitDefaultValueQueried; // 0x20
	private static readonly int BitGetQueried; // 0x24
	private static readonly int BitSetQueried; // 0x28
	private static readonly int BitShouldSerializeQueried; // 0x2C
	private static readonly int BitResetQueried; // 0x30
	private static readonly int BitChangedQueried; // 0x34
	private static readonly int BitIPropChangedQueried; // 0x38
	private static readonly int BitReadOnlyChecked; // 0x3C
	private static readonly int BitAmbientValueQueried; // 0x40
	private static readonly int BitSetOnDemand; // 0x44
	private BitVector32 state; // 0x88
	private Type componentClass; // 0x90
	private Type type; // 0x98
	private object defaultValue; // 0xA0
	private PropertyInfo propInfo; // 0xA8
	private MethodInfo getMethod; // 0xB0
	private MethodInfo setMethod; // 0xB8
	private MethodInfo shouldSerializeMethod; // 0xC0
	private EventDescriptor realChangedEvent; // 0xC8
	private Type receiverType; // 0xD0

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

