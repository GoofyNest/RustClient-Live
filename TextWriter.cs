public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 655
{	// Fields
	public static readonly TextWriter Null; // 0x0
	private static Action<object> _WriteCharDelegate; // 0x8
	private static Action<object> _WriteStringDelegate; // 0x10
	private static Action<object> _WriteCharArrayRangeDelegate; // 0x18
	private static Action<object> _WriteLineCharDelegate; // 0x20
	private static Action<object> _WriteLineStringDelegate; // 0x28
	private static Action<object> _WriteLineCharArrayRangeDelegate; // 0x30
	private static Action<object> _FlushDelegate; // 0x38
	protected char[] CoreNewLine; // 0x18
	private IFormatProvider InternalFormatProvider; // 0x20

	// Properties
	private static string InitialNewLine { get; }
	public virtual IFormatProvider FormatProvider { get; }
	public abstract Encoding Encoding { get; }

	// Methods

	// RVA: 0x1631400 Offset: 0x1630800 VA: 0x181631400
	private static string get_InitialNewLine() { }

	// RVA: 0x1631290 Offset: 0x1630690 VA: 0x181631290
	protected void .ctor() { }

	// RVA: 0x1631320 Offset: 0x1630720 VA: 0x181631320
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x16313C0 Offset: 0x16307C0 VA: 0x1816313C0 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x1630640 Offset: 0x162FA40 VA: 0x181630640 Slot: 8
	public virtual void Close() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16306B0 Offset: 0x162FAB0 VA: 0x1816306B0 Slot: 6
	public void Dispose() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	public virtual void Flush() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Encoding get_Encoding();

	// RVA: 0x1630720 Offset: 0x162FB20 VA: 0x181630720
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 12
	public virtual void Write(char value) { }

	// RVA: 0x1630F10 Offset: 0x1630310 VA: 0x181630F10 Slot: 13
	public virtual void Write(char[] buffer) { }

	// RVA: 0x1630D30 Offset: 0x1630130 VA: 0x181630D30 Slot: 14
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1630CF0 Offset: 0x16300F0 VA: 0x181630CF0 Slot: 15
	public virtual void Write(string value) { }

	// RVA: 0x1630CD0 Offset: 0x16300D0 VA: 0x181630CD0 Slot: 16
	public virtual void WriteLine() { }

	// RVA: 0x1630830 Offset: 0x162FC30 VA: 0x181630830 Slot: 17
	public virtual void WriteLine(char value) { }

	// RVA: 0x1630C90 Offset: 0x1630090 VA: 0x181630C90 Slot: 18
	public virtual void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x1630A80 Offset: 0x162FE80 VA: 0x181630A80 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x1630870 Offset: 0x162FC70 VA: 0x181630870 Slot: 20
	public virtual void WriteLine(object value) { }

	// RVA: 0x1630A20 Offset: 0x162FE20 VA: 0x181630A20 Slot: 21
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x16309A0 Offset: 0x162FDA0 VA: 0x1816309A0 Slot: 22
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x1630F40 Offset: 0x1630340 VA: 0x181630F40
	private static void .cctor() { }

}

private sealed class TextWriter.NullTextWriter : TextWriter // TypeDefIndex: 656
{	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x16242F0 Offset: 0x16236F0 VA: 0x1816242F0
	internal void .ctor() { }

	// RVA: 0x1624380 Offset: 0x1623780 VA: 0x181624380 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 16
	public override void WriteLine() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 19
	public override void WriteLine(string value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 20
	public override void WriteLine(object value) { }

}

internal sealed class TextWriter.SyncTextWriter : TextWriter, IDisposable // TypeDefIndex: 657
{	// Fields
	private TextWriter _out; // 0x28

	// Properties
	public override Encoding Encoding { get; }
	public override IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x162FC80 Offset: 0x162F080 VA: 0x18162FC80
	internal void .ctor(TextWriter t) { }

	// RVA: 0xBA0130 Offset: 0xB9F530 VA: 0x180BA0130 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0xBA0070 Offset: 0xB9F470 VA: 0x180BA0070 Slot: 7
	public override IFormatProvider get_FormatProvider() { }

	// RVA: 0xBA00A0 Offset: 0xB9F4A0 VA: 0x180BA00A0 Slot: 8
	public override void Close() { }

	// RVA: 0x162FA70 Offset: 0x162EE70 VA: 0x18162FA70 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0xBA0100 Offset: 0xB9F500 VA: 0x180BA0100 Slot: 10
	public override void Flush() { }

	// RVA: 0xBA0160 Offset: 0xB9F560 VA: 0x180BA0160 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x162FC50 Offset: 0x162F050 VA: 0x18162FC50 Slot: 13
	public override void Write(char[] buffer) { }

	// RVA: 0x162FC20 Offset: 0x162F020 VA: 0x18162FC20 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x162FBF0 Offset: 0x162EFF0 VA: 0x18162FBF0 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x162FBC0 Offset: 0x162EFC0 VA: 0x18162FBC0 Slot: 16
	public override void WriteLine() { }

	// RVA: 0x162FB90 Offset: 0x162EF90 VA: 0x18162FB90 Slot: 17
	public override void WriteLine(char value) { }

	// RVA: 0x162FAD0 Offset: 0x162EED0 VA: 0x18162FAD0 Slot: 18
	public override void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x162FB30 Offset: 0x162EF30 VA: 0x18162FB30 Slot: 19
	public override void WriteLine(string value) { }

	// RVA: 0xB9FD60 Offset: 0xB9F160 VA: 0x180B9FD60 Slot: 20
	public override void WriteLine(object value) { }

	// RVA: 0x162FB00 Offset: 0x162EF00 VA: 0x18162FB00 Slot: 21
	public override void WriteLine(string format, object arg0) { }

	// RVA: 0x162FB60 Offset: 0x162EF60 VA: 0x18162FB60 Slot: 22
	public override void WriteLine(string format, object arg0, object arg1) { }

}

private sealed class TextWriter.<>c // TypeDefIndex: 658
{	// Fields
	public static readonly TextWriter.<>c <>9; // 0x2B0AA90

	// Methods

	// RVA: 0x1632530 Offset: 0x1631930 VA: 0x181632530
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1631FD0 Offset: 0x16313D0 VA: 0x181631FD0
	internal void <.cctor>b__73_0(object state) { }

	// RVA: 0x1632070 Offset: 0x1631470 VA: 0x181632070
	internal void <.cctor>b__73_1(object state) { }

	// RVA: 0x1632110 Offset: 0x1631510 VA: 0x181632110
	internal void <.cctor>b__73_2(object state) { }

	// RVA: 0x16321C0 Offset: 0x16315C0 VA: 0x1816321C0
	internal void <.cctor>b__73_3(object state) { }

	// RVA: 0x1632260 Offset: 0x1631660 VA: 0x181632260
	internal void <.cctor>b__73_4(object state) { }

	// RVA: 0x1632300 Offset: 0x1631700 VA: 0x181632300
	internal void <.cctor>b__73_5(object state) { }

	// RVA: 0x16323B0 Offset: 0x16317B0 VA: 0x1816323B0
	internal void <.cctor>b__73_6(object state) { }

}

