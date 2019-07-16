using System.Collections.Generic;

using System.Collections.Generic;
using System.Text;
using System;

namespace BuilderCodingExercise
{
    public class CodeBuilder
   {
       public string ClassName;

       //public struct fieldStruct
       //{
       //     private string nameField;
       //     private string typeField;

       //     public string TypeField { get => typeField; set => typeField = value; }
       //     public string NameField { get => nameField; set => nameField = value; }
       // }
      static Dictionary<string, string> fieldClass = new Dictionary<string, string>();
       //static List<string> fList = new List<string>();

        public CodeBuilder(string className)
        {
            ClassName = className;
        }

        public CodeBuilder AddField(string NameField, string TypeField)
       {
            fieldClass.Add(NameField, TypeField);
           return this;
       }

        

       private string ToStringImpl()
       {
           var sb = new StringBuilder();
           sb.Append($"public class {ClassName}\n");
           sb.Append("{");
           sb.AppendLine();
           foreach (var field in fieldClass)
           {
               var name = field.Key;
               var type = field.Value;
               sb.Append($"  public ");
               sb.Append(type);
               sb.Append($" {name};\n");
           }
           sb.Append("}");
           sb.AppendLine();
            return sb.ToString();
            
       }

        public override string ToString()
        {
            return ToStringImpl();
        }
    }
}
