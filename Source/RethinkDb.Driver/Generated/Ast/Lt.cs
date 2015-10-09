












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

    public class Lt : ReqlExpr {

    
    
    
/// <summary>
/// <para>Test if the first value is less than other.</para>
/// </summary>
/// <example><para>Example: Is 2 less than 2?</para>
/// <code>r.expr(2).lt(2).run(conn, callback)
/// </code></example>
        public Lt (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Test if the first value is less than other.</para>
/// </summary>
/// <example><para>Example: Is 2 less than 2?</para>
/// <code>r.expr(2).lt(2).run(conn, callback)
/// </code></example>
        public Lt (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Test if the first value is less than other.</para>
/// </summary>
/// <example><para>Example: Is 2 less than 2?</para>
/// <code>r.expr(2).lt(2).run(conn, callback)
/// </code></example>
        public Lt (Arguments args, OptArgs optargs)
             : this(TermType.LT, args, optargs) {
        }

    protected Lt (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
