
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import luban.*;


public final class IsSet extends cfg.ai.KeyQueryOperator {
    public IsSet(ByteBuf _buf) { 
        super(_buf);
    }

    public static IsSet deserialize(ByteBuf _buf) {
            return new cfg.ai.IsSet(_buf);
    }


    public static final int __ID__ = 1635350898;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "}";
    }
}

