Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen



Scenario: Create Employee with mandatory details
	#Given 
	#And 
	When when i fill all the mandatory details in the form 
	#Then 
	
	| Name    | age | phone  | Email     |
	| shrawan | 21  | 1qa2ws | sky@amail |
	| Name    | age | phone  | Email     |
	| shrawan | 21  | 1qa2ws | sky@amail |
	| shrawan1 | 22  | 1qa2ws | sky@amail |
	| shrawan2 | 23  | 1qa2ws | sky@amail |
	| shrawa3 | 24  | 1qa2ws | sky@amail |

Scenario Outline: Create Employee with mandatory details for list 
	#Given 
	#And 
	When when i fill all the mandatory details in the form <Name>, <age>, <phone> and <email>
	#Then 
Examples: 
	| Name    | age | phone  | Email     |
	| shrawan | 21  | 1234567890 | sky@amail |
	| shrawan1 | 22  | 1234567890 | sky@amail |
	| shrawan2 | 23  | 1234567890 | sky@amail |
	| shrawa3 | 24  | 1234567890 | sky@amail |

	