internal class DelegateSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 357
{
	private Delegate _delegate; 


private void .ctor(SerializationInfo info, StreamingContext ctx) { }

public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) { }

public void GetObjectData(SerializationInfo info, StreamingContext context) { }

public object GetRealObject(StreamingContext context) { }

}

private class DelegateSerializationHolder.DelegateEntry // TypeDefIndex: 358
{
	private string type; 
	private string assembly; 
	private object target; 
	private string targetTypeAssembly; 
	private string targetTypeName; 
	private string methodName; 
	public DelegateSerializationHolder.DelegateEntry delegateEntry; 


public void .ctor(Delegate del, string targetLabel) { }

public Delegate DeserializeDelegate(SerializationInfo info, int index) { }

}

