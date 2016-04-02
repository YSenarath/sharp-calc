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
 * Parser Rules
 */
 
prog: expr+ ;
 
expr : '(' '-' expr ')'  # Negation
	 | expr op=('*'|'/') expr   # MulDiv
     | expr op=('+'|'-') expr   # AddSub
     | 'not' expr   # Not
     | expr 'and' expr   # And
     | expr 'or' expr   # Or
     | expr '=>' expr   # Implication
     | expr '<=>' expr   # Bidirectional
     | expr op=('+'|'-') expr   # AddSub
	 | datatype				# dtype
     | '(' expr ')'         # parens
     ;

datatype  : INT # int
	| FLOAT		# float
	| BOOLEAN	# bool
	;

/*
 * Lexer Rules
 */
BOOLEAN: ('t'|'T'|'f'|'F'|'true'|'false');
INT : [0-9]+;
FLOAT : [0-9]+'.'[0-9]+;
MUL : '*';
DIV : '/';
ADD : '+';
SUB : '-';
WS  : (' ' | '\r' | '\n') -> channel(HIDDEN)
    ;