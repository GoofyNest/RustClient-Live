public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage // TypeDefIndex: 1234
{
	public override IDictionary Properties { get; }


	internal void .ctor(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	public override IDictionary get_Properties() { }

}

