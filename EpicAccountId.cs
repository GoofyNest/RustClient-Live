public sealed class EpicAccountId : Handle // TypeDefIndex: 8284
{
	public const int EpicaccountidMaxLength = 32;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public static EpicAccountId FromString(Utf8String accountIdString) { }

	public static EpicAccountId op_Explicit(Utf8String value) { }

	public bool IsValid() { }

	public Result ToString(out Utf8String outBuffer) { }

	public override string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

	public static Utf8String op_Explicit(EpicAccountId value) { }

}

