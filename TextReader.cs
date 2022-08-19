public abstract class TextReader : MarshalByRefObject, IDisposable // TypeDefIndex: 651
{	// Fields
	private static Func<object, string> _ReadLineDelegate; // 0x0
	private static Func<object, int> _ReadDelegate; // 0x8
	public static readonly TextReader Null; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x162FF20 Offset: 0x162F320 VA: 0x18162FF20 Slot: 7
	public virtual void Close() { }

	// RVA: 0x162FF90 Offset: 0x162F390 VA: 0x18162FF90 Slot: 6
	public void Dispose() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x513D90 Offset: 0x513190 VA: 0x180513D90 Slot: 9
	public virtual int Peek() { }

	// RVA: 0x513D90 Offset: 0x513190 VA: 0x180513D90 Slot: 10
	public virtual int Read() { }

	// RVA: 0x1630200 Offset: 0x162F600 VA: 0x181630200 Slot: 11
	public virtual int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x1630110 Offset: 0x162F510 VA: 0x181630110 Slot: 12
	public virtual string ReadToEnd() { }

	// RVA: 0x1630000 Offset: 0x162F400 VA: 0x181630000 Slot: 13
	public virtual string ReadLine() { }

	// RVA: 0x16303E0 Offset: 0x162F7E0 VA: 0x1816303E0
	public static TextReader Synchronized(TextReader reader) { }

	// RVA: 0x16304D0 Offset: 0x162F8D0 VA: 0x1816304D0
	private static void .cctor() { }

}

private sealed class TextReader.NullTextReader : TextReader // TypeDefIndex: 652
{	// Methods

	// RVA: 0x1624290 Offset: 0x1623690 VA: 0x181624290
	public void .ctor() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 13
	public override string ReadLine() { }

}

internal sealed class TextReader.SyncTextReader : TextReader // TypeDefIndex: 653
{	// Fields
	internal TextReader _in; // 0x18

	// Methods

	// RVA: 0x162FA00 Offset: 0x162EE00 VA: 0x18162FA00
	internal void .ctor(TextReader t) { }

	// RVA: 0x13CD2B0 Offset: 0x13CC6B0 VA: 0x1813CD2B0 Slot: 7
	public override void Close() { }

	// RVA: 0x162F940 Offset: 0x162ED40 VA: 0x18162F940 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x15925F0 Offset: 0x15919F0 VA: 0x1815925F0 Slot: 9
	public override int Peek() { }

	// RVA: 0x1314F90 Offset: 0x1314390 VA: 0x181314F90 Slot: 10
	public override int Read() { }

	// RVA: 0x162F9D0 Offset: 0x162EDD0 VA: 0x18162F9D0 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x13CD280 Offset: 0x13CC680 VA: 0x1813CD280 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x162F9A0 Offset: 0x162EDA0 VA: 0x18162F9A0 Slot: 12
	public override string ReadToEnd() { }

}

private sealed class TextReader.<>c // TypeDefIndex: 654
{	// Fields
	public static readonly TextReader.<>c <>9; // 0x13053

	// Methods

	// RVA: 0x16324D0 Offset: 0x16318D0 VA: 0x1816324D0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1631E50 Offset: 0x1631250 VA: 0x181631E50
	internal string <.cctor>b__22_0(object state) { }

	// RVA: 0x1631F20 Offset: 0x1631320 VA: 0x181631F20
	internal int <.cctor>b__22_1(object state) { }

}

