//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./Calculator.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CalculatorParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface ICalculatorListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.computation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComputation([NotNull] CalculatorParser.ComputationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.computation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComputation([NotNull] CalculatorParser.ComputationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] CalculatorParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] CalculatorParser.AssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] CalculatorParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] CalculatorParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTerm([NotNull] CalculatorParser.TermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTerm([NotNull] CalculatorParser.TermContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactor([NotNull] CalculatorParser.FactorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactor([NotNull] CalculatorParser.FactorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] CalculatorParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] CalculatorParser.ValueContext context);
}
