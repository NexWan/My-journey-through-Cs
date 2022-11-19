# Loops

The loops in c# are very standard so shouldn't be that had to understand.

### While loop
The while loop will repeat an instruction until the main condition is met.
```c#
while(condition){
    do_this
}
```
A more elaborated example:
```c#
int i = 1;
while(i!= 5){
    Console.WriteLine("Hello! " + i");
    i++;
}
```
So in this case the loop will repeat 5 times.

### Do while
Almost the same as a while loop but in this case even if the main condition is not real it will execute the instuction ATLEAST once.

```c#
int i = 1;
do{
    some_instruction
}while(i!=1);
```
This code will repeat at least once.

### For loop
The for loop is my favorite loop and in this loop you can initialize a variable inside the conditions and do it while that variable is less or equal (or vice-versa) with a growing variable inside.
```c#
for(int i = 1; i <= 10 ; i++){
    do_This //this loop will repeat 10 times that is the condition set.
}
```