












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

    public class Prepend : ReqlExpr {

    
    
    
/// <summary>
/// <para>Prepend a value to an array.</para>
/// </summary>
/// <example><para>Example: Retrieve Iron Man's equipment list with the addition of some new boots.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').prepend('newBoots').run(conn, callback)
/// </code></example>
        public Prepend (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Prepend a value to an array.</para>
/// </summary>
/// <example><para>Example: Retrieve Iron Man's equipment list with the addition of some new boots.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').prepend('newBoots').run(conn, callback)
/// </code></example>
        public Prepend (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Prepend a value to an array.</para>
/// </summary>
/// <example><para>Example: Retrieve Iron Man's equipment list with the addition of some new boots.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').prepend('newBoots').run(conn, callback)
/// </code></example>
        public Prepend (Arguments args, OptArgs optargs)
             : this(TermType.PREPEND, args, optargs) {
        }

    protected Prepend (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
