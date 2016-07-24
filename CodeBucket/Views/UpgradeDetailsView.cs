#pragma warning disable 1591
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace CodeBucket.Views
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class UpgradeDetailsView : UpgradeDetailsViewBase
{

#line hidden

#line 1 "UpgradeDetailsView.cshtml"
public UpgradeDetailsModel Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<html><head>\n<meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable" +
"=0\"");

WriteLiteral("/>\n<style>\n* {\n    box-sizing: border-box;\n}\n\nhtml {\n    -webkit-text-size-adjust" +
": none;\n}\n\nbody {\n    color: #333;\n    font-family: Helvetica, Arial, sans-serif" +
";\n    line-height: 1.42;\n    font-size: 16px;\n    line-height: 1.7;\n    word-wra" +
"p: break-word;\n}\nh1, h2, h3, h4, h5, h6 {\nmargin: 1em 0 15px;\npadding: 0;\nfont-w" +
"eight: bold;\nline-height: 1.7;\ncursor: text;\nposition: relative;\n}\nh1 {\nfont-siz" +
"e: 1.8em;\nborder-bottom: 1px solid #ddd;\n}\np, blockquote, ul, ol, dl, table, pre" +
" {\nmargin: 15px 0;\n}\nh2 {\nfont-size: 1.4em;\nborder-bottom: 1px solid #eee;\n}\nul," +
" ol {\npadding-left: 20px;\n}\na {\ncolor: #4183c4;\ntext-decoration: none;\ntext-deco" +
"ration: none;\n}\n.highlight pre, pre {\nbackground-color: #f8f8f8;\nborder: 1px sol" +
"id #ddd;\nline-height: 19px;\noverflow: auto;\npadding: 6px 10px;\nborder-radius: 3p" +
"x;\n}\npre {\nword-wrap: normal;\n}\ndl {\npadding: 0;\n}\ndl dt {\nfont-weight: bold;\nfo" +
"nt-style: italic;\npadding: 0;\nmargin-top: 15px;\n}\ndl dd {\nmargin-bottom: 15px;\np" +
"adding: 0 15px;\n}\ntable {\nwidth: 100%;\noverflow: auto;\ndisplay: block;\n}\ntable t" +
"r {\nborder-top: 1px solid #ccc;\nbackground-color: #fff;\n}\ntable tr:nth-child(2n)" +
" {\nbackground-color: #f8f8f8;\n}\ntable th, table td {\nborder: 1px solid #ddd;\npad" +
"ding: 6px 13px;\n}\ntable th {\nfont-weight: bold;\n}\nimg {\nmax-width: 100%;\n-moz-bo" +
"x-sizing: border-box;\nbox-sizing: border-box;\n}\nul.task-list > li.task-list-item" +
" {\n  list-style-type: none;\n}\n.task-list-item-checkbox {\n  margin-left: -20px;\n " +
" vertical-align: middle;\n}\n.btn {\n    margin-top: 1.50em;\n    margin-bottom: 1em" +
";\n    padding: 1em 2em;\n    text-align: center;\n    display: inline-block;\n    b" +
"order-radius: 15px;\n    border: none;\n    transform: translateY(1px);\n    color:" +
" #fff;\n}\n#buy {\n    background-color: #2ecc71;\n    box-shadow: 0 3px #27ae60;\n}\n" +
"#purchased {\n    background-color: #34495e;\n    box-shadow: 0 3px #2c3e50;\n}\n");

WriteLiteral(@"@media (max-width: 640px) {
    .btn, #restore {
        display: block;
    }
    #restore {
        text-align: center;
    }
}

</style>
    <title>Pro Version</title>
</head>
<body>
    <p>
        <b>CodeBucket Pro</b> gives you access the all the great features below:
    </p>

    <ul>
        <li><a");

WriteLiteral(" href=\"#private\"");

WriteLiteral(">Private Repositories</a></li>\n    </ul>\n\n    <p>\n        Before you buy please t" +
"ake a look at the detailed description for each feature below. \n        If you\'r" +
"e unsure about any aspect of the Pro version, please feel free to \n        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" onclick=\"window.location=\'mailto://codebucketapp@gmail.com?Subject=CodeBucket%20" +
"Pro%20Question\'; return false;\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">contact me</a>!\n    </p>\n\n");


#line 149 "UpgradeDetailsView.cshtml"
    

#line default
#line hidden

#line 149 "UpgradeDetailsView.cshtml"
     if (Model.IsPurchased)
    {


#line default
#line hidden
WriteLiteral("        <p>\n            <a");

WriteLiteral(" id=\"purchased\"");

WriteLiteral(" class=\"btn\"");

WriteLiteral(">Pro Already Enabled!</a>\n        </p>\n");


#line 154 "UpgradeDetailsView.cshtml"
    }
    else
    {
        if (Model.Price != null)
        {


#line default
#line hidden
WriteLiteral("            <p>\n                <a");

WriteLiteral(" id=\"buy\"");

WriteLiteral(" href=\"app://buy\"");

WriteLiteral(" class=\"btn\"");

WriteLiteral(">Purchase CodeBucket Pro for ");


#line 160 "UpgradeDetailsView.cshtml"
                                                                                Write(Model.Price);


#line default
#line hidden
WriteLiteral("</a>\n            </p>\n");

WriteLiteral("            <p");

WriteLiteral(" id=\"restore\"");

WriteLiteral(">\n                <a");

WriteLiteral(" href=\"app://restore\"");

WriteLiteral(">Click here</a> to restore a previous purchase.\n            </p>\n");


#line 165 "UpgradeDetailsView.cshtml"
        }
    }


#line default
#line hidden
WriteLiteral("\n    <h2>Feature Details</h2>\n    <p>Below are the features that are available wh" +
"en purchasing CodeBucket Pro.</p>\n\n    <h3");

WriteLiteral(" id=\"private\"");

WriteLiteral(@">Private Repositories</h3>
    <p>
        While CodeBucket is free for all public projects, private repositories are only availble with CodeBucket Pro.
        The Pro edition allows access to all your private repositories and any private repositories any of your teams have.
        Access to your private repositories is completely unrestricted. With CodeBucket Pro, anything you are able to do with your open source repositories
        you are also capable of doing with your private repositories. Even more, access to private repositories, with CodeBucket Pro, is applied to
        all your CodeBucket accounts.
    </p>
</body>
</html>");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class UpgradeDetailsViewBase
{

		// This field is OPTIONAL, but used by the default implementation of Generate, Write, WriteAttribute and WriteLiteral
		//
		System.IO.TextWriter __razor_writer;

		// This method is OPTIONAL
		//
		/// <summary>Executes the template and returns the output as a string.</summary>
		/// <returns>The template output.</returns>
		public string GenerateString ()
		{
			using (var sw = new System.IO.StringWriter ()) {
				Generate (sw);
				return sw.ToString ();
			}
		}

		// This method is OPTIONAL, you may choose to implement Write and WriteLiteral without use of __razor_writer
		// and provide another means of invoking Execute.
		//
		/// <summary>Executes the template, writing to the provided text writer.</summary>
		/// <param name="writer">The TextWriter to which to write the template output.</param>
		public void Generate (System.IO.TextWriter writer)
		{
			__razor_writer = writer;
			Execute ();
			__razor_writer = null;
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the template output without HTML escaping it.</summary>
		/// <param name="value">The literal value.</param>
		protected void WriteLiteral (string value)
		{
			__razor_writer.Write (value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the TextWriter without HTML escaping it.</summary>
		/// <param name="writer">The TextWriter to which to write the literal.</param>
		/// <param name="value">The literal value.</param>
		protected static void WriteLiteralTo (System.IO.TextWriter writer, string value)
		{
			writer.Write (value);
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a value to the template output, HTML escaping it if necessary.</summary>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected void Write (object value)
		{
			WriteTo (__razor_writer, value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes an object value to the TextWriter, HTML escaping it if necessary.</summary>
		/// <param name="writer">The TextWriter to which to write the value.</param>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected static void WriteTo (System.IO.TextWriter writer, object value)
		{
			if (value == null)
				return;

			var write = value as Action<System.IO.TextWriter>;
			if (write != null) {
				write (writer);
				return;
			}

			//NOTE: a more sophisticated implementation would write safe and pre-escaped values directly to the
			//instead of double-escaping. See System.Web.IHtmlString in ASP.NET 4.0 for an example of this.
			writer.Write(System.Net.WebUtility.HtmlEncode (value.ToString ()));
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to the template output.
		/// </summary>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		protected void WriteAttribute (string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			WriteAttributeTo (__razor_writer, name, prefix, suffix, values);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to a TextWriter.
		/// </summary>
		/// <param name="writer">The TextWriter to which to write the attribute.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		///<remarks>Used by Razor helpers to write attributes.</remarks>
		protected static void WriteAttributeTo (System.IO.TextWriter writer, string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			// this is based on System.Web.WebPages.WebPageExecutingBase
			// Copyright (c) Microsoft Open Technologies, Inc.
			// Licensed under the Apache License, Version 2.0
			if (values.Length == 0) {
				// Explicitly empty attribute, so write the prefix and suffix
				writer.Write (prefix);
				writer.Write (suffix);
				return;
			}

			bool first = true;
			bool wroteSomething = false;

			for (int i = 0; i < values.Length; i++) {
				Tuple<string,object,bool> attrVal = values [i];
				string attPrefix = attrVal.Item1;
				object value = attrVal.Item2;
				bool isLiteral = attrVal.Item3;

				if (value == null) {
					// Nothing to write
					continue;
				}

				// The special cases here are that the value we're writing might already be a string, or that the 
				// value might be a bool. If the value is the bool 'true' we want to write the attribute name instead
				// of the string 'true'. If the value is the bool 'false' we don't want to write anything.
				//
				// Otherwise the value is another object (perhaps an IHtmlString), and we'll ask it to format itself.
				string stringValue;
				bool? boolValue = value as bool?;
				if (boolValue == true) {
					stringValue = name;
				} else if (boolValue == false) {
					continue;
				} else {
					stringValue = value as string;
				}

				if (first) {
					writer.Write (prefix);
					first = false;
				} else {
					writer.Write (attPrefix);
				}

				if (isLiteral) {
					writer.Write (stringValue ?? value);
				} else {
					WriteTo (writer, stringValue ?? value);
				}
				wroteSomething = true;
			}
			if (wroteSomething) {
				writer.Write (suffix);
			}
		}
		// This method is REQUIRED. The generated Razor subclass will override it with the generated code.
		//
		///<summary>Executes the template, writing output to the Write and WriteLiteral methods.</summary>.
		///<remarks>Not intended to be called directly. Call the Generate method instead.</remarks>
		public abstract void Execute ();

}
}
#pragma warning restore 1591
