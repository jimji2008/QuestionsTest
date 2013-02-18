// amazonTest.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <vector>


std::vector<std::string> split(std::string str,std::string pattern)
 {
     std::string::size_type pos;
     std::vector<std::string> result;
     str+=pattern;//扩展字符串以方便操作
     int size=str.size();
 
     for(int i=0; i<size; i++)
     {
         pos=str.find(pattern,i);
         if(pos<size)
         {
             std::string s=str.substr(i,pos-i);
             result.push_back(s);
             i=pos+pattern.size()-1;
         }
     }
     return result;
 }

int _tmain(int argc, _TCHAR* argv[])
{
	std::string line;
	std::getline(std::cin, line);
    //std::cout << line << std::endl;
	std::vector<std::string> v= split(line," ");
	//std::cout<<v[0]<<std::endl;
	//std::cout<<v[0]<<std::endl;
	int n = atoi(v[0].c_str());
	int m = atoi(v[1].c_str());
	//std::cout<<n<<'\n';
	//std::cout<<m<<'\n';

	int sum=0;
	for(int i=0;i<m;i++)
	{
		int next = 0;
		std::string c=std::string("");
		for(int j=0;j<=i;j++){
			c += v[0];
			//std::cout<<c<<"x\n";
		}
		sum+=atoi(c.c_str());
	}
	std::cout<<sum;


	//std::vector<std::string> result=split(str,pattern);

	//char *strings[2];
	////char Policystr[4096] = "the|string|to|split"; 
	//char delims[] = "|";
	//int i = 0;
 //   strings[i] = strtok( line, delims );
	//printf("%s",strings[0]);
	//int i = 0;
	// while( strings[i] != NULL  ) 
 //   {
 //       printf("%d '%s'\n", i, strings[i]);
 //       strings[++i] = strtok( NULL, delims );          
 //   }
	// printf("'%s'\n", strings[0]);
	
	

	return 0;
}


