public sealed class FixedBufferAttribute : Attribute // TypeDefIndex: 1306
{	private Type elementType; // 0x10
	private int length; // 0x18

	public Type ElementType { get; }
	public int Length { get; }


	public void .ctor(Type elementType, int length) { }

	public Type get_ElementType() { }

	public int get_Length() { }

}

