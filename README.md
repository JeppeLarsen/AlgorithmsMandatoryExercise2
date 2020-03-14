# AlgorithmsMandatoryExercise2

## The Exercise
Alan works as a lead developer at Macrosoft. So far he has had an easy time because he found a way to steal the source code from the inventive tinkerers at Dabble. Unfortunately for Alan, Dabble caught on what was going on, and decided to write all their software in the programming language Caesar++. Caesar++ is a programming language built specifically to be hard to read, and must be reverse-engineered in order to be used. Alan needs your help deciphering this new language, so he can keep his job.

Caesar++ source files consist solely of space-separated terms, a term is one of the following: alphabetical A to Z letters, numbers, or a special delete character '^' (without the quotes) denoting that the last number or letter must be deleted. Each letter, number and delete character is separated by space in the source files. E.g.

A ^ L G ^ O ^ R ^ I T H M S ^ ^ ^

will be translated into the more appropriate

L I T

In order to make the source code harder to read, the Caesar++ language has a built-in caesar-cipher. How this affects the code is that every time a delete character is written then, if the last term was a number, it shifts the caesar-cipher correspondingly to that number, e.g.

A B C 1 ^ A B C 2 A ^ ^ A B C

Will be translated to

A B C B C D D E F

Similar to how typing on a computer works in real-life, if you have not written anything then typing 'delete' does nothing.

## Input format
You will get two lines of input:

Line 1: a number N, denoting the number of terms, where N < 10^5
 
Line 2: N space-separated terms, each being either a capital letter ranging from A-Z, a delete character '^' (without quotes), or a number m, where 0 < m < 10^9 
 
## Output format
A single line of space-separated terms, denoting the translated source code.

## Examples

### Input

12
H E L L O 3 ^ T L O I A

### Output

H E L L O W O R L D

### Input

9
A B C 1 ^ ^ A B C

### Output
A B B C D
