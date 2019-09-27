﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace LivetControlBindingSupportGenerator
{
    using System.Linq;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class SetStateToControlBehavior : SetStateToControlBehaviorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 3 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"

// You can remove full path from generated code in Visual Studio.
// 1. Show [Find and Replace] dialog (generally ctrl+shift+H).
// 2. Enter '{\#line [1-9]+} ".+\\{[^\\]+\.tt}"' to finding string text box (without single quots).
// 3. Enter '\1 "\2"' to replacement string text box (without single quots).
// 4. Specify search condition as 'Regular expressions'
// 5. Click [Replace All]

            
            #line default
            #line hidden
            this.Write(@"
//このコードはT4 Templateによって自動生成されています。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Documents;
using Microsoft.Xaml.Behaviors;
using System.Windows.Controls.Primitives;
using System.Windows.Interop;
using System.ComponentModel;

namespace Livet.Behaviors.ControlBinding.OneWay
{
	/// <summary>
	/// ");
            
            #line 32 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("クラスの、標準ではバインドできないプロパティで書き込み可能なものを表します。\r\n\t/// </summary>\r\n\tpublic enum ");
            
            #line 34 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("UnbindableCanWriteProperty\r\n\t{\r\n");
            
            #line 36 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
 
foreach(var key in SetterHavingTargetProperties.Keys)
{

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 40 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(key));
            
            #line default
            #line hidden
            
            #line 40 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
if(key != SetterHavingTargetProperties.Keys.Last()){
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 41 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
}
            
            #line default
            #line hidden
            
            #line 42 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"

}

            
            #line default
            #line hidden
            this.Write("\r\n\t}\r\n\r\n\t/// <summary>\r\n\t/// ");
            
            #line 49 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("クラスのバインディングできないプロパティに、指定されたソースから値を設定するためのビヘイビアです。\r\n\t/// </summary>\r\n\tpublic class" +
                    " ");
            
            #line 51 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("SetStateToControlBehavior : Behavior<");
            
            #line 51 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(">\r\n\t{\r\n\t\tpublic ");
            
            #line 53 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("SetStateToControlBehavior()\r\n\t\t{\r\n\t\t}\r\n\r\n\t\t/// <summary>\r\n\t\t/// 値を設定したいプロパティを取得また" +
                    "は設定します。\r\n\t\t/// </summary>\r\n\t\tpublic ");
            
            #line 60 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("UnbindableCanWriteProperty Property\r\n        {\r\n            get { return (");
            
            #line 62 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(@"UnbindableCanWriteProperty)GetValue(PropertyProperty); }
            set { SetValue(PropertyProperty, value); }
        }

        public static readonly DependencyProperty PropertyProperty =
            DependencyProperty.Register(""Property"", typeof(");
            
            #line 67 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("UnbindableCanWriteProperty), typeof(");
            
            #line 67 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(@"SetStateToControlBehavior), new PropertyMetadata());

		/// <summary>
		/// Propertyプロパティで指定されたプロパティに値を設定するソースを取得または設定します。
		/// </summary>
		[Bindable(BindableSupport.Default,BindingDirection.OneWay)]
		public object Source
        {
            get { return (object)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register(""Source"", typeof(object), typeof(");
            
            #line 80 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("SetStateToControlBehavior), new PropertyMetadata(null,new PropertyChangedCallback" +
                    "(SourceChanged)));\r\n\r\n        private static void SourceChanged(DependencyObject" +
                    " sender,DependencyPropertyChangedEventArgs e)\r\n        {\r\n\t\t\tvar thisObject = (");
            
            #line 84 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("SetStateToControlBehavior)sender;\r\n\t\t\t\r\n\t\t\tif(thisObject.AssociatedObject == null" +
                    ")\r\n\t\t\t{\r\n\t\t\t\treturn;\r\n\t\t\t}\r\n\r\n            switch (thisObject.Property)\r\n        " +
                    "    {\r\n");
            
            #line 93 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"

foreach(var key in SetterHavingTargetProperties.Keys)
{

            
            #line default
            #line hidden
            this.Write("                case ");
            
            #line 97 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("UnbindableCanWriteProperty.");
            
            #line 97 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(key));
            
            #line default
            #line hidden
            this.Write(":\r\n\t\t\t\t\tif(e.NewValue == null)\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\treturn;\r\n\t\t\t\t\t}\r\n\t\t\t\t\tif(e.OldValue" +
                    " != null)\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\tif((");
            
            #line 104 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SetterHavingTargetProperties[key]));
            
            #line default
            #line hidden
            this.Write(")e.OldValue == (");
            
            #line 104 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SetterHavingTargetProperties[key]));
            
            #line default
            #line hidden
            this.Write(")e.NewValue)\r\n\t\t\t\t\t\t{\r\n\t\t\t\t\t\t\treturn;\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t}\r\n\t\t\t\t\tthisObject.Associate" +
                    "dObject.");
            
            #line 109 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(key));
            
            #line default
            #line hidden
            this.Write(" = (");
            
            #line 109 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SetterHavingTargetProperties[key]));
            
            #line default
            #line hidden
            this.Write(")thisObject.Source;\r\n                    break;\r\n");
            
            #line 111 "C:\Repos\runceel\Livet\LivetControlBindingSupportGenerator\SetStateToControlBehavior.tt"

}

            
            #line default
            #line hidden
            this.Write(@"
            }
        }

		protected override void OnAttached()
        {
            base.OnAttached();

            //Attatch時の評価
            SourceChanged(this, new DependencyPropertyChangedEventArgs(SourceProperty, null, Source));
        }
	}
}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class SetStateToControlBehaviorBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
