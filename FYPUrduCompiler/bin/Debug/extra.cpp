#include <iostream>
 #include<fcntl.h>
 #include<io.h>
 using namespace std; 
  
main ( ) 
{
 _setmode(_fileno(stdout), _O_U16TEXT); 

int A = 3 ; 

wcout  <<  "  weele \x645\x646  \x627\x686\x629\x627  \x628\x686\x647    "   ;


 int dummy;
 cin>>dummy;
 return 0; 
  } 


