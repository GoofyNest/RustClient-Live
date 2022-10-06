internal class Function : AstNode // TypeDefIndex: 1792
{
	private Function.FunctionType functionType; 
	private ArrayList argumentList; 
	private string name; 
	private string prefix; 
	internal static XPathResultType[] ReturnTypes; 

	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }


	public void .ctor(Function.FunctionType ftype, ArrayList argumentList) { }

	public void .ctor(string prefix, string name, ArrayList argumentList) { }

	public void .ctor(Function.FunctionType ftype, AstNode arg) { }

	public override AstNode.AstType get_Type() { }

	public override XPathResultType get_ReturnType() { }

	private static void .cctor() { }

}

public enum Function.FunctionType // TypeDefIndex: 1793
{
	public int value__; 
	public const Function.FunctionType FuncLast = 0;
	public const Function.FunctionType FuncPosition = 1;
	public const Function.FunctionType FuncCount = 2;
	public const Function.FunctionType FuncID = 3;
	public const Function.FunctionType FuncLocalName = 4;
	public const Function.FunctionType FuncNameSpaceUri = 5;
	public const Function.FunctionType FuncName = 6;
	public const Function.FunctionType FuncString = 7;
	public const Function.FunctionType FuncBoolean = 8;
	public const Function.FunctionType FuncNumber = 9;
	public const Function.FunctionType FuncTrue = 10;
	public const Function.FunctionType FuncFalse = 11;
	public const Function.FunctionType FuncNot = 12;
	public const Function.FunctionType FuncConcat = 13;
	public const Function.FunctionType FuncStartsWith = 14;
	public const Function.FunctionType FuncContains = 15;
	public const Function.FunctionType FuncSubstringBefore = 16;
	public const Function.FunctionType FuncSubstringAfter = 17;
	public const Function.FunctionType FuncSubstring = 18;
	public const Function.FunctionType FuncStringLength = 19;
	public const Function.FunctionType FuncNormalize = 20;
	public const Function.FunctionType FuncTranslate = 21;
	public const Function.FunctionType FuncLang = 22;
	public const Function.FunctionType FuncSum = 23;
	public const Function.FunctionType FuncFloor = 24;
	public const Function.FunctionType FuncCeiling = 25;
	public const Function.FunctionType FuncRound = 26;
	public const Function.FunctionType FuncUserDefined = 27;

}

internal sealed class Function // TypeDefIndex: 4264
{
	internal readonly string _name; 
	internal readonly FunctionId _id; 
	internal readonly Type _result; 
	internal readonly bool _isValidateArguments; 
	internal readonly bool _isVariantArgumentList; 
	internal readonly int _argumentCount; 
	internal readonly Type[] _parameters; 
	internal static string[] s_functionName; 


	internal void .ctor(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

	private static void .cctor() { }

}

