












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

    using RethinkDb.Driver.Net;


namespace RethinkDb.Driver.Ast {

    public class Binary : ReqlExpr {

    
    byte[] b64Data = null;

    
    
    public Binary (byte[] bytes) : this(new Arguments()){
        b64Data = bytes;
    }
    public Binary (Object arg) : this(new Arguments(arg), null) {
        
    }
    public Binary (Arguments args) : this(args, null){

    }
    public Binary (Arguments args, OptArgs optargs) : this(TermType.BINARY, args, optargs) {
        
    }
    protected Binary (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs){
        
    }


    
    


    


    














    
    
        protected internal override object Build() {
            if( b64Data != null){
                return Converter.ToBinary(b64Data);
            }
            else{
                return base.Build();
            }
        }



    
    }
}
