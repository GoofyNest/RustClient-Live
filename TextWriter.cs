public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 655
{	public static readonly TextWriter Null; // 0x0
	private static Action<object> _WriteCharDelegate; // 0x8
	private static Action<object> _WriteStringDelegate; // 0x10
	private static Action<object> _WriteCharArrayRangeDelegate; // 0x18
	private static Action<object> _WriteLineCharDelegate; // 0x20
	private static Action<object> _WriteLineStringDelegate; // 0x28
	private static Action<object> _WriteLineCharArrayRangeDelegate; // 0x30
	private static Action<object> _FlushDelegate; // 0x38
	protected char[] CoreNewLine; // 0x18
	private IFormatProvider InternalFormatProvider; // 0x20

	private static string InitialNewLine { get; }
	public virtual IFormatProvider FormatProvider { get; }
	public abstract Encoding Encoding { get; }


	private static string get_InitialNewLine() { }

	protected void .ctor() { }

	protected void .ctor(IFormatProvider formatProvider) { }

	public virtual IFormatProvider get_FormatProvider() { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	public virtual void Flush() { }

	public abstract Encoding get_Encoding();

	public static TextWriter Synchronized(TextWriter writer) { }

	public virtual void Write(char value) { }

	public virtual void Write(char[] buffer) { }

	public virtual void Write(char[] buffer, int index, int count) { }

	public virtual void Write(string value) { }

	public virtual void WriteLine() { }

	public virtual void WriteLine(char value) { }

	public virtual void WriteLine(char[] buffer, int index, int count) { }

	public virtual void WriteLine(string value) { }

	public virtual void WriteLine(object value) { }

	public virtual void WriteLine(string format, object arg0) { }

	public virtual void WriteLine(string format, object arg0, object arg1) { }

	private static void .cctor() { }

}

private sealed class TextWriter.NullTextWriter : TextWriter // TypeDefIndex: 656
{	public override Encoding Encoding { get; }


	internal void .ctor() { }

	public override Encoding get_Encoding() { }

	public override void Write(char[] buffer, int index, int count) { }

	public override void Write(string value) { }

	public override void WriteLine() { }

	public override void WriteLine(string value) { }

	public override void WriteLine(object value) { }

}

internal sealed class TextWriter.SyncTextWriter : TextWriter, IDisposable // TypeDefIndex: 657
{	private TextWriter _out; // 0x28

	public override Encoding Encoding { get; }
	public override IFormatProvider FormatProvider { get; }


	internal void .ctor(TextWriter t) { }

	public override Encoding get_Encoding() { }

	public override IFormatProvider get_FormatProvider() { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

	public override void Flush() { }

	public override void Write(char value) { }

	public override void Write(char[] buffer) { }

	public override void Write(char[] buffer, int index, int count) { }

	public override void Write(string value) { }

	public override void WriteLine() { }

	public override void WriteLine(char value) { }

	public override void WriteLine(char[] buffer, int index, int count) { }

	public override void WriteLine(string value) { }

	public override void WriteLine(object value) { }

	public override void WriteLine(string format, object arg0) { }

	public override void WriteLine(string format, object arg0, object arg1) { }

}

private sealed class TextWriter.<>c // TypeDefIndex: 658
{	public static readonly TextWriter.<>c <>9; // 0x2B0AA90


	private static void .cctor() { }

	public void .ctor() { }

	internal void <.cctor>b__73_0(object state) { }

	internal void <.cctor>b__73_1(object state) { }

	internal void <.cctor>b__73_2(object state) { }

	internal void <.cctor>b__73_3(object state) { }

	internal void <.cctor>b__73_4(object state) { }

	internal void <.cctor>b__73_5(object state) { }

	internal void <.cctor>b__73_6(object state) { }

}

