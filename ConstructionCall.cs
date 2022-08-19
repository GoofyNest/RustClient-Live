public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 1232
{	// Fields
	private IActivator _activator; // 0x68
	private object[] _activationAttributes; // 0x70
	private IList _contextProperties; // 0x78
	private Type _activationType; // 0x80
	private string _activationTypeName; // 0x88
	private bool _isContextOk; // 0x90
	private RemotingProxy _sourceProxy; // 0x98

	// Properties
	internal bool IsContextOk { get; set; }
	public Type ActivationType { get; }
	public string ActivationTypeName { get; }
	public IActivator Activator { get; set; }
	public object[] CallSiteActivationAttributes { get; }
	public IList ContextProperties { get; }
	public override IDictionary Properties { get; }
	internal RemotingProxy SourceProxy { get; set; }

	// Methods

	// RVA: 0x146E000 Offset: 0x146D400 VA: 0x18146E000
	internal void .ctor(Type type) { }

	// RVA: 0x146E070 Offset: 0x146D470 VA: 0x18146E070
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x146DC30 Offset: 0x146D030 VA: 0x18146DC30 Slot: 22
	internal override void InitDictionary() { }

	// RVA: 0x1183060 Offset: 0x1182460 VA: 0x181183060
	internal bool get_IsContextOk() { }

	// RVA: 0x1183080 Offset: 0x1182480 VA: 0x181183080
	internal void set_IsContextOk(bool value) { }

	// RVA: 0x146E120 Offset: 0x146D520 VA: 0x18146E120 Slot: 24
	public Type get_ActivationType() { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0 Slot: 25
	public string get_ActivationTypeName() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0 Slot: 26
	public IActivator get_Activator() { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0 Slot: 27
	public void set_Activator(IActivator value) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30 Slot: 28
	public object[] get_CallSiteActivationAttributes() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	internal void SetActivationAttributes(object[] attributes) { }

	// RVA: 0x146E1F0 Offset: 0x146D5F0 VA: 0x18146E1F0 Slot: 29
	public IList get_ContextProperties() { }

	// RVA: 0x146DD40 Offset: 0x146D140 VA: 0x18146DD40 Slot: 19
	internal override void InitMethodProperty(string key, object value) { }

	// RVA: 0x146DB30 Offset: 0x146CF30 VA: 0x18146DB30 Slot: 20
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x146E260 Offset: 0x146D660 VA: 0x18146E260 Slot: 21
	public override IDictionary get_Properties() { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	internal RemotingProxy get_SourceProxy() { }

	// RVA: 0x58DC70 Offset: 0x58D070 VA: 0x18058DC70
	internal void set_SourceProxy(RemotingProxy value) { }

}

