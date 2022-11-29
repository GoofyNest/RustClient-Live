public class ByteMap // TypeDefIndex: 12028
{
	[SerializeField] 
	private int size; 
	[SerializeField] 
	private int bytes; 
	[SerializeField] 
	private byte[] values; 

	public int Size { get; }
	public uint Item { get; set; }


	public void .ctor(int size, int bytes = 1) { }

	public void .ctor(int size, byte[] values, int bytes = 1) { }

	public int get_Size() { }

	public uint get_Item(int x, int y) { }

	public void set_Item(int x, int y, uint value) { }

}

