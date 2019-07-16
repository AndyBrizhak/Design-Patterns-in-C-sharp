﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCodingExercise
{
   public class CodeBuilder
   {
       public string ClassName;
      static Dictionary<string, string> fieldClass = new Dictionary<string, string>();

       public CodeBuilder AddField(string NameField, string TypeField)
       {
            fieldClass.Add(NameField, TypeField);
           return this;
       }

        

       private string ToStringImpl()
       {
           var sb = new StringBuilder();
            //var i = new string(' ', indentSize * indent);
            //sb.Append($"{i}<{Name}>\n");
           sb.Append($"public class {ClassName}\n");
           sb.Append("{");
           sb.AppendLine();
           foreach (var field in fieldClass)
           {
               var name = field.Key;
               var type = field.Value;
               sb.Append($"public ");
               sb.Append(type);
               sb.Append($" {name} ;\n");
           }
           sb.Append("}");
           sb.AppendLine();
         
         
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
            return ToStringImpl();
        }
    }
}
