grammar LabCalculator;

/*
* Parser Rules
*/
compileUnit : expression EOF;
expression :
LPAREN expression RPAREN #ParenthesizedExpr
|SUBTRACT LPAREN expression RPAREN #UnaryMinusExpr
|operatorToken=(INCREMENT|DECREMENT) LPAREN expression RPAREN #IncDecExpr
|expression EXPONENT expression #ExponentialExpr
|expression operatorToken=(MULTIPLY | DIVIDE) expression #MultiplicativeExpr
| expression operatorToken=(ADD | SUBTRACT) expression #AdditiveExpr
| NUMBER #NumberExpr
| IDENTIFIER #IdentifierExpr;

/*
 * Lexer Rules
 */

NUMBER : INT (',' INT)?; 
IDENTIFIER : [a-zA-Z]+[0-9]+;

INT : ('0'..'9')+;

EXPONENT : '^';
MULTIPLY : '*';
DIVIDE : '/';
SUBTRACT : '-';
ADD : '+';
INCREMENT: 'inc';
DECREMENT: 'dec';
LPAREN : '(';
RPAREN : ')';

WS : [ \t\r\n] -> channel(HIDDEN);