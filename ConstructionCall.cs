public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 1232
{	private IActivator _activator; // 0x68
	private object[] _activationAttributes; // 0x70
	private IList _contextProperties; // 0x78
	private Type _activationType; // 0x80
	private string _activationTypeName; // 0x88
	private bool _isContextOk; // 0x90
	private RemotingProxy _sourceProxy; // 0x98

	internal bool IsContextOk { get; set; }
	public Type ActivationType { get; }
	public string ActivationTypeName { get; }
	public IActivator Activator { get; set; }
	public object[] CallSiteActivationAttributes { get; }
	public IList ContextProperties { get; }
	public override IDictionary Properties { get; }
	internal RemotingProxy SourceProxy { get; set; }


	internal void .ctor(Type type) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	internal override void InitDictionary() { }

	internal bool get_IsContextOk() { }

	internal void set_IsContextOk(bool value) { }

	public Type get_ActivationType() { }

	public string get_ActivationTypeName() { }

	public IActivator get_Activator() { }

	public void set_Activator(IActivator value) { }

	public object[] get_CallSiteActivationAttributes() { }

	internal void SetActivationAttributes(object[] attributes) { }

	public IList get_ContextProperties() { }

	internal override void InitMethodProperty(string key, object value) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override IDictionary get_Properties() { }

	internal RemotingProxy get_SourceProxy() { }

	internal void set_SourceProxy(RemotingProxy value) { }

}

