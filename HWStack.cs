internal class HWStack : ICloneable // TypeDefIndex: 1984
{
	private object[] stack; 
	private int growthRate; 
	private int used; 
	private int size; 
	private int limit; 

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

