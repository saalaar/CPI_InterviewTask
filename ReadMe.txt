--CPI Interview Task--

This folder contains 
	- * directories
		1. Source --> which contains source code for task
		2. bin --> which contains last built binaries for Release|Any CPU
	- * files
		1. Re-Build.bat --> batch file to execute re-build solution without opening visual studio
		2. Run.bat --> batch file runs executable Runner.executable
		
How to Run
	- Yoy can run this solution in visual studio or you can call "Run.bat" from any cmd window and if binaries are existed it will re-build solution after a confirmation
	
How to Build
	- you can  call "Re-Build.bat" from any cmd window 

This solution contains 6 Projects
1. Runner --> executable wrapper contains minimal UI Form main to print results
2. FindMissingNumber.Core --> library contains concrete implementation for FindMissingNumber problem (Interface and Exceptions)
3. FindMissingNumber --> library contains the real implementation for FindMissingNumber in an array problem
4. RemoveDuplicates.Core --> library contains concrete implementation for RemoveDuplicates (finding duplicates in both format of char & int) problem (Interface and Exceptions)
5. RemoveDuplicates --> library contains the real implementation for for RemoveDuplicates
6. CPI_Task.UnitTests --> library contains unit testing for both FindMissingNumber and RemoveDuplicates problems

Comments: 
	- CPI_Task.sln is configured to build "Release|Any CPU" by default
	- I know the task is basic to add "*.Core" libraries but I tried to show you how I code in real world
	- For real life world scenario, I would Implement logging system but for simplicity I'm just printing the error to th UI in form

FindMissingNumber Problem:
	Notes:
		I implemented the most generic algorithm for this problem
	
	Assumptions:
		1. we do not have any limit value for len of array
		2. input value for has handled for null and empty exceptions.
	
		
	Analysis:
		- Time Complextiy: O(n)
		- Space Complextiy: O(1)

		=======================================================
        =======================================================

		Remove Duplicates Problem:
	Assumptions:
		1. this program accepts strings which is seperated by comma  
		2. empty string or null string or just one character does not have any duplications.

	Analysis:
		- Time Complextiy: O(n)
		- Space Complextiy: O(1)
		
	Exceptions:
		- GivenStringIsEmpty: 
			* this exception is being thrown when give input string is null or empty or single space
			
Runner Executable wrapper:
	- Program.cs is the one who is handling all exceptions through: 
		Application.ThreadException += Application_ThreadException;
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
	  and handlers are setting Error Text to main form, to reflect to the UI, this is for simplicity and for real life scenario, I would implement logging
	
	- Main form is showing only custom exceptions, but for system exceptions Form will show "System Exception, There is no Logging System. Please contact moghimi.salar@gmail.com to check" :))
	

	
