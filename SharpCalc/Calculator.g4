grammar Calculator;
 
@parser::members
{
    protected const int EOF = Eof;
}
 
@lexer::members
{
    protected const int EOF = Eof;
    protected const int HIDDEN = Hidden;
}
 
/*
 * Nonterminals
 */
 
prog: expr+ ;
 
expr : '(' '-' expr ')'  # Negation
	 | expr op=('*'|'/') expr   # MulDiv
     | expr op=('+'|'-') expr   # AddSub
     | expr op=('>'|'<'|'<='|'>='|'==') expr   # Comparator
     | 'not' expr   # Not
     | expr 'and' expr   # And
     | expr 'or' expr   # Or
     | expr '=>' expr   # Implication
     | expr '<=>' expr   # Bidirectional
	 | datatype				# dtype
     | '(' expr ')'         # parens
     ;

datatype  : INT # int
	| FLOAT		# float
	| BOOLEAN	# bool
	;

/*
 * Terminals
 */
BOOLEAN: ('t'|'T'|'f'|'F'|'true'|'false');
INT : [0-9]+;
FLOAT : [0-9]+'.'[0-9]+;
MUL : '*';
DIV : '/';
ADD : '+';
SUB : '-';
LESSTHAN : '<';
GRATERTHAN : '>';
GRATERTHANOREQUAL : '>=';
LESSTHANOREQUAL : '<=';
EQUAL : '==';
WS  : (' ' | '\r' | '\n') -> channel(HIDDEN)
    ;