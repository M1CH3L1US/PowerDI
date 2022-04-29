using System.Management.Automation.Language;

namespace PSyringe.Language.AstTransformation.SourceCodeGenerators;

public static class ParenExpressionAstExtensions {
  public static string ToStringFromAst(this ParenExpressionAst ast) {
    var expression = ast.Pipeline.ToStringFromAst();

    return $"({expression})";
  }
}