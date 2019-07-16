using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCodingExercise
{
   public class CodeBuilder
   {
       public string ClassName, FieldName, TypeName;
       private const int indentSize = 1;

        public CodeBuilder(string className, string fieldName, string typeName)
        {
            ClassName = className ?? throw new ArgumentNullException(nameof(className));
            FieldName = fieldName ?? throw new ArgumentNullException(nameof(fieldName));
            TypeName = typeName ?? throw new ArgumentNullException(nameof(typeName));
        }

       private string ToStringImpl(int indent)
       {
           var sb = new StringBuilder();
            //var i = new string(' ', indentSize * indent);
            //sb.Append($"{i}<{Name}>\n");
            sb.Append($"public class {ClassName}\n");
           sb.Append($"public {ClassName}\n");
            //if (!string.IsNullOrWhiteSpace(Text))
            //{
            //    sb.Append(new string(' ', indentSize * (indent + 1)));
            //    sb.Append(Text);
            //    sb.Append("\n");
            //}

            //foreach (var e in Elements)
            //    sb.Append(e.ToStringImpl(indent + 1));

            //sb.Append($"{i}</{Name}>\n");
            return sb.ToString();
       }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
}
