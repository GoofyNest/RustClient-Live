public sealed class ProductUserId : Handle // TypeDefIndex: 8297
{
	public const int ProductuseridMaxLength = 32;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public static ProductUserId FromString(Utf8String productUserIdString) { }

	public static ProductUserId op_Explicit(Utf8String value) { }

	public bool IsValid() { }

	public Result ToString(out Utf8String outBuffer) { }

	public override string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

	public static Utf8String op_Explicit(ProductUserId value) { }

}

