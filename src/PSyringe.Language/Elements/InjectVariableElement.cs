using System.Management.Automation.Language;
using PSyringe.Common.Language.Parsing.Elements;

namespace PSyringe.Language.Elements;

public class InjectVariableElement : IInjectVariableElement {
  /// <summary>
  ///   AttributedExpressionChild is either a VariableExpressionAst
  ///   or a VariableAssignmentExpression
  /// </summary>
  /// <param name="ast"></param>
  public InjectVariableElement(AttributedExpressionAst ast) {
    Ast = ast;
  }

  // [Fact]
  // public void AddInjectVariable_CreatesInjectVariable_WhenEncountered() {
  //   // Expression => [Attribute] ([Inject()]), [Child] => [Attribute] ([ILogger])
  //   var sut = MakeVisitorAndVisitScript(ScriptTemplates.WithInjectVariableExpression_ImplicitTarget);
  // }
  public AttributedExpressionAst Ast { get; }

  public bool HasDefaultValue() {
    return false;
  }
}