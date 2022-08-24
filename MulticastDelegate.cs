public abstract class MulticastDelegate : Delegate // TypeDefIndex: 377
{

[ComVisibleAttribute] 
[Serializable]
public abstract class MulticastDelegate : Delegate 
	private Delegate[] delegates; 


	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public sealed override bool Equals(object obj) { }

	public sealed override int GetHashCode() { }

	protected override MethodInfo GetMethodImpl() { }

	public sealed override Delegate[] GetInvocationList() { }

	protected sealed override Delegate CombineImpl(Delegate follow) { }

	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	protected sealed override Delegate RemoveImpl(Delegate value) { }

}

