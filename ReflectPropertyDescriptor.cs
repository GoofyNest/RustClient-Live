internal sealed class ReflectPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2741
{	// Fields
	private static readonly Type[] argsNone; // 0x0
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

	// Properties
	public override Type ComponentType { get; }
	private object DefaultValue { get; }
	private MethodInfo GetMethodValue { get; }
	private bool IsExtender { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	private MethodInfo SetMethodValue { get; }
	private MethodInfo ShouldSerializeMethodValue { get; }

	// Methods

	// RVA: 0x15B01D0 Offset: 0x15AF5D0 VA: 0x1815B01D0
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x15B0070 Offset: 0x15AF470 VA: 0x1815B0070
	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x15B03D0 Offset: 0x15AF7D0 VA: 0x1815B03D0
	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x15B04C0 Offset: 0x15AF8C0 VA: 0x1815B04C0
	private object get_DefaultValue() { }

	// RVA: 0x15B0810 Offset: 0x15AFC10 VA: 0x1815B0810
	private MethodInfo get_GetMethodValue() { }

	// RVA: 0x15B0CF0 Offset: 0x15B00F0 VA: 0x1815B0CF0
	private bool get_IsExtender() { }

	// RVA: 0x15B0D50 Offset: 0x15B0150 VA: 0x1815B0D50 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x15B0E40 Offset: 0x15B0240 VA: 0x1815B0E40
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0x15B14D0 Offset: 0x15B08D0 VA: 0x1815B14D0
	private MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0xC53130 Offset: 0xC52530 VA: 0x180C53130
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0x15ADF60 Offset: 0x15AD360 VA: 0x1815ADF60
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x15ADF80 Offset: 0x15AD380 VA: 0x1815ADF80
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x15AE0E0 Offset: 0x15AD4E0 VA: 0x1815AE0E0
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x15AE420 Offset: 0x15AD820 VA: 0x1815AE420
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x15AE810 Offset: 0x15ADC10 VA: 0x1815AE810 Slot: 11
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x15AF300 Offset: 0x15AE700 VA: 0x1815AF300 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x15AF5F0 Offset: 0x15AE9F0 VA: 0x1815AF5F0 Slot: 18
	protected override void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x15AF6F0 Offset: 0x15AEAF0 VA: 0x1815AF6F0 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x15AFAE0 Offset: 0x15AEEE0 VA: 0x1815AFAE0 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x15AFDC0 Offset: 0x15AF1C0 VA: 0x1815AFDC0
	private static void .cctor() { }

}

