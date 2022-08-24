public sealed class Pointer : ISerializable // TypeDefIndex: 546
{
	private void* _ptr; 
	private RuntimeType _ptrType; 


private void .ctor() { }

private void .ctor(SerializationInfo info, StreamingContext context) { }

public static object Box(void* ptr, Type type) { }

private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

public class PointER // TypeDefIndex: 6874
{
	public float x; 
	public float y; 
	public float z; 


public void .ctor(float x, float y, float z) { }

public override int GetHashCode() { }

public override bool Equals(object obj) { }

public static bool op_Equality(PointER left, PointER right) { }

}

