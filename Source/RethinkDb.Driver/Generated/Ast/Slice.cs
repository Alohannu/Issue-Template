












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

    public class Slice : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return the elements of a sequence within the specified range.</para>
/// <para>Example: Return the fourth, fifth and sixth youngest players. (The youngest player is at index 0, so those are elements 3&ndash;5.)</para>
/// <para><code>js
/// r.table('players').orderBy({index: 'age'}).slice(3,6).run(conn, callback)</code></para>
/// </summary>
/// <example></example>
        public Slice (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return the elements of a sequence within the specified range.</para>
/// <para>Example: Return the fourth, fifth and sixth youngest players. (The youngest player is at index 0, so those are elements 3&ndash;5.)</para>
/// <para><code>js
/// r.table('players').orderBy({index: 'age'}).slice(3,6).run(conn, callback)</code></para>
/// </summary>
/// <example></example>
        public Slice (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return the elements of a sequence within the specified range.</para>
/// <para>Example: Return the fourth, fifth and sixth youngest players. (The youngest player is at index 0, so those are elements 3&ndash;5.)</para>
/// <para><code>js
/// r.table('players').orderBy({index: 'age'}).slice(3,6).run(conn, callback)</code></para>
/// </summary>
/// <example></example>
        public Slice (Arguments args, OptArgs optargs)
             : this(TermType.SLICE, args, optargs) {
        }

    protected Slice (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    
///<summary>
/// "left_bound": "E_BOUND",
///  "right_bound": "E_BOUND"
///</summary>
        public Slice optArg(string optname, object value) {
             var newOptargs = OptArgs.fromMap(this.OptArgs)
                                     .with(optname, value);
             return new Slice (this.Args, newOptargs);
        }


    

    


    
    }
}
