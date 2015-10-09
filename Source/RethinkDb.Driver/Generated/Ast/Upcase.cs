












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class Upcase : ReqlExpr {

    
    
    
/// <summary>
/// <para>Uppercases a string.</para>
/// </summary>
/// <example><para>Example:</para>
/// <code>r.expr("Sentence about LaTeX.").upcase().run(conn, callback)
/// </code></example>
        public Upcase (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Uppercases a string.</para>
/// </summary>
/// <example><para>Example:</para>
/// <code>r.expr("Sentence about LaTeX.").upcase().run(conn, callback)
/// </code></example>
        public Upcase (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Uppercases a string.</para>
/// </summary>
/// <example><para>Example:</para>
/// <code>r.expr("Sentence about LaTeX.").upcase().run(conn, callback)
/// </code></example>
        public Upcase (Arguments args, OptArgs optargs)
             : this(TermType.UPCASE, args, optargs) {
        }

    protected Upcase (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
