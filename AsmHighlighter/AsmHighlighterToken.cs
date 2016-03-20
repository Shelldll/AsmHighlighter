#region Header Licence
//  ---------------------------------------------------------------------
// 
//  Copyright (c) 2009 Alexandre Mutel and Microsoft Corporation.  
//  All rights reserved.
// 
//  This code module is part of AsmHighlighter, a plugin for visual studio
//  to provide syntax highlighting for x86 ASM language (.asm, .inc)
// 
//  ------------------------------------------------------------------
// 
//  This code is licensed under the Microsoft Public License. 
//  See the file License.txt for the license details.
//  More info on: http://asmhighlighter.codeplex.com
// 
//  ------------------------------------------------------------------
#endregion

using System;

namespace AsmHighlighter.Lexer
{
    [Flags]
    public enum AsmHighlighterToken : uint
    {
        EOF = 0,
        UNDEFINED = 1,
        IDENTIFIER = 2,
        INSTRUCTION = 3,
        DIRECTIVE = 4,
        FPUPROCESSOR = 5,
        SIMDPROCESSOR = 6,
        REGISTER = 7,
        REGISTER_FPU = 8,
        REGISTER_MMXSSE = 9,
		REGISTER_AVX = 10,
		REGISTER_AVX512 = 11,
        COMMENT_LINE = 12,
        NUMBER = 13 | IS_NUMBER,
        FLOAT = 14 | IS_NUMBER,
        STRING_LITERAL = 15,
        OPERATOR = 16,
        DELIMITER = 17,
        LEFT_PARENTHESIS = 18, 
        RIGHT_PARENTHESIS = 19, 
        LEFT_SQUARE_BRACKET = 20, 
        RIGHT_SQUARE_BRACKET = 21,
		SSE4 = 22,
		AVX2 = 23,
		FMA = 24,

        IS_REGISTER = 0x80000000,
        IS_INSTRUCTION = 0x40000000,
        IS_NUMBER = 0x20000000,
    }
}