internal class HWStack : ICloneable // TypeDefIndex: 1984
{	private object[] stack; // 0x10
	private int growthRate; // 0x18
	private int used; // 0x1C
	private int size; // 0x20
	private int limit; // 0x24

	internal object Item { get; set; }
	internal int Length { get; }


	internal void .ctor(int GrowthRate) { }

	internal void .ctor(int GrowthRate, int limit) { }

	internal object Push() { }

	internal object Pop() { }

	internal object Peek() { }

	internal void AddToTop(object o) { }

	internal object get_Item(int index) { }

	internal void set_Item(int index, object value) { }

	internal int get_Length() { }

	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	public object Clone() { }

}

