internal class DelegateSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 357
{	private Delegate _delegate; // 0x10


	private void .ctor(SerializationInfo info, StreamingContext ctx) { }

	public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public object GetRealObject(StreamingContext context) { }

}

private class DelegateSerializationHolder.DelegateEntry // TypeDefIndex: 358
{	private string type; // 0x10
	private string assembly; // 0x18
	private object target; // 0x20
	private string targetTypeAssembly; // 0x28
	private string targetTypeName; // 0x30
	private string methodName; // 0x38
	public DelegateSerializationHolder.DelegateEntry delegateEntry; // 0x40


	public void .ctor(Delegate del, string targetLabel) { }

	public Delegate DeserializeDelegate(SerializationInfo info, int index) { }

}

