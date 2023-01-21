
<*>Open-Close Principle OCP
	=> the software enriries (classes, modules, Functions, ...) should be opent to extension, 
	but close on modifications

*This Module Talking about Question Bank of Varies Questions Type
* This module has two folder
	1- befor
		- describe module before applying open-close principle 
		- has 4 classes :-
			-- Question Class for properties of question.
			-- QuestionBank class has method tha generate different types of Questions by method called Generate
			-- QuestionType enum has Three Types of Questions
			-- Quiz class has print method that print the questions in specific pattern depend on question type.
	
	2- After
		- describe module After applying open-close principle 
		- has 7 classes :-
			-- Question class is abstrac and has 2 property and print method
			-- some classes represent on type of questions
			-- Quiz that print all Questoins which every one has it pattern
			-- QuestionBank class has method tha generate different types of Questions by method called Generate
